using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
using System.Linq;

namespace Shop_Shapovalova
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<object> AllItems = Classes.RepoItems.AllItems();
        private List<Classes.RepoItems> currentDisplayList;
        public MainWindow()
        {
            InitializeComponent();

            CreateUI();
            
        }
        public void CreateUI()
        {
            foreach(object Item in AllItems)
            {
                parent.Children.Add(new Elements.Item(Item));
            }
        }

        private void Search(object sender, RoutedEventArgs e)
        {
            string text = text1.Text.ToLower();
            parent.Children.Clear();
            if (string.IsNullOrEmpty(text))
            {
                foreach (object item in AllItems)
                    parent.Children.Add(new Elements.Item(item));
                return;
            }

            foreach (object item in AllItems)
            {
                bool found = false;

                if (item is Classes.Children children)
                {
                    if (children.Age.ToString().ToLower().Contains(text)) found = true;
                }
                if (item is Classes.Sport sport)
                {
                    if (sport.Size.ToLower().Contains(text)) found = true;
                }
                if (item is Classes.Electronic electronic)
                {
                    if (electronic.Accum.ToLower().Contains(text)) found = true;
                    if (electronic.Speed.ToLower().Contains(text)) found = true;
                }

                if (found)
                    parent.Children.Add(new Elements.Item(item));
            }
        }
    }
}
