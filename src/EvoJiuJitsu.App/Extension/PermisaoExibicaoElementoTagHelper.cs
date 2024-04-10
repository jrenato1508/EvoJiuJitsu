using Microsoft.AspNetCore.Razor.TagHelpers;

namespace EvoJiuJitsu.App.Extension
{
    [HtmlTargetElement("*",Attributes ="supress-by-claim-name")]
    [HtmlTargetElement("*", Attributes = "supress-by-claim-value")]
    public class PermisaoExibicaoElementoTagHelper : TagHelper
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public PermisaoExibicaoElementoTagHelper(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        [HtmlAttributeName("supress-by-claim-name")]
        public string IdentityClaimName { get; set; }

        [HtmlAttributeName("supress-by-claim-value")]
        public string IdentityClaimValue { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if(context ==null) throw new ArgumentNullException(nameof(context));

            if(output ==null) throw new ArgumentNullException(nameof(output));

            var temAcesso = CustomAuthorization.ValidarClaimsUsuario(_contextAccessor.HttpContext, IdentityClaimName, IdentityClaimValue);

            if (temAcesso) return;
            
            output.SuppressOutput();
        }
    }
}
