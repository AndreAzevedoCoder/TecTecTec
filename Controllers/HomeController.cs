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
using System.Text.RegularExpressions;

namespace FeedbackMVC.Controllers
{
    public class HomeController : AbstractController
    {
        PostRepository postRepository = new PostRepository();
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index()
        {

            ClienteViewModel clienteviewmodel = new ClienteViewModel();
            clienteviewmodel.PostsDeTodos = postRepository.ObterTodosOsPosts();
            clienteviewmodel.UsuarioLogado = ObterUsuarioSession();
            clienteviewmodel.PostsDeTodos = clienteviewmodel.PostsDeTodos.OrderByDescending(x => x.DataDaPostagem).ToList();
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


        [HttpPost]
        public IActionResult Postar(IFormCollection form)
        {
            if(form["MensagemDoPost"] != "")
            {
                Post post = new Post();
                Cliente cliente = clienteRepository.ObterPorArroba(ObterUsuarioSession());
                post.DonoDoPost = cliente.UsuarioNome;
                post.DonoDoPostArroba = cliente.UsuarioArroba;
                post.Curtidas = 0;
                post.MensagemDoPost = form["MensagemDoPost"];
                post.MensagemDoPost = Regex.Replace(post.MensagemDoPost, @"\t|\n|\r", "");
                postRepository.Inserir(post);

                ClienteViewModel clienteviewmodel = new ClienteViewModel();
                clienteviewmodel.PostsDeTodos = postRepository.ObterTodosOsPosts();
                clienteviewmodel.UsuarioLogado = ObterUsuarioSession();
                return RedirectToAction("Index","Home");
            }else{
                return RedirectToAction("Index","Home");
            }



        }



    }
}
