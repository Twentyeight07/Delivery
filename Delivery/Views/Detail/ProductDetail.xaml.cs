using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Model;
using Delivery.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Delivery.Views.Detail
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductDetail : ContentPage
	{
		public ProductDetail (Mplatos param)
		{
			InitializeComponent ();
			BindingContext = new VMdetail(Navigation, param);
		}
	}
}