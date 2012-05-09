using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace GridSquareInterface
{
	public partial class MainPage : UserControl
	{
        private bool inNormalState = true;

		public MainPage()
		{
			// Required to initialize variables
			InitializeComponent();
		}

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            MainMsg.Text = "Video ended. Playing video again...";
            MediaElement video = (MediaElement)sender;
            video.Position = TimeSpan.Zero;
            video.Play();

            if (inNormalState)
            {
                VisualStateManager.GoToState(this, "One", true);
                inNormalState = false;
            }
            else
            {
                VisualStateManager.GoToState(this, "Normal", true);
                inNormalState = true;
            }
        }
	}
}