using Delivery.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Delivery.Data
{
    public class Dplatos
    {
        public ObservableCollection<Mplatos> ListPlatos()
        {
            return new ObservableCollection<Mplatos>()
            {
                new Mplatos()
                {
                    Description="plato 1",
                    Price="$14",
                    Icon="https://i.ibb.co/DM28Nr3/IMG01.png"
                },
                new Mplatos()
                {
                    Description="plato 2",
                    Price="$9.15",
                    Icon="https://i.ibb.co/TTwcrp3/IMG02.png"
                },
                new Mplatos()
                {
                    Description="plato 3",
                    Price="$22.3",
                    Icon="https://i.ibb.co/PgBDny6/IMG04.png"
                }
            };
        }
    }
}
