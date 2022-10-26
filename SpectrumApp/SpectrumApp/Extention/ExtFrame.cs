using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SpectrumApp.Extention
{
    public class ExtFrame : Xamarin.Forms.Frame
    {
        public static new readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(nameof(ExtFrame), typeof(CornerRadius), typeof(ExtFrame));
        public ExtFrame()
        {
            // MK Clearing default values (e.g. on iOS it's 5)
            base.CornerRadius = 0;
        }

        public enum GradientOrientation
        {
            Vertical,
            Horizontal
        }

        public Color StartColor
        {
            get; set;
        }

        public Color EndColor
        {
            get; set;
        }

        public GradientOrientation GradientColorOrientation
        {
            get; set;
        }

        public new CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }
    }
}
