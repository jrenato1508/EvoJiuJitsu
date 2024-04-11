using Microsoft.AspNetCore.Mvc;
using EvoJiuJitsu.App.ViewModels;
using AutoMapper;
using EvoJiuJitsu.Business.Interfaces;
using EvoJiuJitsu.Business.Models;
using EvoJiuJitsu.App.Services;
using Microsoft.AspNetCore.Identity;

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
            var atleta = await ObterAltetaEndereco(id);

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
            FormatarDocumento.FormatarDocumentos(atletaViewModel);

            if (!ModelState.IsValid) return View(atletaViewModel);

            var atleta = _Mapper.Map<Atleta>(atletaViewModel);

            await _AtletaService.Adicionar(atleta);

            if ((!OperacaoValida())) return View(atletaViewModel);

            return RedirectToAction("Index");

            
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var atletaViewModel = await ObterAltetaEndereco(id);

            if (atletaViewModel == null) return NotFound();

            return View(atletaViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, AtletaViewModel atletaViewModel)
        {
            if (id != atletaViewModel.Id) return NotFound();
            atletaViewModel.Idade = CalcularIdade(atletaViewModel.DataNascimento);
            AtletaCategoriaPorIdade.CalcularCategoriaPorIdade(atletaViewModel);
            AtletaCategoriaPorPeso.CalcularCategoriaPeso(atletaViewModel);
            FormatarDocumento.FormatarDocumentos(atletaViewModel);
            
            if (!ModelState.IsValid) return View(atletaViewModel);
            
            var AtletaAtualizado = _Mapper.Map<Atleta>(atletaViewModel);
            await _AtletaService.Atualizar(AtletaAtualizado);

            if(!OperacaoValida()) return View(atletaViewModel);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var alteta = await ObterAltetaEndereco(id);

            if (alteta == null) return NotFound();

            return View(alteta);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var Atleta = await ObterAltetaEndereco(id);

            if(Atleta == null)  return NotFound();

            await _AtletaService.Remover(id);

            if(!OperacaoValida()) return View(Atleta);

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> AtualizarEndereco(Guid id)
        {
            var atleta = await ObterAltetaEndereco(id);
            
            if(atleta == null) return NotFound();

            return PartialView("_AtualizarEndereco", new AtletaViewModel { Endereco = atleta.Endereco });

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AtualizarEndereco(AtletaViewModel AtletaViewModel)
        {
            ModelState.Remove("Nome");
            ModelState.Remove("Peso");
            ModelState.Remove("Cpf");
            ModelState.Remove("Telefone");
         

            if (!ModelState.IsValid) return PartialView("_AtualizarEndereco", AtletaViewModel);

            await _AtletaService.AtualizarEndereco(_Mapper.Map<Endereco>(AtletaViewModel.Endereco));

            var url = Url.Action("ObterEndereco","Atleta", new {id = AtletaViewModel.Endereco.AtletaId});

            return Json(new { success = true, url });
        }

        public async Task<IActionResult> ObterEndereco(Guid id)
        {
            var atleta = await ObterAltetaEndereco(id);

            if (atleta == null)
            {
                return NotFound();
            }

            return PartialView("_DetalhesEndereco", atleta);
        }


        private async Task<AtletaViewModel> ObterAtleta(Guid id)
        {
          return _Mapper.Map<AtletaViewModel>(await _AtletaRepository.ObterAtletaPorId(id));
        }

        private async Task<AtletaViewModel> ObterAltetaEndereco(Guid id)
        {
            return _Mapper.Map<AtletaViewModel>(await _AtletaRepository.ObterEndercoAtleta(id));
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
