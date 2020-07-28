using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ProyectoWeb2V2.Models;
using System.Net.Http;
using Newtonsoft.Json;
namespace ProyectoWeb2V2.Controllers
{
    public class ConductorController : Controller
    {
        // GET: Conductor
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Get_Consulta_Dni(string dni)
        {
            HttpClient client = new HttpClient();
            //string dni = "45713875";
            String URL2 = "https://quertium.com/api/v1/reniec/dni/" + dni + "?token=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.MTM3Mw.x-jUgUBcJukD5qZgqvBGbQVMxJFUAIDroZEm4Y9uTyg";
            HttpResponseMessage response = await client.GetAsync(URL2);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                var product = JsonConvert.DeserializeObject<Conductor>(data);
                return Json(product, JsonRequestBehavior.AllowGet);
            }

            return Json("sin Datos", JsonRequestBehavior.AllowGet);

        }


    }
}