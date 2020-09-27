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

namespace WPF_Layouts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnStackPanel.Click += WindowButton_Click;
            btnDock.Click += WindowButton_Click;
            btnGrid.Click += WindowButton_Click;
            btnGridSplitter.Click += WindowButton_Click;
        }

        private void WindowButton_Click(object sender, RoutedEventArgs e)
        {
            Button pressedButton = (Button)sender;
            string buttonContent = pressedButton.Content.ToString();

            if(buttonContent.Equals("StackPanel"))
            {
                StackPanel stackPanel = new StackPanel();
                stackPanel.Show();
            }
            else if(buttonContent.Equals("Dock"))
            {
                Dock dock = new Dock();
                dock.Show();
            }
            else if(buttonContent.Equals("Grid"))
            {
                Grid grid = new Grid();
                grid.Show();
            }
            else if(buttonContent.Equals("Grid Splitter"))
            {
                GridSplitter gridSplitter = new GridSplitter();
                gridSplitter.Show();
            }
        }
    }
}
