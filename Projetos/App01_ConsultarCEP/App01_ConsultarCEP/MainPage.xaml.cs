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
            
            if(isValidCEP(_cep)) 
            {
                try
                {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(_cep);
                    if (end != null)
                    {
                        resultado.Text = string.Format("Endereço: {0}, {1} - {2}-{3} ", end.logradouro, end.bairro, end.localidade, end.uf);
                    }
                    else
                    {
                        DisplayAlert("ERRO", "O Endereço não foi encontrado para o CEP informado: " + _cep, "OK");
                    }

                }
                catch (Exception ex)
                {
                    DisplayAlert("ERRO OCORRIDO", ex.Message, "OK");

                }

            }

        }

        private bool isValidCEP(string _cep)
        {
            bool valido = true;

            if (_cep.Length != 8)
            {
                //ERRO
                DisplayAlert("ERRO", "CEP inválido! O CEP deve conter 8 caracteres", "OK");
                valido = false;
            }

            int novoCEP = 0;
            if(!int.TryParse(_cep, out novoCEP))
            {
                //ERRO
                DisplayAlert("ERRO", "CEP inválido! O CEP deve ser composto apenas com números", "OK");
                valido = false;
            }

            return valido;    
        }
    }
}
