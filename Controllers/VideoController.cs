using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.SqlClient;
using System.Data;
using MVCPlantilla.Utilerias;

namespace MvcPlantilla.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            //vieewdata diccionario de datos, ["nombre"] 
            //<% %> se utiliza para poder escribir como c# en html
            //consultar la informacion en la base de datos
            //: se utiliza despues del <% para que s emuestre 

            //base da datos
            /*create table video
(idVideo int primary key,
titulo varchar (20),
numReproducciones int,
url varchar(100)
)

insert into video
values(1,'Video prueba', 20, 'youtube.com/watch/1');
insert into video
values(2,'Video prueba', 2000, 'youtube.com/watch/2');
insert into video
values(3,'Teeth', 100000, 'https://www.youtube.com/embed/JWeJHN5P-E8');

select * from video*/
            ViewData["video"] = BaseHelper.ejecutarConsulta("Select * from video", CommandType.Text);

            return View();

            return View();
        }
        public ActionResult Agregar()
        {

            return View();
        }
        //muestra la interfaz del formulario
        /*public ActionResult Agregar()
        {

            return View();
        }*/
        //POST procesa los datos ingresados al formulario
        [HttpPost]
        public ActionResult Agregar(int idvideo,
                                   string titulo,
                                   string reproducciones,
                                   string url)
        {
            //GUARDAR EN SQL
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idvideo", idvideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@reproducciones", reproducciones));
            parametros.Add(new SqlParameter("@url", url));


            BaseHelper.ejecutarSentencia("INSERT INTO VIDEO" + " VALUES(@idvideo,@titulo,@reproducciones,@url)", CommandType.Text, parametros);



            return View("MensajeAgregar");
        }
        public ActionResult Eliminar()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Eliminar(int idvideo)
        {
            //GUARDAR EN SQL
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idvideo", idvideo));



            BaseHelper.ejecutarSentencia("DELETE FROM VIDEO WHERE idvideo = @idvideo", CommandType.Text, parametros);



            return View("MensajeEliminar");
        }

        public ActionResult Modificar()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Modificar(int idvideo,
                                   string titulo,
                                   string reproducciones,
                                   string url)
        {
            //GUARDAR EN SQL
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idvideo", idvideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@reproducciones", reproducciones));
            parametros.Add(new SqlParameter("@url", url));


            BaseHelper.ejecutarSentencia("UPDATE VIDEO SET idvideo = @idvideo,Titulo = @titulo,reproducciones = @reproducciones, url = @url WHERE idvideo = @idvideo", CommandType.Text, parametros);



            return View("MensajeModificar");
        }
    }
}
