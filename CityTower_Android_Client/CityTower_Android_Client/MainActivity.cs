using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Views;

namespace CityTower_Android_Client
{
	[Activity(Label = "@string/app_name", Icon = "@mipmap/icon", Theme = "@style/Theme.AppCompat.Light.DarkActionBar")]
	public class MainActivity : Activity
    {

		protected override void OnCreate(Bundle savedInstanceState)
		{
		    base.OnCreate(savedInstanceState);

		    SetContentView(Resource.Layout.content_main);

		    var textView = FindViewById<TextView>(Resource.Id.textView);
		    var bottomBar = FindViewById<BottomNavigationView>(Resource.Id.bottomNavigationView);
		    textView.Text = "All";
		    bottomBar.NavigationItemSelected += (s, a) => {
		        textView.Text = a.Item.TitleFormatted.ToString();
		    };
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
	}
}

