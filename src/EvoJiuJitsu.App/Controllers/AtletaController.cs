﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EvoJiuJitsu.App.Data;
using EvoJiuJitsu.App.ViewModels;
using EvoJiuJitsu.Data.Context;
using AutoMapper;
using EvoJiuJitsu.Business.Interfaces;
using EvoJiuJitsu.Business.Models;
using EvoJiuJitsu.App.Services;
using System.Drawing;

namespace EvoJiuJitsu.App.Controllers
{
    public class AtletaController : BaseController
    {
        private readonly IAtletaRepository _AtletaRepository;
        private readonly IAtletaService _AtletaService; 
        private readonly IMapper _Mapper;

        public AtletaController(IAtletaRepository atletaRepository,
                                IAtletaService atletaService,
                                IMapper mapper,
                                INotificador notificador) : base(notificador)
        {
            _AtletaRepository = atletaRepository;
            _AtletaService = atletaService;
            _Mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
                                
              return View(_Mapper.Map<IEnumerable<AtletaViewModel>>(await _AtletaRepository.ObterAtletasOrdemAlfabetica()));
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var atleta = await ObterAtleta(id);

            if (atleta == null)
            {
                return NotFound();
            }

            return View(atleta);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AtletaViewModel atletaViewModel)
        {
            atletaViewModel.Idade = CalcularIdade(atletaViewModel.DataNascimento);

            AtletaCategoriaPorIdade.CalcularCategoriaPorIdade(atletaViewModel);
            AtletaCategoriaPorPeso.CalcularCategoriaPeso(atletaViewModel);
            

            if (!ModelState.IsValid) return View(atletaViewModel);

            var atleta = _Mapper.Map<Atleta>(atletaViewModel);

            await _AtletaService.Adicionar(atleta);

            if ((!OperacaoValida())) return View(atletaViewModel);

            return RedirectToAction("Index");

            /*
              Testar a validação de criação de novos altletas bem como as edições
             
             */
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var atletaViewModel = await ObterAtleta(id);

            if (atletaViewModel == null) return NotFound();

            return View(atletaViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, AtletaViewModel atletaViewModel)
        {
            if (id != atletaViewModel.Id) return NotFound();
            if (!ModelState.IsValid) return View(atletaViewModel);

            var AtletaAtualizado = _Mapper.Map<Atleta>(atletaViewModel);
            await _AtletaService.Atualizar(AtletaAtualizado);

            if(!OperacaoValida()) return View(atletaViewModel);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var alteta = await ObterAtleta(id);

            if (alteta == null) return NotFound();

            return View(alteta);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var Atleta = await ObterAtleta(id);
            if(Atleta == null)  return NotFound();
            await _AtletaService.Remover(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<AtletaViewModel> ObterAtleta(Guid id)
        {
          return _Mapper.Map<AtletaViewModel>(await _AtletaRepository.ObterPorId(id));
        }

        private string CalcularIdade(DateTime Datanascimento)
        {
            
            DateTime AnoAtual = DateTime.Now;
            TimeSpan Diferenca = DateTime.Today - Datanascimento;
            DateTime Idade = (new DateTime() + Diferenca).AddYears(-1).AddDays(-1);
            string idade = Convert.ToString(Idade.Year);

            return idade;
        }

    }
}