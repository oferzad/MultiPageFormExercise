using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MultiPageFormExercise
{
    public class Student
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Class { get; set; }
        public int ClassNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public bool LikeMath { get; set; }
        public bool LikeCS { get; set; }
        public Student()
        {
            LikeMath = false;
            LikeCS = false;
            BirthDate = new DateTime(2004, 1, 1);
        }
    }
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Page p = new FirstPageForm();
            p.BindingContext = new Student();
            
            MainPage = new NavigationPage(p);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
