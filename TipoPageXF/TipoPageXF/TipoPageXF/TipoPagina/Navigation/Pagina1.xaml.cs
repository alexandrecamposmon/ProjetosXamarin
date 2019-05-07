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
	public partial class Pagina1 : ContentPage
	{
		public Pagina1 ()
		{
			InitializeComponent ();
		}

        private void IrPg2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pagina2());

        }

        private void BtnAbrirModal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pagina3());
        }

        private void BtnAbrirMaster_Clicked(object sender, EventArgs e)
        {
            //System.InvalidOperationException: Master and Detail must be set before adding MasterDetailPage to a container
            App.Current.MainPage = new Master.Master();
            
        }
    }
}