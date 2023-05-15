using Delivery.Data;
using Delivery.Model;
using Delivery.VistaModelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Delivery.ViewModel
{
    public class VMmainMenu : ViewModelBase
    {
        #region VARIABLES
        ObservableCollection<Mplatos> _listPlatos;
        #endregion
        #region CONSTRUCTOR
        public VMmainMenu(INavigation navigation)   
        {
            Navigation = navigation;
            ListAllPlatos();
        }
        #endregion
        #region OBJETOS
        public ObservableCollection<Mplatos> ListPlatos
        {
            get { return _listPlatos; }
            set { SetValue(ref _listPlatos, value); }
        }
        #endregion
        #region PROCESOS
        public void ListAllPlatos()
        {
            var funcion = new Dplatos();
            ListPlatos = funcion.ListPlatos();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
