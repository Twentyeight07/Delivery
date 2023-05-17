using Delivery.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Delivery.Data
{
    public class DCategories
    {
        public ObservableCollection<Mcategories> ShowCategories()
        {
            return new ObservableCollection<Mcategories>()
            {
                new Mcategories()
                {
                    Category="Burger",
                    Icon="https://i.ibb.co/g4tytBc/hamburger.png",
                    TextColor="#2F394B",
                    Color1 = "#FFFFFF",
                    Color2 = "#FFFFFF",
                    Select = false,
                },
                new Mcategories()
                {
                    Category="Donut",
                    Icon="https://i.ibb.co/bR97ZsF/donut.png",
                    TextColor="#2F394B",
                    Color1 = "#FFFFFF",
                    Color2 = "#FFFFFF",
                    Select = false,
                },
            };
        }
    }
}
