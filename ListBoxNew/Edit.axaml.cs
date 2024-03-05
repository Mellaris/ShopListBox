using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;
namespace ListBoxNew;

public partial class Edit : Window
{
    List<Changing> values = new List<Changing>();
    List<Changing> names = new List<Changing>();
    List<Changing> val = new List<Changing>();
    int help = 0;
    int helpTwo = 0;

    public Edit()
    {
        InitializeComponent();
    }
    public Edit(List<Changing> valuesT, List<Changing> productsName, List<Changing> valuest)
    {
        InitializeComponent();
        foreach (Changing c in valuesT)
        {
            values.Add(c);
        }
        foreach (Changing c in productsName)
        {
            names.Add(c);
        }
        foreach (Changing c in valuest)
        {
            val.Add(c);
        }
    }
    public void EditB(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (values.Count > 0)
        {
            foreach (Changing changing in values)
            {
                foreach (Changing c in val)
                {
                    if (changing.PriceV == c.PriceV && changing.NameV == c.NameV)
                    {
                        helpTwo++;
                    }
                }
            }
        }
        if (helpTwo > 0)
        {
            foreach (Changing changing in names)
            {
                foreach (Changing c in values)
                {
                    if (changing.PriceV == c.PriceV && changing.NameV == c.NameV)
                    {
                        names.Remove(c);
                        names.Add(new Changing()
                        {
                            NameV = prodName.Text,
                            PriceV = priceName.Text,

                        });
                        val.Remove(c);
                        val.Add(new Changing()
                        {
                            NameV = prodName.Text,
                            PriceV = priceName.Text,
                        });
                        help++;
                        break;
                    }
                }
                if (help > 0)
                {
                    break;
                }
            }
        }
        else if (helpTwo == 0)
        {
            foreach (Changing changing in names)
            {
                foreach (Changing c in values)
                {
                    if (changing.PriceV == c.PriceV && changing.NameV == c.NameV)
                    {
                        names.Remove(c);
                        names.Add(new Changing()
                        {
                            NameV = prodName.Text,
                            PriceV = priceName.Text,

                        });
                        help++;
                        break;
                    }
                }
                if (help > 0)
                {
                    break;
                }
            }
        }
        new MainWindow(names, val).Show();
        Close();
    }
}