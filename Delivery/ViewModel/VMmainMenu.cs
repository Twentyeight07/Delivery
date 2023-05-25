using Delivery.Data;
using Delivery.Model;
using Delivery.Views.Detail;
using Delivery.VistaModelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Plugin.SharedTransitions;

namespace Delivery.ViewModel
{
    public class VMmainMenu : ViewModelBase
    {
        #region VARIABLES
        ObservableCollection<Mplatos> _listPlatos;
        ObservableCollection<Mcategories> _listCategories;
        #endregion
        #region CONSTRUCTOR
        public VMmainMenu(INavigation navigation)   
        {
            Navigation = navigation;
            ListAllPlatos();
            ListAllCategories();
        }
        #endregion
        #region OBJETOS
        public ObservableCollection<Mcategories> ListCategories
        {
            get { return _listCategories; }
            set { SetValue(ref _listCategories, value); }
        }
        public ObservableCollection<Mplatos> ListPlatos
        {
            get { return _listPlatos; }
            set { SetValue(ref _listPlatos, value); }
        }

        #endregion
        #region PROCESOS
        public void ListAllCategories()
        {
            var funcion = new DCategories();
            ListCategories = funcion.ShowCategories();
        }
        public void SelectCategory(Mcategories param)
        {
            var index = ListCategories
                .ToList()
                .FindIndex(p => p.Category == param.Category);
            if(index > -1)
            {
                DeSelectCategory();
                ListCategories[index].Select = true;
                ListCategories[index].Color1 = "#8664FF";
                ListCategories[index].Color2 = "#BBA8FF";
                ListCategories[index].TextColor = "#FFFFFF";
            }
        }
        private void DeSelectCategory()
        {
            ListCategories.ForEach((item) =>
            {
                item.Select = false;
                item.Color1 = "#FFFFFF";
                item.Color2 = "#FFFFFF";
                item.TextColor = "#2F394B";
            });
        }
        public void ListAllPlatos()
        {
            var funcion = new Dplatos();
            ListPlatos = funcion.ListPlatos();
        }
        private async void SelectPlato(Mplatos param)
        {
            var page = (App.Current.MainPage as SharedTransitionNavigationPage).CurrentPage;
            SharedTransitionNavigationPage.SetTransitionDuration(page, 1000);
            SharedTransitionNavigationPage.SetBackgroundAnimation(page, BackgroundAnimation.SlideFromLeft);
            SharedTransitionNavigationPage.SetTransitionSelectedGroup(page,param.Id);
            await Navigation.PushAsync(new ProductDetail(param));
        }
        
        #endregion
        #region COMANDOS
        public ICommand Selectcommand => new Command<Mcategories>(SelectCategory);
        public ICommand SelectPlatoCommand => new Command<Mplatos>(SelectPlato);
        #endregion
    }
}
