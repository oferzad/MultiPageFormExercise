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
    public partial class FirstPageForm : ContentPage
    {
        public FirstPageForm()
        {
            InitializeComponent();
        }

        private async void NextPage_Clicked(object sender, EventArgs e)
        {
            Page p = new SecondPageForm();
            p.BindingContext = this.BindingContext;
            await Navigation.PushAsync(p);
        }
    }
}