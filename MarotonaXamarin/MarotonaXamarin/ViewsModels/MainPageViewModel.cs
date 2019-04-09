using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using Prism.Navigation;

namespace MarotonaXamarin.ViewsModels
{
    class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public void OnNavigatedForm(INavigationParameters parameters)
        {

        }
    }
}
