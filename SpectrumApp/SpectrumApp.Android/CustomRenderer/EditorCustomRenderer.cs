using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SpectrumApp.Droid.CustomRenderer;
using SpectrumApp.Extention;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

#pragma warning disable CS0612 // Type or member is obsolete
[assembly: Xamarin.Forms.ExportRenderer(typeof(ExtEditor), typeof(ExtEditorCustomRenderer))]

namespace SpectrumApp.Droid.CustomRenderer
{
    [Obsolete]
    public class ExtEditorCustomRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            GradientDrawable gd = new GradientDrawable();
            gd.SetCornerRadius(15);
            gd.SetStroke(1, Android.Graphics.Color.ParseColor("#ffffff"));
            gd.SetColor(Android.Graphics.Color.ParseColor("#ffffff"));
            this.Control.Background = gd;
            this.Control.Gravity = Android.Views.GravityFlags.Start;
            this.Control.SetPadding(50, 10, 50, 10);
        }
    }
}