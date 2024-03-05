using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;
namespace ListBoxNew;

public partial class Add: Window
{
    List<Changing> names = new List<Changing>();
    List<Changing> valuest = new List<Changing>();
    public Add()
    {
        InitializeComponent();
    }
    public Add( List<Changing> productsName, List<Changing> values)
    {
        InitializeComponent();
        foreach (Changing strCol in productsName)
        {
            names.Add(strCol);
        }
        foreach (Changing strCol in values)
        {
            valuest.Add(strCol);
        }
    }
    private void Dobavlen(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
       
        names.Add(new Changing()
        {
            NameV = prodName.Text,
            PriceV = priceName.Text,

        });
        new MainWindow(names, valuest).Show();
        Close();
        //animals.ItemsSource = names.ToList();

    }
}