using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreGraphics;
using Foundation;
using SpectrumApp.iOS.CustomRenderer;
using UIKit;
using WebKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Entry), typeof(ExtSquareEntryCustomRenderer))]
[assembly: ExportRenderer(typeof(SpectrumApp.Extention.ExtEntry), typeof(ExtEntryCustomRenderer))]

namespace SpectrumApp.iOS.CustomRenderer
{
    public class ExtSquareEntryCustomRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            try
            {
                base.OnElementChanged(e);
                if (Control != null)
                {
                    Control.Layer.BorderWidth = 1;
                    Control.Layer.CornerRadius = 10;
                    Control.Layer.BorderColor = Xamarin.Forms.Color.FromHex("#ffffff").ToCGColor();
                    Control.BorderStyle = UITextBorderStyle.RoundedRect;
                    Control.BackgroundColor = Xamarin.Forms.Color.FromHex("#ffffff").ToUIColor();
                    Control.VerticalAlignment = UIControlContentVerticalAlignment.Center;
                    //Control.LeftView = new UIView(new CGRect(20, 0, 20, 0));
                    Control.LeftView = new UIView(new CGRect(0, 0, 15, 0));
                    Control.LeftViewMode = UITextFieldViewMode.Always;
                    Control.RightView = new UIView(new CGRect(0, 0, 15, 0));
                    Control.RightViewMode = UITextFieldViewMode.Always;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }

    public class ExtEntryCustomRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            try
            {
                base.OnElementChanged(e);
                if (Control != null)
                {
                    Control.BorderStyle = UITextBorderStyle.None;
                    Control.BackgroundColor = Xamarin.Forms.Color.Transparent.ToUIColor();
                    Control.VerticalAlignment = UIControlContentVerticalAlignment.Center;

                    //Control.LeftView = new UIView(new CGRect(20, 0, 20, 0));
                    Control.LeftView = new UIView(new CGRect(0, 0, 10, 0));
                    Control.LeftViewMode = UITextFieldViewMode.Always;
                    Control.RightView = new UIView(new CGRect(0, 0, 10, 0));
                    Control.RightViewMode = UITextFieldViewMode.Always;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
     
}