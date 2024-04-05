using Microsoft.AspNetCore.Mvc.Razor;

namespace EvoJiuJitsu.App.Extension
{
    public static class RazorExtensions
    {
        public static string FormatarDocumento(this RazorPage page, string documento)
        {
            return Convert.ToUInt64(documento).ToString(@"000\.000\.000\-00");
        }
    }
}
