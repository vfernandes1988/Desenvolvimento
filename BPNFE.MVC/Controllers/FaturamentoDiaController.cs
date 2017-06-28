using System;
using BPNFE.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;
using BPNFE.Dado.Repositorios;
using AutoMapper;
using BPNFE.Dominio.Entidades;

namespace BPNFE.MVC.Controllers
{
    public class FaturamentoDiaController : Controller
    {
        private readonly FaturamentoDiaRepositorio _faturamentoDiaRepositorio = new FaturamentoDiaRepositorio();
        // GET: FaturamentoDia
        public ActionResult Index(string sortOrder)
        {
            var faturamentoDiaViewModel = Mapper.Map<IEnumerable<FaturamentoDia>, IEnumerable<FaturamentoDiaViewModel>>(_faturamentoDiaRepositorio.BuscarTodos());
            return View(faturamentoDiaViewModel);
        }

        // GET: FaturamentoDia/Details/5
        public ActionResult Detalhes(int id)
        {
            return View();
        }

        // GET: FaturamentoDia/Create
        public ActionResult Criar()
        {
            return View();
        }

        // POST: FaturamentoDia/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(FaturamentoDiaViewModel faturamentoDia)
        {
            if (ModelState.IsValid)
            {
                var faturamentoDiaDominio = Mapper.Map<FaturamentoDiaViewModel, FaturamentoDia>(faturamentoDia);
                _faturamentoDiaRepositorio.Inserir(faturamentoDiaDominio);

                return RedirectToAction("Index");
            }

            return View(faturamentoDia);
        }

        // GET: FaturamentoDia/Edit/5
        public ActionResult Editar(int id)
        {
            return View();
        }

        // POST: FaturamentoDia/Edit/5
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

        // GET: FaturamentoDia/Delete/5
        public ActionResult Deletar(int id)
        {
            return View();
        }

        // POST: FaturamentoDia/Delete/5
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