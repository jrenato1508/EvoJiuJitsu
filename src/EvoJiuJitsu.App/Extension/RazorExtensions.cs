using Microsoft.AspNetCore.Mvc.Razor;

namespace EvoJiuJitsu.App.Extension
{
    public static class RazorExtensions
    {
        public static string FormatarDocumento(this RazorPage page, string documento)
        {
            return Convert.ToUInt64(documento).ToString(@"000\.000\.000\-00");
        }

        public static string FormataTelefone(this RazorPage page, string telefone)
        {
            return Convert.ToUInt64(telefone).ToString(@"(00\) 00000\-0000");
        }
    }
}
