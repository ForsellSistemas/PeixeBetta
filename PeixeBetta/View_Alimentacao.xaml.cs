using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PeixeBetta
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class View_Alimentacao : ContentPage
    {
        public View_Alimentacao()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View_Alimentacao_AlimentosVivos());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View_Alimentacao_Racao());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View_Alimentacao_Jejum());
        }
    }
}