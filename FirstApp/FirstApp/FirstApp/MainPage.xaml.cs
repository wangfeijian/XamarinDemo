using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int Count = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            Count++;
            ((Button)sender).Text = $"You clicked {Count} times.";
        }

    }
}
