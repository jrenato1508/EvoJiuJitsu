using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoJiuJitsu.Business.Models
{
    public class Atleta : Entity
    {
        
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Peso { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public Sexo Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public Faixa Faixa { get; set; }
        public CategoriaIdade CategoriaPorIdade { get; set; }
        public CategoriaPeso CategoriaPeso { get; set; }
        public DateTime DataCadastro { get; set; }
        public Polo Polo { get; set; }
        public Endereco Endereco { get; set; }
    }
}
public enum Polo
{
    CONDOR =1,
    UMARIZAL,
    MGA,
    PERNOH,
    BESTFIT,
    OUTRO
}
public enum Sexo
{
    Masculino = 1,
    Feminino
}
public enum CategoriaIdade
{
    Sem_categoria = 1,
    Juvenil,    // 16 e 17 anos
    Adulto,     // 18 a 29 anos
    Master01,   // 30 a 35 anos
    Master02,   // 36 a 40 anos
    Master03,   // 41 a 45 anos
    Master04,   // 46 a 50 anos
    Master05,   // 51 a 55 anos
    Master06,   // 56 em diante

}

public enum CategoriaPeso
{
    Galo = 1,   
    Pluma,      
    Pena,       
    Leve,
    Medio,
    Meio_Pesado,
    Pesado,
    Super_Pesado,
    Pessadíssimo,
}



public enum Faixa
{
    Branca = 1,
    Azul,
    Roxa,
    Marrom,
    Preta,
    Coral,
    Vermelha
}