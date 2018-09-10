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

namespace week7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if(TXTitem.Text !="")
            {
                listbox1.Items.Add(TXTitem.Text);
            }
            else
            {
                MessageBox.Show("please enter a item to add");
            }
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            listbox1.Items.Clear();
        }

        public void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

        private void delS_Click(object sender, RoutedEventArgs e)
        {
            if(listbox1.SelectedIndex >=0)
            {
                listbox1.Items.RemoveAt(listbox1.SelectedIndex);
            }
        }
    }
}
