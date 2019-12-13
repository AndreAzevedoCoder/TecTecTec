using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FeedbackMVC.Models;
using FeedbackMVC.ViewModels;
using FeedbackMVC.Repositories;
using Microsoft.AspNetCore.Http;

namespace FeedbackMVC.Controllers
{
    public class ClienteController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Login()
        {

            BaseViewModel baseviewmodel = new BaseViewModel();
            baseviewmodel.UsuarioLogado = ObterUsuarioSession();
            return View(baseviewmodel);

        }
        [HttpPost]
        public IActionResult Logar(IFormCollection form)
        {
            if(clienteRepository.Existe(form["UsuarioArroba"],"Usuario_Arroba") == true)
            {
                Cliente cliente = clienteRepository.ObterPorArroba(form["UsuarioArroba"]);
                if(cliente.Senha == form["Senha"])
                {
                    BaseViewModel baseviewmodel = new BaseViewModel();
                    HttpContext.Session.SetString("Usuario",cliente.UsuarioArroba);
                    baseviewmodel.UsuarioLogado = ObterUsuarioSession();
                    return RedirectToAction("Index","Home",baseviewmodel);
                }else{
                    return View("Senha nao bate");
                }


            }else
            {
                return View("Usuario nao existe");
            }


        }
        
    }
}