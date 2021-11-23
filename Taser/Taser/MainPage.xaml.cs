using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Taser
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            // Turn On
            Flashlight.TurnOnAsync();
            var duration = TimeSpan.FromSeconds(99);
            Vibration.Vibrate(duration);

        }
        private void Button_Released(object sender, EventArgs e)
        {
            // Turn Off
            Vibration.Cancel();
            Flashlight.TurnOffAsync();

        }
    }
}
