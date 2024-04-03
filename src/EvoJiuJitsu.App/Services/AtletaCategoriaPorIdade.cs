using EvoJiuJitsu.App.ViewModels;

namespace EvoJiuJitsu.App.Services
{
    public static class AtletaCategoriaPorIdade
    {
        #region AtletaCategoriaIdade
        public static void CalcularCategoriaPorIdade(AtletaViewModel alteta)
        {
                int idadeConvertida = int.Parse(alteta.Idade);

                switch (idadeConvertida)
                {
                    case int intervalo when (intervalo > 0 && intervalo < 15):
                        alteta.CategoriaPorIdade = (ViewModels.CategoriaIdade)1;
                        break;

                    case int intervalo when (intervalo > 16 && intervalo < 17):
                        alteta.CategoriaPorIdade = (ViewModels.CategoriaIdade)2;
                        break;

                    case int intervalo when (intervalo > 18 && intervalo < 29):
                        alteta.CategoriaPorIdade = (ViewModels.CategoriaIdade)3;
                        break;

                    case int intervalo when (intervalo > 30 && intervalo < 35):
                        alteta.CategoriaPorIdade = (ViewModels.CategoriaIdade)4;
                        break;

                    case int intervalo when (intervalo > 36 && intervalo < 40):
                        alteta.CategoriaPorIdade = (ViewModels.CategoriaIdade)5;
                        break;

                    case int intervalo when (intervalo > 41 && intervalo < 45):
                        alteta.CategoriaPorIdade = (ViewModels.CategoriaIdade)6;
                        break;

                    case int intervalo when (intervalo > 46 && intervalo < 50):
                        alteta.CategoriaPorIdade = (ViewModels.CategoriaIdade)7;
                        break;

                    case int intervalo when (intervalo > 51 && intervalo < 55):
                        alteta.CategoriaPorIdade = (ViewModels.CategoriaIdade)8;
                        break;

                    case int intervalo when (intervalo > 56 && intervalo < 150):
                        alteta.CategoriaPorIdade = (ViewModels.CategoriaIdade)9;
                        break;

                    default:
                        alteta.CategoriaPorIdade = (ViewModels.CategoriaIdade)1;
                        break;
                }
            
        }

        #endregion

       
    }
}
