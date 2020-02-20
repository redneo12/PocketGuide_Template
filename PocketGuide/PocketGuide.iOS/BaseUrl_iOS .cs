using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.yowcanada.pocketguide;
using Foundation;
using PocketGuide.ViewModels.Base;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl_iOS))]
namespace com.yowcanada.pocketguide
{
    public class BaseUrl_iOS : IBaseUrl
    {
        public string Get()
        {
            return NSBundle.MainBundle.BundlePath;
        }
    }
}