using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppCurso1._1.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static AppCurso1._1.Global;

namespace AppCurso1._1
{
    [Activity(Label = "Activity_Video")]
    public class Activity_Video : Activity
    {
        ListView listView;
      

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            // Create your application here
            SetContentView(Resource.Layout.layout_Video);
            int id = Intent.GetIntExtra("id_Modulo", 0);
 
            listView = FindViewById<ListView>(Resource.Id.listView1);

           
            //list_departamentos = Global.departamentos.Where(x => x.Id_region == id).ToList();
            listView.Adapter = new Adapter_Video(this, Global.Video.Where(x => x.IdModulo == id ).ToList());
        }
    }
}