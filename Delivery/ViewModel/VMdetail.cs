using Delivery.Model;
using Delivery.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Delivery.ViewModel
{
    class VMdetail:ViewModelBase
    {
        #region VARIABLES
        string _Texto;
        public Mplatos ParamR { get;set; }
        #endregion
        #region CONSTRUCTOR
        public VMdetail(INavigation navigation, Mplatos paramR)
        {
            Navigation = navigation;
            ParamR = paramR;
        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        private async void Back()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand Backcommand => new Command(Back);
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
