using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P2_2020CG601_2020MR602_2020RO601.Models;

namespace P2_2020CG601_2020MR602_2020RO601.Controllers
{
    public class CasosReportados : Controller
    {
        private readonly covidContext _covidContext;
        public CasosReportados(covidContext covidContext)
        {
            _covidContext= covidContext;
        }
        public IActionResult indexx() 
        {
            var listadoDepartamentos = (from d in _covidContext.Departamentos select d).ToList();
            ViewData["listadoDepartamentos"] = new SelectList(listadoDepartamentos, "id_departamento", "nombre_departamento");

            var listadoDeGeneros = (from g in _covidContext.Generos select g).ToList();
            ViewData["listadoDeGeneros"] = new SelectList(listadoDeGeneros, "id_genero", "nombre_genero");
            
            return View();
        }
    }
}
