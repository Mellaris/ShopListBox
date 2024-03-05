using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListBoxNew
{
    public partial class MainWindow : Window
    {
        
        List<Changing> productsName = new List<Changing>();
        List<Changing> values = new List<Changing>();
        List<Changing> editProd = new List<Changing>();


        public MainWindow()
        {
            InitializeComponent();          
           
        }
        public MainWindow(List<Changing> names, List<Changing> valuesTwo)
        {
            InitializeComponent();
            //animals.ItemsSource = productsName.ToList();
            if (valuesTwo != null)
            {
                foreach (Changing changing in valuesTwo)
                {
                    values.Add(changing);
                }
            }
            foreach (Changing changing in names)
            {
                productsName.Add(changing);
            }
            animals.ItemsSource = productsName.ToList();
        }

        private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            new Add(productsName, values).Show();
            Close();
        }
        public void Button(object sender, RoutedEventArgs e)
        {
            if (animals.SelectedItems != null)
            {
                foreach (Changing strCol in animals.SelectedItems)
                {
                    values.Add(strCol);
                }
            }
            new Basket(values, productsName).Show();
            Close();
        }
        public void Edit(object? sender, RoutedEventArgs e)
        {
            if (animals.SelectedItems != null)
            {
                foreach (Changing chg in animals.SelectedItems)
                {
                    editProd.Add(chg);
                }
            }
            new Edit(editProd, productsName, values).Show();
            Close();
        }
    }
}