using BPNFE.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;
using BPNFE.Dado.Repositorios;
using AutoMapper;
using BPNFE.Dominio.Entidades;

namespace BPNFE.MVC.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly FornecedorRepositorio _fornecedorDiaRepositorio = new FornecedorRepositorio();
        // GET: Fornecedor
        public ActionResult Index(string sortOrder)
        {
            var fornecedorDiaViewModel = Mapper.Map<IEnumerable<Fornecedor>, IEnumerable<FornecedorViewModel>>(_fornecedorDiaRepositorio.BuscarTodos());
            return View(fornecedorDiaViewModel);
        }

        // GET: Fornecedor/Details/5
        public ActionResult Detalhes(int id)
        {
            return View();
        }

        // GET: Fornecedor/Create
        public ActionResult Criar()
        {
            return View();
        }

        // POST: Fornecedor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(FornecedorViewModel fornecedor)
        {
            if (ModelState.IsValid)
            {
                var fornecedorDominio = Mapper.Map<FornecedorViewModel, Fornecedor>(fornecedor);
                _fornecedorDiaRepositorio.Inserir(fornecedorDominio);

                return RedirectToAction("Index");
            }

            return View(fornecedor);
        }

        // GET: Fornecedor/Edit/5
        public ActionResult Editar(int id)
        {
            return View();
        }

        // POST: Fornecedor/Edit/5
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

        // GET: Fornecedor/Delete/5
        public ActionResult Deletar(int id)
        {
            return View();
        }

        // POST: Fornecedor/Delete/5
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