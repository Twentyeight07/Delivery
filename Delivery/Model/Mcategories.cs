using Delivery.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Model
{
    public class Mcategories:ViewModelBase
    {
        public string Category { get; set; }
        public string Icon { get; set; }

        // Objects

        string _color1;
        string _color2;
        string _textColor;
        public string Color1
        {
            get { return _color1; }
            set { SetValue(ref _color1,value); }
        }

        public string Color2
        {
            get { return _color2; }
            set { SetValue(ref _color2, value); }
        }

        public string TextColor
        {
            get { return _textColor; }
            set { SetValue(ref _textColor, value); }
        }
    }
}
