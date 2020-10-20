﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TextView smrad;
            RelativeLayout RL2, RL3;
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            
            smrad = FindViewById<TextView>(Resource.Id.tv) ;
            RL3 = FindViewById<RelativeLayout>(Resource.Id.relativeLayout3);
            RL3.Visibility = Android.Views.ViewStates.Invisible;
            FindViewById<Button>(Resource.Id.toni).Click += (o, e) =>
            {
                if (smrad.Visibility == Android.Views.ViewStates.Invisible)
                {
                    //smrad.Visibility = Android.Views.ViewStates.Visible;
                    RL2 = FindViewById<RelativeLayout>(Resource.Id.relativeLayout2);
                    RL2.Visibility = Android.Views.ViewStates.Invisible;
                    RL3.Visibility = Android.Views.ViewStates.Visible;
                }

                else
                {
                    smrad.Visibility = Android.Views.ViewStates.Invisible;
                }

            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}