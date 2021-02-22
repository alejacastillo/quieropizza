﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.WebAdmin.Controllers
{
    public class CategoriasController : Controller
    {
        CategoriasBL _categoriasBL;

        public CategoriasController()
        {
            _categoriasBL = new CategoriasBL();
        }
        // GET: Productos
        public ActionResult Index()
        {
            var listadeCategorias = _categoriasBL.ObtenerCategoria();

            return View(listadeCategorias);
        }

        [HttpPost]
        public ActionResult Crear(Categorias categoria)
        {
            _categotiasBL.GuardarCategoria(categoria);
            return RedirectToAction("Index");
        }


        public ActionResult Editar(int id)
        {
            var categoria = _categoriasBL.ObtenerCategoria(id);
            return View(categoria);
        }

        [HttpPost]
        public ActionResult Editar(Categorias categoria)
        {
            _categoriasBL.GuardarCategoria(categoria);
            return RedirectToAction("Index");
        }

        public ActionResult Detalle(int id)
        {
            var producto = _categoriaBL.ObtenerCategoria(id);

            return View(categoria);
        }

        public ActionResult Eliminar(int id)
        {
            var categoria = _categoriasBL.ObtenerCategoria(id);
            return View(categoria);
        }
        [HttpPost]
        public ActionResult Eliminar(Categorias categoria)
        {
            return RedirectToAction("Index");
        }
    }
}