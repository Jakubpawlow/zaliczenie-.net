using System;
using System.Linq;
using System.Windows;
using System.Xml.Linq;

namespace Auta
{
    public partial class MainWindow : Window
    {
        private XElement data;

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        // Funkcja wczytująca dane z pliku XML
        private void LoadData()
        {
            data = XElement.Load("data.xml");  // Wczytanie pliku XML
            foreach (var category in data.Elements("Category"))
            {
                CategoryListBox.Items.Add(category.Attribute("Name").Value);
            }
        }

        private void CategoryListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (CategoryListBox.SelectedItem != null)
            {
                var selectedCategory = CategoryListBox.SelectedItem.ToString();
                var categoryWindow = new CategoryWindow(data, selectedCategory);
                categoryWindow.Show();
            }
        }
    }
}
