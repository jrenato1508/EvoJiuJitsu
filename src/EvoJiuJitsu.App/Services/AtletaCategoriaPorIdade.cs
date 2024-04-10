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
                    case int intervalo when (intervalo > 0 && intervalo <= 15):
                        alteta.CategoriaPorIdade = (ViewModels.CategoriaIdade)1;
                        break;

                    case int intervalo when (intervalo > 15 && intervalo <= 17):
                        alteta.CategoriaPorIdade = (ViewModels.CategoriaIdade)2;
                        break;

                    case int intervalo when (intervalo > 17 && intervalo <= 30):
                        alteta.CategoriaPorIdade = (ViewModels.CategoriaIdade)3;
                        break;

                    case int intervalo when (intervalo > 30 && intervalo <= 35):
                        alteta.CategoriaPorIdade = (ViewModels.CategoriaIdade)4;
                        break;

                    case int intervalo when (intervalo > 35 && intervalo <= 40):
                        alteta.CategoriaPorIdade = (ViewModels.CategoriaIdade)5;
                        break;

                    case int intervalo when (intervalo > 40 && intervalo <= 45):
                        alteta.CategoriaPorIdade = (ViewModels.CategoriaIdade)6;
                        break;

                    case int intervalo when (intervalo > 45 && intervalo <= 50):
                        alteta.CategoriaPorIdade = (ViewModels.CategoriaIdade)7;
                        break;

                    case int intervalo when (intervalo > 50 && intervalo <= 55):
                        alteta.CategoriaPorIdade = (ViewModels.CategoriaIdade)8;
                        break;

                    case int intervalo when (intervalo > 55 && intervalo < 150):
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
