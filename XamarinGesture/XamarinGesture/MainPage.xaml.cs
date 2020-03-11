using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinGesture
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int counter = 0;
        public MainPage()
        {
            InitializeComponent();

            var tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += OnTapped;
            contentLabel.GestureRecognizers.Add(tapGesture);

            var panGesture = new PanGestureRecognizer();
            panGesture.PanUpdated += OnPanUpdated;
            contentLabel.GestureRecognizers.Add(panGesture);

            var pinchGesture = new PinchGestureRecognizer();
            pinchGesture.PinchUpdated += OnPinchUpdated;
            contentLabel.GestureRecognizers.Add(pinchGesture);
        }

        void OnTapped(object sender, EventArgs e)
        {
            contentLabel.Text = $"[{counter++}] Tap";
        }

        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            contentLabel.Text = $"[{counter++}] Pan: {e.StatusType} id={e.GestureId} total x={e.TotalX} y={e.TotalY}";
        }

        void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
        {
            contentLabel.Text = $"[{counter++}] Pinch: {e.Status} scale={e.Scale} origin x={e.ScaleOrigin.X} y={e.ScaleOrigin.Y}";
        }
    }
}
