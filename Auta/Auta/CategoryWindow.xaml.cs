using System;
using System.Linq;
using System.Windows;
using System.Xml.Linq;

namespace Auta
{
    public partial class CategoryWindow : Window
    {
        private XElement? categoryData;

        public CategoryWindow(XElement data, string categoryName)
        {
            InitializeComponent();
            categoryData = data.Elements("Category").FirstOrDefault(x => x.Attribute("Name").Value == categoryName);
            LoadCategoryDetails();
        }

        private void LoadCategoryDetails()
        {
            if (categoryData != null)
            {
                CategoryDescription.Text = categoryData.Element("Description")?.Value ?? "Brak opisu";
                foreach (var subCategory in categoryData.Elements("SubCategory"))
                {
                    SubCategoryListBox.Items.Add(subCategory.Attribute("Name")?.Value ?? "Nieznana podkategoria");
                }
            }
        }

        private void SubCategoryListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (SubCategoryListBox.SelectedItem != null && categoryData != null)
            {
                var selectedSubCategory = SubCategoryListBox.SelectedItem.ToString();
                var subCategoryWindow = new SubCategoryWindow(categoryData, selectedSubCategory);
                subCategoryWindow.Show();
            }
        }
    }
}
