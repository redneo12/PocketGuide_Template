using System;
using Xamarin.Forms;
using PocketGuide.Android;

using PocketGuide.ViewModels.Base;

[assembly: Dependency(typeof(BaseUrl_Android))]
namespace PocketGuide.Android
{
    public class BaseUrl_Android : IBaseUrl
    {
        public string Get()
        {
            return "file:///android_asset/";
        }
    }
}