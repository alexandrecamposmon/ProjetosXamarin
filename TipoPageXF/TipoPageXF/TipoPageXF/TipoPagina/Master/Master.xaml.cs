using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TipoPageXF.TipoPagina.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void Btn01_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Navigation.Pagina1());
        }

        private void Btn02_Clicked(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new Navigation.Pagina2());
        }

        private void Btn03_Clicked(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new Conteudo());
        }
    }
}