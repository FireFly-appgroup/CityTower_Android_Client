using System;
using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Widget;
using CityTower_Android_Client;
using GameGuild_Android_Client.API;

namespace GameGuild_Android_Client
{
    [Activity(Theme = "@style/MyTheme.Login", MainLauncher = true, NoHistory = true, Icon = "@mipmap/ic_launcher")]
    public class RegistrationActivity : Activity
    {
        EditText email;
        EditText password;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Registration_Page);

            email = FindViewById<EditText>(Resource.Id.txtEmail);
            password = FindViewById<EditText>(Resource.Id.txtPassword);

            var button = FindViewById<FloatingActionButton>(Resource.Id.btnLogin);
            button.Click += DoLogin;
        }

        public async void DoLogin(object sender, EventArgs e)
        {
            await GG_News_API.GetMiniNews();
            if (email.Text == "peet_17@gmail.com" && password.Text == "12345")
            {
                Toast.MakeText(this, "Login successfully done!", ToastLength.Long).Show();
                StartActivity(typeof(MainActivity));
            }
            else
            {
                Toast.MakeText(this, "Wrong credentials found!", ToastLength.Long).Show();
            }
        }
    }
}