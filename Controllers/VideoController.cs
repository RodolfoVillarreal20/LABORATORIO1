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
        public ActionResult Eliminar()
        {

            return View();
        }
        public ActionResult Modificar()
        {

            return View();
        }

    }
}
