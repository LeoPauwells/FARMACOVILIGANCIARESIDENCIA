using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.AspNetCore.Mvc;

using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

using Newtonsoft.Json;
using FARMACOVILIGANCIARESIDENCIA.Models;

namespace FARMACOVILIGANCIARESIDENCIA.Controllers
{
    public class MantenedorController : Controller
    {
        IFirebaseClient cliente;
            public MantenedorController() 
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "jWdQrP0H3sCGA1qaKOzHdXgKgoCtAmtwZS26J3qZ",
                BasePath = "https://sistemafarmacovigilancia-default-rtdb.firebaseio.com/"

            };
            cliente = new FirebaseClient(config);
        }
        public IActionResult Inicio()
        {
            return View();
        }
        public IActionResult Crear()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Eliminar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Crear(Contacto oContacto)
        {
            string IdGenerado = Guid.NewGuid().ToString("N");
            SetResponse response = cliente.Set("contactos/" + IdGenerado, oContacto);

            if (response.StatusCode == System.Net.HttpStatusCode.OK) 
            {
                return View();
            }
            else 
            { 
            return View();
            }
        }

    }
}
