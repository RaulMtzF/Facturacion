using System.Collections.Generic;
using System.Web.Mvc;

namespace Facturacion.Controllers
{
    public class FacturacionController : Controller
    {
        // GET: Facturacion
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GenerarFactura()
        {
            return View();
        }

        public ActionResult AuditarFactura()
        {
            return View();
        }

        public ActionResult Cancelaciones()
        {
            return View();
        }

        public JsonResult GetFacturas()
        {
            List<Model> list = new List<Model>();

            Model model = new Model();
            model.Id = 1; 
            model.Servicio = "Fabrica de software";
            model.Cliente = "OXXO";
            model.RFC = "TEG2387236";
            model.Estatus = "Pendiente";
            model.NumeroFactura = "32154686";
            model.FechaServicio = "01/01/2021";
            model.FechaTimbrado = "01/01/2021";
            model.Enviado = "Pendiente";
            model.FechaEnvio = "10/01/2021";
            model.CorreoEnvio = "oxxo@gmail.com";

            list.Add(model);

            model = new Model();
            model.Id = 2;
            model.Servicio = "Fabrica de software";
            model.Cliente = "FEMSA";
            model.RFC = "TEG2387236";
            model.Estatus = "Pagada";
            model.NumeroFactura = "32154686";
            model.FechaServicio = "01/01/2021";
            model.FechaTimbrado = "01/01/2021";
            model.Enviado = "Enviado";
            model.FechaEnvio = "10/01/2021";
            model.CorreoEnvio = "femsa@gmail.com";

            list.Add(model);

            model = new Model();
            model.Id = 2;
            model.Servicio = "Fabrica de software";
            model.Cliente = "FEMSA";
            model.RFC = "TEG2387236";
            model.Estatus = "Pagada";
            model.NumeroFactura = "32154686";
            model.FechaServicio = "01/01/2021";
            model.FechaTimbrado = "01/01/2021";
            model.Enviado = "Enviado";
            model.FechaEnvio = "10/01/2021";
            model.CorreoEnvio = "femsa@gmail.com";

            list.Add(model);

            model = new Model();
            model.Id = 2;
            model.Servicio = "Fabrica de software";
            model.Cliente = "FEMSA";
            model.RFC = "TEG2387236";
            model.Estatus = "Pagada";
            model.NumeroFactura = "32154686";
            model.FechaServicio = "01/01/2021";
            model.FechaTimbrado = "01/01/2021";
            model.Enviado = "Enviado";
            model.FechaEnvio = "10/01/2021";
            model.CorreoEnvio = "femsa@gmail.com";

            list.Add(model);

            model = new Model();
            model.Id = 2;
            model.Servicio = "Fabrica de software";
            model.Cliente = "FEMSA";
            model.RFC = "TEG2387236";
            model.Estatus = "Pagada";
            model.NumeroFactura = "32154686";
            model.FechaServicio = "01/01/2021";
            model.FechaTimbrado = "01/01/2021";
            model.Enviado = "Enviado";
            model.FechaEnvio = "10/01/2021";
            model.CorreoEnvio = "femsa@gmail.com";

            list.Add(model);

            return Json(new { list });
        }

        public JsonResult InfoFactura()
        {
            Model model = new Model();

            return Json(new { model });
        }

        public JsonResult GetCancelaciones()
        {
            List<Model2> list = new List<Model2>();

            Model2 model = new Model2();
            model.Id = 1;
            model.Cliente = "OXXO";
            model.RFC = "TEG2387236";
            model.Estatus = "Pendiente";
            model.NumeroFactura = "32154686";
            model.FechaCancelacion = "01/01/2021";
            model.MontoFactura = "100,594";
            model.VencimientoAprobacion = "01/01/2021";

            list.Add(model);


            model = new Model2();
            model.Id = 1;
            model.Cliente = "OXXO";
            model.RFC = "TEG2387236";
            model.Estatus = "Pendiente";
            model.NumeroFactura = "32154686";
            model.FechaCancelacion = "01/01/2021";
            model.MontoFactura = "100,594";
            model.VencimientoAprobacion = "01/01/2021";

            list.Add(model);


            model = new Model2();
            model.Id = 1;
            model.Cliente = "OXXO";
            model.RFC = "TEG2387236";
            model.Estatus = "Pendiente";
            model.NumeroFactura = "32154686";
            model.FechaCancelacion = "01/01/2021";
            model.MontoFactura = "100,594";
            model.VencimientoAprobacion = "01/01/2021";

            list.Add(model);


            model = new Model2();
            model.Id = 1;
            model.Cliente = "OXXO";
            model.RFC = "TEG2387236";
            model.Estatus = "Pendiente";
            model.NumeroFactura = "32154686";
            model.FechaCancelacion = "01/01/2021";
            model.MontoFactura = "100,594";
            model.VencimientoAprobacion = "01/01/2021";

            list.Add(model);

            return Json(new { list });
        }

        public JsonResult InfoFacturaCan()
        {
            Model2 model = new Model2();

            return Json(new { model });
        }

        public class Model
        {
            public int Id { get; set; }
            public string Servicio { get; set; }
            public string Cliente { get; set; }
            public string RFC { get; set; }
            public string Estatus { get; set; }
            public string NumeroFactura { get; set; }
            public string FechaServicio { get; set; }
            public string FechaTimbrado { get; set; }
            public string Enviado { get; set; }
            public string FechaEnvio { get; set; }
            public string CorreoEnvio { get; set; }
        }

        public class Model2
        {
            public int Id { get; set; }
            public string Cliente { get; set; }
            public string RFC { get; set; }
            public string Estatus { get; set; }
            public string NumeroFactura { get; set; }
            public string FechaCancelacion { get; set; }
            public string MontoFactura { get; set; }
            public string VencimientoAprobacion { get; set; }
        }
    }
}