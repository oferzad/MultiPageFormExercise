using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MultiPageFormExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPageForm : ContentPage
    {
        public SecondPageForm()
        {
            InitializeComponent();
        }

        private async void Summary_Clicked(object sender, EventArgs e)
        {
            Page p = new SummaryPage();
            p.BindingContext = this.BindingContext;
            await Navigation.PushAsync(p);
        }
    }
}