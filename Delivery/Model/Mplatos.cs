using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Model
{
    public class Mplatos
    {
        public Mplatos() 
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Description {  get; set; }
        public string Price { get; set; }
        public string Icon { get; set; }
        public string Id { get; set; }
    }
}
