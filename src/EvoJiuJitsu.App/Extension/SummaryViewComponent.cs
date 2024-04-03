using EvoJiuJitsu.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EvoJiuJitsu.App.Extension
{
    public class SummaryViewComponent : ViewComponent
    {
        private readonly INotificador _notificador;

        public SummaryViewComponent(INotificador notifica)
        {
            _notificador = notifica;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var notificacoes = await Task.FromResult(_notificador.ObterNotificacoes());
            notificacoes.ForEach(notificacoes => ViewData.ModelState.AddModelError(string.Empty, notificacoes.Mensagem));
            return View();
        }
    }
}
