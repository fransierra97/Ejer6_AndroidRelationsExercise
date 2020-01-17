using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Ejer6_AndroidRelations {

    [Activity(Label = "postLogin")]
    public class PostLogin : Activity {
        private TabHost _tabHost;
        TabHost.TabSpec _tabSpec1;
        TabHost.TabSpec _tabSpec2;
        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.post_login);
            AddBindForLayout();
            _tabHost.Setup();

            _tabSpec1 = _tabHost.NewTabSpec("SampleTab1");
            _tabSpec1.SetContent(Resource.Id.tabSampleTab1);
            _tabSpec1.SetIndicator("Registro");

            _tabSpec2 = _tabHost.NewTabSpec("SampleTab2");
            _tabSpec2.SetContent(Resource.Id.tabSampleTab2);
            _tabSpec2.SetIndicator("Listado");


            _tabHost.AddTab(_tabSpec1);
            _tabHost.AddTab(_tabSpec2);
        }

        private void AddBindForLayout() {
            _tabHost = FindViewById<TabHost>(Resource.Id.tabHostSample);
        }
    }
}