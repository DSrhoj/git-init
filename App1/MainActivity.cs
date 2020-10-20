using Android.App;
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
            TextView smrad, smrad2;
            RelativeLayout RL2, RL3;
            EditText ET1, ET2, ET3;
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            ET1 = FindViewById<EditText>(Resource.Id.editText1);
            ET2 = FindViewById<EditText>(Resource.Id.editText2);
            ET3 = FindViewById<EditText>(Resource.Id.editText3);
            smrad = FindViewById<TextView>(Resource.Id.tv);
            smrad2 = FindViewById<TextView>(Resource.Id.tv2);
            smrad2.Visibility = Android.Views.ViewStates.Invisible;
            RL3 = FindViewById<RelativeLayout>(Resource.Id.relativeLayout3);
            RL2 = FindViewById<RelativeLayout>(Resource.Id.relativeLayout2);
            RL3.Visibility = Android.Views.ViewStates.Invisible;
            FindViewById<Button>(Resource.Id.toni).Click += (o, e) =>
            {
                if (smrad.Visibility == Android.Views.ViewStates.Visible)//smrad.Visibility == Android.Views.ViewStates.Invisible
                {
                    //smrad.Visibility = Android.Views.ViewStates.Visible;
                    
                    RL2.Visibility = Android.Views.ViewStates.Invisible;
                    RL3.Visibility = Android.Views.ViewStates.Visible;
                }

                //else
                //{
                //    smrad.Visibility = Android.Views.ViewStates.Invisible;
                //}

            };

            FindViewById<Button>(Resource.Id.toni2).Click += (o, e) =>
            {
                if (string.IsNullOrEmpty(ET1.Text.ToString()) || string.IsNullOrEmpty(ET2.Text.ToString()) || string.IsNullOrEmpty(ET3.Text.ToString()))
                {
                    smrad2.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    smrad2.Visibility = Android.Views.ViewStates.Invisible;
                    RL2.Visibility = Android.Views.ViewStates.Visible;
                    RL3.Visibility = Android.Views.ViewStates.Invisible;
                    smrad.Visibility = Android.Views.ViewStates.Visible;
                    smrad.TextSize = 50; 
                    smrad.Text = "Svejedno smrdi";
                    ET1.Text = "";
                    ET2.Text = "";
                    ET3.Text = "";

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