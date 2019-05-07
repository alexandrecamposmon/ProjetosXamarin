using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TipoPageXF.TipoPagina.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina3 : ContentPage
	{
		public Pagina3 ()
		{
			InitializeComponent ();
		}

        private void BtnFechar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}