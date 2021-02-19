using AvaliacaoEntrevistaAudrey2.DataBase;
using AvaliacaoEntrevistaAudrey2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoEntrevistaAudrey2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private EquipamentoContext _banco;

        public HomeController(EquipamentoContext banco, ILogger<HomeController> logger)
        {
            _logger = logger;
            _banco = banco;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Valida e envia o Formulario
        public IActionResult Cadastrar([FromForm] Equipamento equipamento) 
        {

            if (ModelState.IsValid)
            {
                _banco.Equipamentos.Add(equipamento);
                _banco.SaveChanges();
                //TempData["MSG_S"] = "Registro salvo com sucesso";
                return RedirectToAction(nameof(Index));
            }
            else {
                
                //StringBuilder sb = new StringBuilder();
                //foreach (var texto in listaMensagens)
                //{
                //    sb.Append(texto.ErrorMessage + "<br />");
                //}

                //ViewData["MSG_E"] = sb.ToString();
                //ViewData["CONTATO"] = contato;


                return View();
            }
        }

        //Faz a busca dos estados no banco
        //public IActionResult BuscaEstado() 
        //{ 
        
        
        
        //}

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
