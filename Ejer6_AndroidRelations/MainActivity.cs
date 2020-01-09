using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using AlertDialog = Android.App.AlertDialog;

namespace Ejer6_AndroidRelations
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button _btnCero;
        private Button _btnUno;
        private Button _btnDos;
        private Button _btnTres;
        private Button _btnCuatro;
        private Button _btnCinco;
        private Button _btnSeis;
        private Button _btnSiete;
        private Button _btnOcho;
        private Button _btnNueve;
        private Button _btnDiez;

        private EditText _entradaTexto;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;
            AddBindForLayout();
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }

        private void EscribirTexto(object sender, EventArgs e) {
            var boton = (Button)sender;
            if (_entradaTexto.Text.Length != 3 ) {
                _entradaTexto.Text = _entradaTexto.Text + boton.Text;
            } else {
                _entradaTexto.Text = _entradaTexto.Text + boton.Text;
                if (_entradaTexto.Text.ToString() == "1234") {
                    AlertDialog.Builder alert = new AlertDialog.Builder(this);
                    alert.SetTitle("Correcto");
                    alert.SetMessage("Clave correcta");
                    alert.Show();
                    _entradaTexto.Text = "";
                } else {
                    AlertDialog.Builder alert = new AlertDialog.Builder(this);
                    alert.SetTitle("Error");
                    alert.SetMessage("Clave incorrecta");
                    alert.Show();
                    _entradaTexto.Text = "";
                }
            }
        }
        private void AddBindForLayout() {
            _btnCero = FindViewById<Button>(Resource.Id.btnCero);
            _btnUno = FindViewById<Button>(Resource.Id.btnUno);
            _btnDos = FindViewById<Button>(Resource.Id.btnDos);
            _btnTres = FindViewById<Button>(Resource.Id.btnTres);
            _btnCuatro = FindViewById<Button>(Resource.Id.btnCuatro);
            _btnCinco = FindViewById<Button>(Resource.Id.btnCinco);
            _btnSeis = FindViewById<Button>(Resource.Id.btnSeis);
            _btnSiete = FindViewById<Button>(Resource.Id.btnSiete);
            _btnOcho = FindViewById<Button>(Resource.Id.btnOcho);
            _btnNueve = FindViewById<Button>(Resource.Id.btnNueve);

            _entradaTexto = FindViewById<EditText>(Resource.Id.entradaTexto);

            _btnCero.Click += EscribirTexto;
            _btnUno.Click += EscribirTexto;
            _btnDos.Click += EscribirTexto;
            _btnTres.Click += EscribirTexto;
            _btnCuatro.Click += EscribirTexto;
            _btnCinco.Click += EscribirTexto;
            _btnSeis.Click += EscribirTexto;
            _btnSiete.Click += EscribirTexto;
            _btnOcho.Click += EscribirTexto;
            _btnNueve.Click += EscribirTexto;
        }
    }
}

