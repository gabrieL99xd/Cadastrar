using CadastrarUser.Context;
using CadastrarUser.Models;
using CadastrarUser.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastrarUser.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUserRepository _repository;

        public UsuarioController(IUserRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            var usuarios = _repository.GetAll();

            return View(usuarios);
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            var usuario = _repository.Get(id);
            if(usuario == null)
            {
                return RedirectToAction("Index", "Usuario");
            }
            return View(usuario);
        }

        public ActionResult Detail(int id)
        {
            var usuario = _repository.Get(id);
            if (usuario == null)
            {
                return RedirectToAction("Index", "Usuario");
            }
            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(usuario);
                return RedirectToAction("Index", "Usuario");
            }

            return View("Register", usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(usuario);
                return RedirectToAction("Index", "Usuario");
            }

            return View("Register", usuario);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var usuario = _repository.Get(id);
            _repository.Delete(usuario);
            return RedirectToAction("Index", "Usuario");
        }
    }
}