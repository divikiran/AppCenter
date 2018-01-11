using System;
using AppCenterBuildId.iOS;
using Foundation;


[assembly: Xamarin.Forms.Dependency(typeof(AppSettingsIOS))]
namespace AppCenterBuildId.iOS
{
    public class AppSettingsIOS : IAppSettings
    {
        public string AppVersion { get; } = NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleShortVersionString").ToString();
        public double AppBuildId { get; } = double.Parse(NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleVersion").ToString());
    }
}
