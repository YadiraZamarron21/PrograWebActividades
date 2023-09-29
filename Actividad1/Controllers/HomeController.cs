using Actividad1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Actividad1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            IndexViewModel vm = new()
            {
                NombreMateria = "Programación Web",
                Semestre = 7,
                Periodo = "Agosto - Diciembre",
                Nombre = "Yadira Guadalupe Zamarrón Rodríguez"
            };
            return View(vm);
        }

        public IActionResult Perfil()
        {
            PerfilViewModel vm = new()
            {

                NombreAlumno = "Yadira Guadalupe Zamarrón Rodríguez",
                Correo = "201G0292@rcarbonifera.tecnm.mx",
                Especialidad = "Desarrollo Multiplataforma",
                NumeroControl = "201G0292",
                Semestre = 7,
            };
            return View(vm);
        }
    }
}
