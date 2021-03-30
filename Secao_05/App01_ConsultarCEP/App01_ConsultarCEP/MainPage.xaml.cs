using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCEP.Servico.Modelo;
using App01_ConsultarCEP.Servico;



namespace App01_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            botao.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            //TODO Lógica

            string _cep = cep.Text.Trim();
            Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(_cep);
            resultado.Text = string.Format("Endereço: {0},{1} {2}", end.localidade, end.uf, end.logradouro);

        }
    }
}
