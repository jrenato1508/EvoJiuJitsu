using EvoJiuJitsu.Business.Interfaces;
using EvoJiuJitsu.Business.Models;
using EvoJiuJitsu.Business.Models.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoJiuJitsu.Business.Services
{
    public class AtletaService : BaseService, IAtletaService
    {
        private readonly IAtletaRepository _Atletarepository;
        private readonly IEnderecoRepository _EnderecoRepository;
        public AtletaService(INotificador notificador, IAtletaRepository atletarepository,
                             IEnderecoRepository enderecoRepository) : base(notificador)
        {
            _Atletarepository = atletarepository;
            _EnderecoRepository = enderecoRepository;
        }

        public async Task Adicionar(Atleta atleta)
        {
            if (!ExecurarValidacao(new AtletaValidation(), atleta)) return;

            if(_Atletarepository.Buscar(a => a.Cpf == atleta.Cpf).Result.Any())
            {
                Notificar("Já Existe um fornecedor com este documento.");
                return;
            }

            await _Atletarepository.Adicionar(atleta);
        }

        public async Task Atualizar(Atleta atleta)
        {
            if (!ExecurarValidacao(new AtletaValidation(), atleta)) return;

            if (_Atletarepository.Buscar(a => a.Cpf == atleta.Cpf && a.Id != atleta.Id).Result.Any())
            {
                Notificar("Já Existe um fornecedor com este documento.");
                return;
            }

            await _Atletarepository.Atualizar(atleta);
        }

        public async Task Remover(Guid id)
        {
            var atleta = await _Atletarepository.ObterAtletaPorId(id);

            if (atleta == null)
            {
                Notificar("Nenhum Atleta foi encontrado com o ID fornecido");
                return;
            }
            var endereco = await _EnderecoRepository.ObterAtletaEnderecoPorAtleta(id);

            if(endereco !=null)
            {
                await _EnderecoRepository.Remover(endereco.Id);
            }

            await _Atletarepository.Remover(id);
        }


        public async Task AtualizarEndereco(Endereco endereco)
        {
            if (!ExecurarValidacao(new EnderecoValidation(), endereco)) return;

            await _EnderecoRepository.Atualizar(endereco);
        }


        public void Dispose()
        {
            _Atletarepository?.Dispose();
        }

       
    }
}
