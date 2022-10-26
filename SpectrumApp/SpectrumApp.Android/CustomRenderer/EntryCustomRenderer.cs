using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Widget;
using SpectrumApp.Droid.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportRenderer(typeof(Entry), typeof(ExtSquareEntryCustomRenderer))]
[assembly: Xamarin.Forms.ExportRenderer(typeof(SpectrumApp.Extention.ExtEntry), typeof(EntryCustomRenderer))]

namespace SpectrumApp.Droid.CustomRenderer
{
#pragma warning disable CS0618 // Type or member is obsolete

    public class ExtSquareEntryCustomRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
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

    public class EntryCustomRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            GradientDrawable gd = new GradientDrawable();
            gd.SetCornerRadius(0);
            //gd.SetStroke(2, Android.Graphics.Color.ParseColor("#000000"));
            gd.SetColor(Android.Graphics.Color.Transparent);
            this.Control.Background = gd;
            this.Control.Gravity = Android.Views.GravityFlags.CenterVertical;
            this.Control.SetPadding(30, 0, 30, 0);
        }
    }

    public class ExtEntryCustomRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            GradientDrawable gd = new GradientDrawable();
            gd.SetCornerRadius(0);
            gd.SetColor(Android.Graphics.Color.Transparent);
            this.Control.Background = gd;
            this.Control.Gravity = Android.Views.GravityFlags.CenterVertical;
            this.Control.SetPadding(40, 0, 40, 0);
        }
    }



#pragma warning restore CS0618 // Type or member is obsolete
}