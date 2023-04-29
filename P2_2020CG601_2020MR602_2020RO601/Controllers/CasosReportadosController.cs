using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P2_2020CG601_2020MR602_2020RO601.Models;

namespace P2_2020CG601_2020MR602_2020RO601.Controllers
{
    public class CasosReportadosController : Controller
    {
        private readonly covidContext _covidContext;
        public CasosReportadosController(covidContext covidContext)
        {
            _covidContext = covidContext;
        }
        public IActionResult Index()
        {
            var listadoDepartamentos = (from d in _covidContext.Departamentos select d).ToList();
            ViewData["listadoDepartamentos"] = new SelectList(listadoDepartamentos, "id_departamento", "nombre_departamento");

            var listadoDeGeneros = (from g in _covidContext.Generos select g).ToList();
            ViewData["listadoDeGeneros"] = new SelectList(listadoDeGeneros, "id_genero", "nombre_genero");

            var listadoCasosReportados = (from c in _covidContext.CasosReportados
                                          join d in _covidContext.Departamentos
                                          on c.id_departamento equals d.id_departamento
                                          join g in _covidContext.Generos
                                          on c.id_genero equals g.id_genero
                                          select new
                                          {
                                              departamento = d.nombre_departamento,
                                              genero = g.nombre_genero,
                                              confirmados = c.casosConfirmados,
                                              recuperados = c.casosRecuperados,
                                              fallecidos = c.casosFallecidos,
                                          }).ToList();
            ViewData["listadoCasosReportados"] = listadoCasosReportados;

            return View();
        }
        public IActionResult crearRegistro(CasosReportados CasoNuevo)
        {
            _covidContext.Add(CasoNuevo);
            _covidContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

