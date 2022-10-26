using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpectrumApp.Extention;
using SpectrumApp.iOS.CustomRenderer;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: Xamarin.Forms.ExportRenderer(typeof(ExtEditor), typeof(ExtEditorCustomRenderer))]

namespace SpectrumApp.iOS.CustomRenderer
{
    public class ExtEditorCustomRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            try
            {
                base.OnElementChanged(e);
                if (Control != null)
                {
                    Control.Layer.BorderWidth = 1;
                    Control.Layer.CornerRadius = 10;
                    Control.Layer.BorderColor = Xamarin.Forms.Color.FromHex("#ffffff").ToCGColor();
                    Control.BackgroundColor = UIColor.White;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}