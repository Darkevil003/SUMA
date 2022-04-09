using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SUMA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SUMA : ContentPage
    {
        public SUMA()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(numero1.Text);
            double r1 = Convert.ToDouble(numero2.Text);
            Double suma = (r + r1);

            
            result.Text = suma.ToString();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            numero1.Text = "";
            numero2.Text = "";
            
            result.Text = "";

        }
    }
}