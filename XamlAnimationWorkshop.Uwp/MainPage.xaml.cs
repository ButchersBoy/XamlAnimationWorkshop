using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace XamlAnimationWorkshop.Uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void CountdownStoryboardA_Completed(Object sender, Object e)
        {
            TextBlock.RenderTransformOrigin = new Point(.5, .5);
        }

        private void CountdownStoryboardB_Completed(Object sender, Object e)
        {
            TextBlock.RenderTransformOrigin = new Point(.5, 1);
            
            this.CountdownStoryboardA.Begin();
            this.CountdownStoryboardB.Begin();
        }

        private void Page_Loaded(Object sender, RoutedEventArgs e)
        {
            this.CountdownStoryboardA.Begin();
            this.CountdownStoryboardB.Begin();
        }
    }
}
