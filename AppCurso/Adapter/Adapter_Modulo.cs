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
using static AppCurso1._1.Global;

namespace AppCurso1._1.Adapter
{
    class Adapter_Modulo : BaseAdapter
    {
        Activity contex;
        int contador = 0;
        List<Modulos> list_Modulo;

        public Adapter_Modulo(Activity contex, List<Modulos> list_Modulo)
        {
            this.contex = contex;
            this.list_Modulo = list_Modulo;
        }

        public override int Count => list_Modulo.Count();

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            //elemento devuelto
            var item = list_Modulo[position];

            // definir el formato de la fila
            View view = convertView;

            if (view == null)
                view = contex.LayoutInflater.Inflate(Resource.Layout.layout_Detalle, null);

            //contador++;

            //view.FindViewById<TextView>(Resource.Id.numeros).Text = contador.ToString();
            view.FindViewById<TextView>(Resource.Id.numeros).Text = item.Nombre_Modulo;



            return view;

        }
    }
}