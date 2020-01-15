using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Week2Lab
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {


            InitializeComponent();
            if (Device.OS == TargetPlatform.iOS)
            {

                Padding = new Thickness(0, 90, 0, 0);
            }

        }

        //void Handle_ValueChanged(object sender, ValueChangedEventArgs e) {
        //    label.Text = String.Format("Value is {0:F2}", e.NewValue);
                
        //}

    }
}
