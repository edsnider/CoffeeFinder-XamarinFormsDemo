using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin;
using Xamarin.Forms.Platform.Android;

namespace CoffeeFinder.Droid
{
    [Activity(Label = "CoffeeFinder_Forms", MainLauncher = true)]
    public class MainActivity : AndroidActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Xamarin.Forms.Forms.Init(this, bundle);
            FormsMaps.Init(this, bundle);

            SetPage(App.GetMainPage());
        }
    }
}

