using System;

using Xamarin.Forms;

namespace TipSplitter
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			var numeroDePersonasEntry = 
				new Entry {
					Text = "0"
			};
			var totalDeLaComidaEntry = 
				new Entry {
				Text = "0"
			};
			var porcentajeDePropinaEntry = 
				new Entry {
				Text = "0"
			};
			var button = new Button {
				Text = "Calcular propina indv.",
			};
				
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Numero de personas"
						},
						numeroDePersonasEntry,
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Total de la comida"
						},
						totalDeLaComidaEntry,
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Porcentaje de propina"
						},
						porcentajeDePropinaEntry,
						button
					}
				}
			};


			button.Clicked +=   delegate(object sender, EventArgs e) {
				try
				{
					int numeroDePersonas =  Int32.Parse( numeroDePersonasEntry.Text ) ;
					float totalDeLaComida = float.Parse( totalDeLaComidaEntry.Text );
					float porcentajeDePropina = float.Parse( porcentajeDePropinaEntry.Text );
					float propinaPorPersona = ( totalDeLaComida / (float)numeroDePersonas ) * porcentajeDePropina;
					MainPage.DisplayAlert ("Calculado", "Propina por persona:" + propinaPorPersona , "OK");
				}
				catch(Exception exception)
				{

				}
			};
		}


		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

