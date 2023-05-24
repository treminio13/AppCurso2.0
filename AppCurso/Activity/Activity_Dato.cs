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
    [Activity(Label = "Activity_Dato")]
    public class Activity_Dato : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.layout_Video);
            int id = Intent.GetIntExtra("id_Modulo", 0);

            //listView = FindViewById<ListView>(Resource.Id.listView1);


            //list_departamentos = Global.departamentos.Where(x => x.Id_region == id).ToList();
           // listView.Adapter = new Adapter_Video(this, Global.Video.Where(x => x.IdModulo == id).ToList());
        }
    }
}