﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            InitializeComponent();
        }

        private void MudarParaPagina2(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Pagina2());

        }

        private void ChamarModal(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Modal());

        }

        private void ChamarMaster(object sender, EventArgs args)
        {
            //Utilizado para: MasterDetail, TabbedPage e CarrolselPage
            App.Current.MainPage = new Master.Master();    

        }
    }
}