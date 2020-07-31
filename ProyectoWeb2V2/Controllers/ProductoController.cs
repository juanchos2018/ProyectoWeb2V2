using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoWeb2V2.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registrar()
        {
            return View();
        }

        public JsonResult recuperarDatos(int id)
        {
            ModeloSistemaDataContext db = new ModeloSistemaDataContext();
            var lista = db.PRODUCTO.Where(p => p.IDPRODUCTO.Equals(id))
                 .Select(p => new
                 {
                     p.IDPRODUCTO,
                     p.IDEMPRESA,
                     p.NOMBRE,
                     p.DESCRIPCION,
                     p.PRECIO,
                     FOTOMOSTRAR = Convert.ToBase64String(p.IMAGEN.ToArray())
                 });
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public JsonResult listaProducto()
        {
            ModeloSistemaDataContext db = new ModeloSistemaDataContext();
            var lista = db.PRODUCTO
                .Select(p => new { p.IDPRODUCTO, p.NOMBRE, p.PRECIO }).ToList();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public int guardarDatos(PRODUCTO objproducto, string cadenaFoto)
        {
            ModeloSistemaDataContext db = new ModeloSistemaDataContext();
            int nregistrosafectados = 0;

            try
            {
                //Nuevo
                if (objproducto.IDPRODUCTO == 0)
                {
                    objproducto.IMAGEN = Convert.FromBase64String(cadenaFoto);
                    db.PRODUCTO.InsertOnSubmit(objproducto);
                    db.SubmitChanges();
                    nregistrosafectados = 1;
                }

                //Editar
                else
                {
                    PRODUCTO oproducto = db.PRODUCTO.Where(p => p.IDPRODUCTO.Equals(objproducto.IDPRODUCTO)).First();
                    oproducto.NOMBRE = objproducto.NOMBRE;
                    oproducto.DESCRIPCION = objproducto.DESCRIPCION;
                    oproducto.PRECIO = objproducto.PRECIO;
                    oproducto.IMAGEN = Convert.FromBase64String(cadenaFoto);
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