using Lottie.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LottieTest
{
    public partial class MainPage : ContentPage 
    {
        public bool IsOn { get; set; }
        public MainPage()
        {

            InitializeComponent();
            animationView.PlayAnimation();
        }

    private void Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Animation clicked", "you clicked the anim", "ok");
        }

        private void Finished(object sender, EventArgs e)
        {
            DisplayAlert("Animation finished", "self descriptive", "ok");
        }
    }
}
