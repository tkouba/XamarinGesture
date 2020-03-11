using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;
using XamarinGesture.WPF;

//[assembly: ExportRenderer(typeof(Label), typeof(GestureLabelRenderer))]
namespace XamarinGesture.WPF
{
    public class GestureLabelRenderer : LabelRenderer
    {
        private static readonly Action EmptyDelegate = delegate { };
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (AutoTrack)
            {
                if (Tracker != null)
                    Tracker.Dispose();
                Tracker = new WPFVisualElementTracker<Label, FrameworkElement> { Element = Element, Control = Control };
            }
        }

    }
}

