using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace AppCenterBuildId
{
    public class TestViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        string _appBuildId;


        public string AppBuildId
        {
            get => _appBuildId;

            set
            {
                _appBuildId = value;
                RaisePropertyChanged();
            }
        }

        public TestViewModel()
        {
            AppBuildId = "Build ID: " + DependencyService.Get<IAppSettings>().AppBuildId;
        }


    }
}
