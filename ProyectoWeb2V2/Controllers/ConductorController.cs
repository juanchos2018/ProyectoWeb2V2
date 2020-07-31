using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ProyectoWeb2V2.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;
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
            
            String URL2 = "https://quertium.com/api/v1/reniec/dni/" + dni + "?token=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.MTM3Mw.x-jUgUBcJukD5qZgqvBGbQVMxJFUAIDroZEm4Y9uTyg";
            HttpResponseMessage response = await client.GetAsync(URL2);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                var product = JsonConvert.DeserializeObject<Persona>(data);
                return Json(product, JsonRequestBehavior.AllowGet);
            }

            return Json("sin Datos", JsonRequestBehavior.AllowGet);

        }


        public ActionResult CreateConductor()
        {
            Conductor conductor = new Conductor();
            object status="";
            if (Request.Files.Count > 0)
            {
                try
                {
                    System.IO.FileStream stream;
                    HttpFileCollectionBase files = Request.Files;
                    HttpPostedFileBase file = files[0];

                    conductor.dni_conductor = HttpContext.Request.Params["dni_conductor"];
                    conductor.nombres_conductor = HttpContext.Request.Params["nombres_conductor"];
                    conductor.apellido_conductor = HttpContext.Request.Params["apellido_conductor"];
                    conductor.correo_conductor = HttpContext.Request.Params["correo_conductor"];                    
                    conductor.clave_conductor = HttpContext.Request.Params["clave_conductor"];                    
                    conductor.fecha_creacion = DateTime.Now.ToShortDateString();

                    string fileName = file.FileName;
                    string path = Path.Combine(Server.MapPath("~/Content/Images/"), file.FileName);
                    file.SaveAs(path);
                    stream = new FileStream(Path.Combine(path), FileMode.Open);
                    Directory.CreateDirectory(Server.MapPath("~/uploads/"));
                    Task task = Task.Run(() => conductor.Upload(stream, conductor, file.FileName));
                    task.Wait();
                   status = task.Status;  // 5 task complete..
                    if (task.IsCompleted)
                    {
                        return Json(status, JsonRequestBehavior.AllowGet);
                    }

                }

                catch (Exception e)
                {
                    return Json("error" + e.Message);
                }
            }

            return Json(status, JsonRequestBehavior.AllowGet);
        }

        public JsonResult recuperarDatos(int id)
        {
            ModeloSistemaDataContext db = new ModeloSistemaDataContext();
            var lista = db.CONDUCTOR.Where(p => p.IDCONDUCTOR.Equals(id))
                 .Select(p => new
                 {
                     p.IDCONDUCTOR,
                     p.IDEMPRESA,
                     p.DNI,
                     p.NOMBRES,
                     p.APELLIDOS,
                     p.CORREO,
                     p.CLAVE,
                     FOTOMOSTRAR = Convert.ToBase64String(p.IMAGEN.ToArray())   
                 });
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public JsonResult listaConductor()
        {
            ModeloSistemaDataContext db = new ModeloSistemaDataContext();
            var lista = db.CONDUCTOR
                .Select(p => new { p.IDCONDUCTOR, p.DNI, p.NOMBRES, p.APELLIDOS }).ToList();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public int guardarDatos(CONDUCTOR objconductor, string cadenaFoto)
        {
            ModeloSistemaDataContext db = new ModeloSistemaDataContext();
            int nregistrosafectados = 0;

            try
            {
                //Nuevo
                if (objconductor.IDCONDUCTOR == 0)
                {
                    objconductor.IMAGEN = Convert.FromBase64String(cadenaFoto);
                    db.CONDUCTOR.InsertOnSubmit(objconductor);
                    db.SubmitChanges();
                    nregistrosafectados = 1;
                }

                //Editar
                else
                {
                    CONDUCTOR oconductor = db.CONDUCTOR.Where(p => p.IDCONDUCTOR.Equals(objconductor.IDCONDUCTOR)).First();
                    oconductor.IMAGEN = Convert.FromBase64String(cadenaFoto);
                    db.SubmitChanges();
                    nregistrosafectados = 1;
                }
            }
            catch (Exception ex)
            {
                nregistrosafectados = 0;
            }

            return nregistrosafectados;
        }
    }
}