using Microsoft.AspNetCore.Mvc;

namespace EvoJiuJitsu.App.Configurations
{
    public static class MvcConfig
    {
        public static IServiceCollection AddMvcConfiguration(this IServiceCollection services)
        {
            #region
            /*
             
             isso está na biblioteca Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore.
            O AddDatabaseDeveloperPageExceptionFilterfornece informações úteis sobre erros no ambiente de desenvolvimento para erros de migração do EF.
            Conforme descrito no guia Razor Pages with Entity Framework Core no ASP.NET Core na seção Adicionar o filtro de exceção do banco de dados demonstrando como
            implementar.
            Este pacote NuGet fornece middleware ASP.NET Core para páginas de erro do Entity Framework Core. Este middleware ajuda a detectar e diagnosticar 
            erros nas migrações do Entity Framework Core.
             */
            #endregion
            services.AddDatabaseDeveloperPageExceptionFilter();


            services.AddControllersWithViews(o =>
            {
                o.ModelBindingMessageProvider.SetAttemptedValueIsInvalidAccessor((x, y) => "O valor preenchido é inválido para este campo.");
                o.ModelBindingMessageProvider.SetMissingBindRequiredValueAccessor(x => "Este campo precisa ser preenchido.");
                o.ModelBindingMessageProvider.SetMissingKeyOrValueAccessor(() => "Este campo precisa ser preenchido.");
                o.ModelBindingMessageProvider.SetMissingRequestBodyRequiredValueAccessor(() => "É necessário que o body na requisição não esteja vazio.");
                o.ModelBindingMessageProvider.SetNonPropertyAttemptedValueIsInvalidAccessor(x => "O valor preenchido é inválido para este campo.");
                o.ModelBindingMessageProvider.SetNonPropertyUnknownValueIsInvalidAccessor(() => "O valor preenchido é inválido para este campo.");
                o.ModelBindingMessageProvider.SetNonPropertyValueMustBeANumberAccessor(() => "O campo deve ser numérico");
                o.ModelBindingMessageProvider.SetUnknownValueIsInvalidAccessor(x => "O valor preenchido é inválido para este campo.");
                o.ModelBindingMessageProvider.SetValueIsInvalidAccessor(x => "O valor preenchido é inválido para este campo.");
                o.ModelBindingMessageProvider.SetValueMustBeANumberAccessor(x => "O campo deve ser numérico.");
                o.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(x => "Este campo precisa ser preenchido.");

            });


            services.AddRazorPages()
                    .AddRazorRuntimeCompilation();

            // Add services to the container.
            return services;
        }
    }
}
