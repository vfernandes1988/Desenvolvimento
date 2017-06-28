using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using BPNFE.Dominio.Entidades;
using BPNFE.MVC.ViewModels;
using BPNFE.Dado.Repositorios;

namespace BPNFE.MVC.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly UsuarioRepositorio _usuarioRepositorio = new UsuarioRepositorio();
        // GET: Usuarios
        public ActionResult Index()
        {
            var usuarioViewModel = Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioRepositorio.BuscarTodos());
            return View(usuarioViewModel);
        }

        // GET: Usuarios/Details/5
        public ActionResult Detalhes(int id)
        {
            return View();
        }

        // GET: Usuarios/Create
        public ActionResult Criar()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(UsuarioViewModel usuario)
        {
            if (ModelState.IsValid)
            {
                var usuarioDominio = Mapper.Map<UsuarioViewModel, Usuario>(usuario);
                _usuarioRepositorio.Inserir(usuarioDominio);

                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public ActionResult Editar(int id)
        {
            return View();
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        public ActionResult Editar(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuarios/Delete/5
        public ActionResult Deletar(int id)
        {
            return View();
        }

        // POST: Usuarios/Delete/5
        [HttpPost]
        public ActionResult Deletar(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
