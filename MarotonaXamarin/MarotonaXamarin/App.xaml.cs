
using System;
using Prism;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace MarotonaXamarin
{
    public partial class App
    {
        public App() : this(null) { }
        public App(IPlatformInitializer platformInitializer) : base(platformInitializer)
        {
        }
        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry conteinerRegistry)
        {
            conteinerRegistry.RegisterForNavigation<NavigationPage>();
            conteinerRegistry.RegisterForNavigation<Views.MainPage>();
        }

        //protected override void OnStart()
        //{
        //    // Handle when your app starts
        //}

        //protected override void OnSleep()
        //{
        //    // Handle when your app sleeps
        //}

        //protected override void OnResume()
        //{
        //    // Handle when your app resumes
        //}
    }
}
