using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCurso1._1
{
    class Global
    {

        public static List<Modulos> Modulo = new List<Modulos>()
        {
            new Modulos(1,"Conceptos Básicos de las Bases de Datos"),
            new Modulos(2,"Acciones sobre una Base de Datos"),
            new Modulos(3,"Manejo de Tablas Dinámicas"),
            new Modulos(4,"Acciones sobre una Base de Datos")
        };

        public static List<Videos> Video = new List<Videos>()
        {
            new Videos(1,"Conceptos básicos de Bases de Datos en Excel | Gestión de la Información #1 ","https://goo.gl/Rof9Yf",1),
            new Videos(2,"Ejemplos de Bases de Datos en Excel | Gestión de la Información #2","https://goo.gl/iUF2rL",1),
            new Videos(3,"Diversos ejemplos de Bases de Datos en Excel | Gestión de la Información #3","https://goo.gl/baXcJW",1),
            new Videos(4,"¿Que es una Tabla Resumen en Excel y que es una Base de Datos? | Gestión de la Información #4","https://goo.gl/hj8vYo",1)
        };

        public static List<Datos> Dato = new List<Datos>()
        {
            new Datos(1,"No usa una base de datos como ejemplo","N/A",1),
            new Datos(2,"No 1 EJEMPLO BD","https://www.poli.edu.co/sites/default/files/basesdatos/No-1-EJEMPLO-BD.XLS",2),
            new Datos(3,"EJEMPLO_BANCOS","https://www.poli.edu.co/sites/default/files/basesdatos/EJEMPLO_BANCOS.XLSX",3),
            new Datos(4,"No 3 NO BD","https://www.poli.edu.co/sites/default/files/basesdatos/No-3-NO-BD.XLS",4)
        };
            

        public class Modulos
        {
            //Definir campos
            int idModulo;
            string nombre_Modulo;

            public Modulos(int idModulo, string nombre_Modulo)
            {
                this.IdModulo = idModulo;
                this.Nombre_Modulo = nombre_Modulo;
            }

            public int IdModulo { get => idModulo; set => idModulo = value; }
            public string Nombre_Modulo { get => nombre_Modulo; set => nombre_Modulo = value; }
        }
        public class Videos
        {
            int idVideo;
            string nombre_Video;
            string url_Video;
            int idModulo;

            public Videos(int idVideo, string nombre_Video, string url_Video, int idModulo)
            {
                this.IdVideo = idVideo;
                this.Nombre_Video = nombre_Video;
                this.Url_Video = url_Video;
                this.IdModulo = idModulo;
            }

            public int IdVideo { get => idVideo; set => idVideo = value; }
            public string Nombre_Video { get => nombre_Video; set => nombre_Video = value; }
            public string Url_Video { get => url_Video; set => url_Video = value; }
            public int IdModulo { get => idModulo; set => idModulo = value; }
        }

        public class Datos
        {
            int idDato;
            string nombre_Datos;
            string url_Datos;
            int idVideo;

            public Datos(int idDato, string nombre_Datos, string url_Datos, int idVideo)
            {
                this.IdDato = idDato;
                this.Nombre_Datos = nombre_Datos;
                this.Url_Datos = url_Datos;
                this.IdVideo = idVideo;
            }

            public int IdDato { get => idDato; set => idDato = value; }
            public string Nombre_Datos { get => nombre_Datos; set => nombre_Datos = value; }
            public string Url_Datos { get => url_Datos; set => url_Datos = value; }
            public int IdVideo { get => idVideo; set => idVideo = value; }
        }

    }
}
