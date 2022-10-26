using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SpectrumApp.Droid.CustomRenderer;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportRenderer(typeof(Xamarin.Forms.Picker), typeof(PickerCustomRenderer))]

namespace SpectrumApp.Droid.CustomRenderer
{
    public class PickerCustomRenderer : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Picker> e)
        {
            base.OnElementChanged(e);
            GradientDrawable gd = new GradientDrawable();
            gd.SetCornerRadius(15);
            gd.SetStroke(1, Android.Graphics.Color.ParseColor("#ffffff"));
            gd.SetColor(Android.Graphics.Color.ParseColor("#ffffff"));
            this.Control.Background = gd;
            this.Control.Gravity = Android.Views.GravityFlags.CenterVertical;
            this.Control.SetPadding(50, 0, 50, 0);
        }
    }
}