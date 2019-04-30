using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using UdemyCep.Servico;
using UdemyCep.Servico.Modelo;

namespace UdemyCep
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnBuscarCEP_Clicked(object sender, EventArgs e)
        {
            string cep = txtCEP.Text.Trim();
            Endereco end = new Endereco();

            if (isValidCEP(cep))
            {
                try
                {
                    end = ViaCEPServico.BuscarEnderecoViaCEP(cep);
                    if (end == null)
                    {
                        DisplayAlert("ERRO", "O CEP: " + txtCEP.Text + " não foi encontrado!", "OK");
                    }
                    else
                    {
                        lblResultado.Text = String.Format("Endereço: {0}, {1}, {2} - {3}", end.logradouro, end.bairro, end.localidade, end.uf);
                    }
                }
                catch (Exception err)
                {
                    DisplayAlert("ERRO CRÍTICO", "Erro: " + err.Message, "OK");
                    throw;
                }
            }

        }
        private bool isValidCEP(string cep)
        {
            bool valid = true;
            int novoCep = 0;
            string msg = "";

            if (cep.Length != 8)
            {
                msg = "CEP inválido! O CEP deve ter 8 caracteres!";
                valid = false;
            }
            if (!int.TryParse(cep, out novoCep))
            {
                if (msg == "")
                {
                    msg = "CEP inválido! O CEP deve conter apenas números!";
                }
                else
                {
                    msg += " | O CEP deve conter apenas números!";
                }
                valid = false;
            }
            if (!valid)
            {
                DisplayAlert("ERRO", msg, "OK");
            }
            return valid;
        }
    }
}
