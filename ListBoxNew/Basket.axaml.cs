using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Xml.Linq;
using Tmds.DBus.Protocol;

namespace ListBoxNew;

public partial class Basket : Window
{
    public int sum = 0;
    List<Changing> namesTwo = new List<Changing>();
    List<Changing> valuesTwo = new List<Changing>();
    List<Changing> kolT = new List<Changing>();
    public int kol = 1;
    public int help;
    Changing chan = new Changing();
    public string KolTwo { get; set; }



    public Basket()
    {
        InitializeComponent();
    }
    public Basket(List<Changing> values, List<Changing> names)
    {
        InitializeComponent();
        foreach (Changing c in values)
        {
            kolT.Add(
                new Changing()
                {
                    NameV = c.NameV,
                    PriceV = c.PriceV,
                    Kol = new TextBlock(),
                    Dob = new Button(),
                    //KolTwo = Convert.ToString(kol),
                });
        }

        foreach (Changing c in kolT)
        {
            c.Kol.HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center;
            c.Kol.Width = 150;
            c.Kol.Height = 30;
            c.Kol.Text = "jkdbsfhds";
            c.Dob.Width = 150;
            c.Dob.Height = 30;
            c.Dob.Content = "Добавить";

        }
        product.ItemsSource = kolT.ToList();
        foreach (Changing strCol in values)
        {
            valuesTwo.Add(strCol);
        }
        foreach (Changing strCol in names)
        {
            namesTwo.Add(strCol);
        }
    }
    public void ClickHandler(object sender, RoutedEventArgs e)
    {
        if (kol == 1)
        {
            sum = 0;
            foreach (Changing c in kolT)
            {
                
                sum = sum + Convert.ToInt32(c.PriceV);
            }

        }
        SumF.Text = Convert.ToString(sum);
    }
    public void Back(object sender, RoutedEventArgs e)
    {

        new MainWindow(namesTwo, valuesTwo).Show();
        Close();
    }
    public void Dobb(object sender, RoutedEventArgs e)
    {
        kol++;
        foreach (Changing c in kolT)
        {
            KolTwo = Convert.ToString(kol);
            c.Kol.Text = KolTwo;
            //chan.Kol.Text = KolTwo;
            //product.ItemsSource = kolT.ToList();

        }

    }

    public void Delete(object sender, RoutedEventArgs e)
    {
        if (product.SelectedItems != null)
        {
            foreach (Changing c in product.SelectedItems)
            {
                kolT.Remove(c);
                valuesTwo.Clear();

            }
            foreach (Changing c in kolT)
            {
                valuesTwo.Add(
                    new Changing()
                    {
                        NameV = c.NameV,
                        PriceV = c.PriceV,
                    }
                    );
            }
            product.ItemsSource = kolT.ToList();
        }

    }
    //SelectedItems(sender, e);
}

                    //KolTwo = Convert.ToString(kol),
                
//public void SelectedItems(object sender, RoutedEventArgs e)
//{
//    sum = 0;
//    if (product.SelectedItems != null)
//    {
//        foreach (Changing strCol in product.SelectedItems)
//        {
//            if (kol >= 1)
//            {
//                kolTwo = Convert.ToString(kol);
//                kolt.Text = kolTwo;
//                help = Convert.ToInt32(strCol.PriceV) * Convert.ToInt32(kolTwo);
//            }             
//            sum = help + sum;

//        }
//    }
//    ClickHandler(sender, e);
//}
