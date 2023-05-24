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
    class Adapter_Video : BaseAdapter
    {
        Activity contex;
        List<Videos> list_Video;

        public Adapter_Video(Activity contex, List<Videos> list_Video)
        {
            this.contex = contex;
            this.list_Video = list_Video;
        }

        public override int Count => list_Video.Count();

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
            var item = list_Video[position];

            // definir el formato de la fila
            View view = convertView;

            if (view == null)
                view = contex.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2, null);

            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Nombre_Video;

            view.FindViewById<TextView>(Android.Resource.Id.Text2).Text = item.Url_Video;

            return view;

        }
    }
}