using Actividad2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(ConversionMonedaViewModel vm, string conver)
        {
            if (conver == "USD")
            {
                vm.Total = $"{(vm.Cantidad / 18).ToString("$0.00")} dólares";
            }
            else if (conver == "MXN")
            {
                vm.Total = $"{(vm.Cantidad * 18).ToString("$0.00")} pesos";
            }
            return View(vm);
        }
    }
}
