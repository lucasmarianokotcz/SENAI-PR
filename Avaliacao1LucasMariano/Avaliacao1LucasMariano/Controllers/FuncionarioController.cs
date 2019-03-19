using Avaliacao1LucasMariano.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avaliacao1LucasMariano.Controllers
{
    public class FuncionarioController : Controller
    {
        private static List<Funcionario> funcionarios = new Funcionario().ListaFuncionarios();

        // GET: Funcionario
        public ActionResult Index(string pesquisa, string filtro)
        {
            // DropDownList.    
            string[] opcoes = new string[] { "", "Nome", "Setor", "Salário", "Data de admissão", "Número de filhos" };
            SelectList list = new SelectList(opcoes);
            ViewBag.Filtro = list;

            // DropDownList OrderBy.
            var funcionariosOrdenar = funcionarios;
            switch (filtro)
            {
                case "Nome":
                    funcionariosOrdenar = funcionarios.OrderBy(f => f.Nome).ToList();
                    return View(funcionariosOrdenar);
                case "Setor":
                    funcionariosOrdenar = funcionarios.OrderBy(f => f.Setor).ToList();
                    return View(funcionariosOrdenar);
                case "Salário":
                    funcionariosOrdenar = funcionarios.OrderBy(f => f.Salario).ToList();
                    return View(funcionariosOrdenar);
                case "Data de admissão":
                    funcionariosOrdenar = funcionarios.OrderBy(f => f.DataAdmissao).ToList();
                    return View(funcionariosOrdenar);
                case "Número de filhos":
                    funcionariosOrdenar = funcionarios.OrderBy(f => f.Filhos).ToList();
                    return View(funcionariosOrdenar);
                default:
                    break;
            }

            // Search.
            var funcionariosFiltro = funcionarios;
            if (!string.IsNullOrEmpty(pesquisa))
            {
                funcionariosFiltro = funcionarios.Where(f => f.Nome.Contains(pesquisa)).ToList() ;
            }
            return View(funcionariosFiltro);
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create - Adiciona novo funcionário
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                funcionario.IdFunc = funcionarios.Select(f => f.IdFunc).Max() + 1;
                funcionarios.Add(funcionario);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            return View(funcionarios.Where(f => f.IdFunc == id).First());
        }

        // GET: Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            return View(funcionarios.Where(f => f.IdFunc == id).First());
        }

        // POST: Edit - Edita um funcionário
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                funcionarios[funcionarios.IndexOf(funcionarios.Where(f => f.IdFunc == funcionario.IdFunc).First())] = funcionario;
                return RedirectToAction("Index", funcionarios);
            }
            return View();
        }

        // GET: Delete
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");               
            }
            return View(funcionarios.Where(f => f.IdFunc == id).First());
        }

        // POST: Delete - Exclui um funcionário
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Funcionario funcionario)
        {
            funcionarios.Remove(funcionarios.Where(f => f.IdFunc == funcionario.IdFunc).First());
            return RedirectToAction("Index");
        }
    }
}