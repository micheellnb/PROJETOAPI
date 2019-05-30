using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProjeto.Models;

namespace WebApiProjeto.Controllers
{
    public class ClientesController : ApiController
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public List<Cliente> get()
        {
            return clientes;
        }

        public void post(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
                clientes.Add(new Cliente(nome));
        }
        public void Delete(string nome)
        {
            clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Nome.Equals(nome))));
        }
    }
}
