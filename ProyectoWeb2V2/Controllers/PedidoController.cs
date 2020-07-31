using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoWeb2V2.Controllers
{
    public class PedidoController : Controller
    {
        // GET: Pedido
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult listaPedido()
        {
            ModeloSistemaDataContext db = new ModeloSistemaDataContext();
            var lista = (from p in db.PEDIDO
                         join u in db.USUARIO
                         on p.IDUSUARIO equals u.IDUSUARIO
                         select new
                         {
                             ID = p.IDPEDIDO,
                             NOMBREUSUARIO = u.NOMBRE,
                             CELULAR = u.CELULAR,
                             TOTAL = p.TOTAL,
                             ESTADO = "SIN CONFIRMACIÓN"
                         }).ToList();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}