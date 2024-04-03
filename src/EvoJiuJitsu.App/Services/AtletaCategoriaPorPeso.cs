using EvoJiuJitsu.App.ViewModels;

namespace EvoJiuJitsu.App.Services
{
    public static class AtletaCategoriaPorPeso
    {
        public static void CalcularCategoriaPeso(AtletaViewModel atletaViewModel)
        {
            if (atletaViewModel.Sexo.Equals(Sexo.Masculino))
            {
                if (atletaViewModel.CategoriaPorIdade.Equals(CategoriaIdade.Juvenil))
                {
                    CalcularCateriaHomemJuvenil(atletaViewModel);
                }
                else
                {
                    CalcularCateriaHomemAdultoMaste(atletaViewModel);
                }
            }
            else
            {
                if (atletaViewModel.CategoriaPorIdade.Equals(CategoriaIdade.Juvenil))
                {
                    CalcularCateriaMulherJuvenil(atletaViewModel);
                }
                else
                {
                    CalcularCateriaMulherAdultoMaster(atletaViewModel);
                }

            }
        }

            private static void CalcularCateriaHomemJuvenil(AtletaViewModel atleta)
            {
                int PesoAtleta = int.Parse(atleta.Peso);

                switch (PesoAtleta)
                {
                    case int intervaloPeso when (intervaloPeso > 0 && intervaloPeso < 53.50):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)1;
                        break;

                    case int intervaloPeso when (intervaloPeso > 53.50 && intervaloPeso < 58.50):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)2;
                        break;

                    case int intervaloPeso when (intervaloPeso > 58.50 && intervaloPeso < 64):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)3;
                        break;

                    case int intervaloPeso when (intervaloPeso > 64 && intervaloPeso < 69):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)4;
                        break;

                    case int intervaloPeso when (intervaloPeso > 69 && intervaloPeso < 74):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)5;
                        break;

                    case int intervaloPeso when (intervaloPeso > 74 && intervaloPeso < 79.30):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)6;
                        break;

                    case int intervaloPeso when (intervaloPeso > 79.30 && intervaloPeso < 84.30):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)7;
                        break;

                    case int intervaloPeso when (intervaloPeso > 84.30 && intervaloPeso < 89.30):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)8;
                        break;

                    case int intervaloPeso when (intervaloPeso > 89.30 && intervaloPeso < 200):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)9;
                        break;

                    default:
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)10;
                        break;
                }
            }


            private static void CalcularCateriaMulherJuvenil(AtletaViewModel atleta)
            {
                int PesoAtleta = int.Parse(atleta.Peso);

                switch (PesoAtleta)
                {
                    case int intervaloPeso when (intervaloPeso > 0 && intervaloPeso < 48.30):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)2;
                        break;

                    case int intervaloPeso when (intervaloPeso > 48.30 && intervaloPeso < 52.50):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)3;
                        break;

                    case int intervaloPeso when (intervaloPeso > 52.50 && intervaloPeso < 56.50):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)4;
                        break;

                    case int intervaloPeso when (intervaloPeso > 56.50 && intervaloPeso < 60.50):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)5;
                        break;

                    case int intervaloPeso when (intervaloPeso > 60.50 && intervaloPeso < 65):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)6;
                        break;

                    case int intervaloPeso when (intervaloPeso > 65 && intervaloPeso < 200):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)7;
                        break;

                    default:
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)10;
                        break;
                }
            }


            private static void CalcularCateriaHomemAdultoMaste(AtletaViewModel atleta)
            {
                int PesoAtleta = int.Parse(atleta.Peso);

                switch (PesoAtleta)
                {
                    case int intervaloPeso when (intervaloPeso > 0 && intervaloPeso < 57.50):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)1;
                        break;

                    case int intervaloPeso when (intervaloPeso > 57.50 && intervaloPeso < 64):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)2;
                        break;

                    case int intervaloPeso when (intervaloPeso > 64 && intervaloPeso < 70):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)3;
                        break;

                    case int intervaloPeso when (intervaloPeso > 70 && intervaloPeso <= 76):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)4;
                        break;

                    case int intervaloPeso when (intervaloPeso > 76 && intervaloPeso <= 82.30):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)5;
                        break;

                    case int intervaloPeso when (intervaloPeso > 82.30 && intervaloPeso <= 88.30):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)6;
                        break;

                    case int intervaloPeso when (intervaloPeso > 88.30 && intervaloPeso <= 94.30):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)7;
                        break;

                    case int intervaloPeso when (intervaloPeso > 94.30 && intervaloPeso <= 100.50):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)8;
                        break;

                    case int intervaloPeso when (intervaloPeso > 100.50 && intervaloPeso < 200):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)9;
                        break;

                    default:
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)10;
                        break;
                }

            }


            private static void CalcularCateriaMulherAdultoMaster(AtletaViewModel atleta)
            {
                int PesoAtleta = int.Parse(atleta.Peso);

                switch (PesoAtleta)
                {
                    case int intervaloPeso when (intervaloPeso > 0 && intervaloPeso <= 53.30):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)2;
                        break;

                    case int intervaloPeso when (intervaloPeso > 53.30 && intervaloPeso <= 58.50):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)3;
                        break;

                    case int intervaloPeso when (intervaloPeso > 58.50 && intervaloPeso <= 64):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)4;
                        break;

                    case int intervaloPeso when (intervaloPeso > 64 && intervaloPeso <= 69):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)5;
                        break;

                    case int intervaloPeso when (intervaloPeso > 69 && intervaloPeso <= 74):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)6;
                        break;

                    case int intervaloPeso when (intervaloPeso > 74 && intervaloPeso < 200):
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)7;
                        break;

                    default:
                        atleta.CategoriaPeso = (ViewModels.CategoriaPeso)10;
                        break;
                }

            }
        
    }
}
