using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Windows.Shell;
using System.Windows.Resources;
using System.Windows.Markup;
using System.Windows.Interop;
using System.Windows.Diagnostics;
using System.Windows.Converters;
using System.Windows.Automation;
using NUnit.Compatibility;
using NUnit;
using NUnit.Framework;
using NUnit.Framework.Api;
using NUnit.Framework.Constraints;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Builders;
using NUnit.Framework.Internal.Commands;
using NUnit.Framework.Internal.Execution;
using System.Xaml;
using System.Xaml.Permissions;
using System.Xaml.Schema;
using System.Windows.Xps;
using System.Drawing;
using NuGet;
using NuGet.Frameworks;
using Microsoft.Windows.Input;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ValueTB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initialization
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            
        }

        /// <summary>
        /// Invoke panel visibility by menu item name
        /// </summary>
        /// <param name="sender">Element sender</param>
        /// <param name="e">Routed events arguments</param>
        private void MenuItem_Invoke(object sender, RoutedEventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            TextBlock tb = mi.Header as TextBlock;
            string name = tb.Text;

            Border border = FindName(name) as Border;
            border.Visibility = Visibility.Visible;

            string current = FindResource("ItemPanel").ToString();

            if (name != current)
            {
                (FindName(current) as Border).Visibility = Visibility.Hidden;

                Resources["ItemPanel"] = name;
            }
        }

        /// <summary>
        /// Change style on pointer
        /// </summary>
        /// <param name="sender">Element sender</param>
        /// <param name="e">Routed mouse events arguments</param>
        private void NewProject_Cursore(object sender, MouseEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            tb.Foreground = Brushes.Blue;
        }

        private void NewProject_Cursorl(object sender, MouseEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            tb.Foreground = Brushes.Black;
        }
    }
}
