﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TipoPageXF.TipoPagina.Carousel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TipoPagina3 : ContentPage
	{
		public TipoPagina3 ()
		{
			InitializeComponent ();
		}

        private void BtnMudarPagina_Clicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new NavigationPage(new Navigation.Pagina1());

            App.Current.MainPage = new Tabbed.Abas();
        }
    }
}