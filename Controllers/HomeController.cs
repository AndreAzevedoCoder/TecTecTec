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
    public class HomeController : AbstractController
    {
        PostRepository postRepository = new PostRepository();
        public IActionResult Index()
        {

            ClienteViewModel clienteviewmodel = new ClienteViewModel();
            clienteviewmodel.PostsDeTodos = postRepository.ObterTodosOsPosts();
            clienteviewmodel.UsuarioLogado = ObterUsuarioSession();
            return View(clienteviewmodel);

        }
        public IActionResult Logar()
        {
            HttpContext.Session.SetString("Usuario","Satva");
            ClienteViewModel clienteviewmodel = new ClienteViewModel();
            clienteviewmodel.PostsDeTodos = postRepository.ObterTodosOsPosts();
            clienteviewmodel.UsuarioLogado = ObterUsuarioSession();
            
            return View(clienteviewmodel);
        }

    }
}
