using EvoJiuJitsu.App.ViewModels;
using System.Drawing;

namespace EvoJiuJitsu.App.Services
{
    public static class FormatarDocumento
    {
        #region OBS
        // Passamos a responsabilidade de validar o cpf para a camada Business utilizando o fluent Validation para isso. Deixei o código pronto aqui para reuso caso precisarmos
        #endregion
        public static void FormatarDocumentos(AtletaViewModel atleta)
        {
            atleta.Cpf = SemFormatacao(atleta.Cpf);
        }

        #region MyRegion FormatCNPJ
        /// <summary>
        /// Formatar uma string CNPJ
        /// </summary>
        /// <param name="CNPJ">string CNPJ sem formatacao</param>
        /// <returns>string CNPJ formatada</returns>
        /// <example>Recebe '99999999999999' Devolve '99.999.999/9999-99'</example>

        private static string FormatCNPJ(string CNPJ)
        {
            return Convert.ToUInt64(CNPJ).ToString(@"00\.000\.000\/0000\-00");
        }

        #endregion

        #region FormatCPF
        /// <summary>
        /// Formatar uma string CPF
        /// </summary>
        /// <param name="CPF">string CPF sem formatacao</param>
        /// <returns>string CPF formatada</returns>
        /// <example>Recebe '99999999999' Devolve '999.999.999-99'</example>

        private static string FormatCPF(string CPF)
        {
            return Convert.ToUInt64(CPF).ToString(@"000\.000\.000\-00");
        }
        #endregion

        #region SemFormatacao
        /// <summary>
        /// Retira a Formatacao de uma string CNPJ/CPF
        /// </summary>
        /// <param name="Codigo">string Codigo Formatada</param>
        /// <returns>string sem formatacao</returns>
        /// <example>Recebe '99.999.999/9999-99' Devolve '99999999999999'</example>

        private static string SemFormatacao(string Codigo)
        {
            return Codigo.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty);
        }
        #endregion

    }
}
