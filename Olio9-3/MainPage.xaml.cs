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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Olio9_3
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

        private void HeightTextBlock_Copy_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void FrameCircuitTextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double height = double.Parse(HeightTextBox.Text);
                double width = double.Parse(WidthTextBox.Text);
                double frame = double.Parse(FrameTextBox.Text);

                WindowTextBox.Text = ((height / 10) * (width / 10)).ToString() + " cm^2";
                GlassTextBox.Text = (((height / 10) - (2 * frame / 10)) * ((width / 10) - (2 * frame / 10))).ToString() + " cm^2";
                FrameCircuitTextBox.Text = (2 * height / 10 + 2 * width / 10).ToString() + " cm";
            }
            catch(FormatException)
            {
                WindowTextBox.Text = "Error!";
                GlassTextBox.Text = "Invalid";
                FrameCircuitTextBox.Text = "Input!";
            }
        }
    }
}
