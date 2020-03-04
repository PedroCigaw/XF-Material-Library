﻿using MaterialMvvmSample.Uwp.Core;
using Xamarin.Forms.Platform.UWP;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MaterialMvvmSample.Uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : WindowsPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            Rg.Plugins.Popup.Popup.Init();
            XF.Material.Uwp.Material.Init();

            var appContainer = new PlatformContainer();
            appContainer.Setup();

            var app = CommonServiceLocator.ServiceLocator.Current.GetInstance<MaterialMvvmSample.App>();
            LoadApplication(app);
        }
    }
}
