﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sergio.Saude.Web.Models;
using Sergio.Saude.Dominio;
using Sergio.Saude.Repositorio;
using Sergio.Saude.Repositorio.Contexto;


namespace Sergio.Saude.Web.Controllers
{
    public class ClienteController : Controller
    {
        SaudeWebDbContexto db = new SaudeWebDbContexto();
        //[Authorize]
        // GET: Cliente
        public ActionResult Index()
        {
            //Dados Db = new Dados();

            
            return View(db.Clientes);
        }
        //private static List<Cliente> ListaCliente()
        //{
        //    List<Cliente> clientes = new List<Cliente>();
        //    clientes.Add(new Cliente { Id = 1, Nome= "Sergio", Cnpj = "06297632000145", Email= "teste@hotmail.com"});
        //    clientes.Add(new Cliente { Id = 2, Nome = "Joao", Cnpj = "06297632000145", Email = "teste@hotmail.com" });
        //    clientes.Add(new Cliente { Id = 3, Nome = "Pedro", Cnpj = "06297632000145", Email = "teste@hotmail.com" });
        //    clientes.Add(new Cliente { Id = 4, Nome = "Maria", Cnpj = "06297632000145", Email = "teste@hotmail.com" });
        //    return clientes;
        //}

        public ActionResult Incluir()
        {
            Cliente cliente = new Cliente();

            return View(cliente);
        }
        [HttpPost]
        public ActionResult Incluir(Cliente clientes)
        {
            try
            {
                Dados db = new Dados();
                db.IncluirCliente(clientes);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
            

            ;
        }
    }
}