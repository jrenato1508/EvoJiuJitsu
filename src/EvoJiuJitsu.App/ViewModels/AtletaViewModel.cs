using EvoJiuJitsu.Business.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace EvoJiuJitsu.App.ViewModels
{
    public class AtletaViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage ="O campo{0} precisa ter entre {2} e {1} caracteres", MinimumLength =2)]
        public string Nome { get; set; }

        public string Idade { get; set; }

        [Required(ErrorMessage ="O campo {0} é Obrigatorio")]
        [IntegerValidator]
        public string Peso { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage ="O campo {0} é obrigatório e precisa ter entre {2} e {1} caracteres", MinimumLength =11)]
        public string Cpf { get; set; }

        [Required(ErrorMessage ="O campo {0} é Obrigatório")]
        public Sexo Sexo { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        public Faixa Faixa { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [DisplayName("Categoria Idade")]
        public CategoriaIdade CategoriaPorIdade { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [DisplayName("Categoria Peso")]
        public CategoriaPeso CategoriaPeso { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Polo Polo { get; set; }

        public DateTime DataCadastro { get; set; }
      
    }

    public enum Polo
    {
        CONDOR = 1,
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
        Sem_Categoria
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
}


