using Avalonia.Controls;
using Avalonia.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListBoxNew
{ 
    public class Changing
    {
        //public string Name { get; set; }
        //public string Price { get; set; }
        public string NameV { get; set; }
        public string PriceV { get; set; }
        public TextBlock Kol { get; set; }
        public Button Dob { get; set; }
   
    }
    public static class Shop
    {
        public static List<Changing> shop = new List<Changing>();
    }
}

    //< Button Background = "Lavender" Click = "Dob" >

    //                            < TextBlock HorizontalAlignment = "Center" Foreground = "Blue" >
    //                                Добавить
    //                            </ TextBlock >

    //                        </ Button >

    //                        < TextBlock  Text = "{Binding Kol}" Background = "Lavender" Grid.Column = "1" Width = "30" Height = "30" />
