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
				Text = "5"
			};
			Stepper numeroDePersonasStepper = new Stepper
			{
				Minimum = 0,
				Maximum = 30,
				Increment = 1,
				Value = 5,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			var set3Button = new Button{ Text = "3" }; 
			set3Button.Clicked += delegate(object sender, EventArgs e) {
				numeroDePersonasEntry.Text = "3";
				numeroDePersonasStepper.Value = 3;
			};
			var set4Button = new Button{ Text = "4" };
			set4Button.Clicked += delegate(object sender, EventArgs e) {
				numeroDePersonasEntry.Text = "4";
				numeroDePersonasStepper.Value = 4;
			};
			var set5Button = new Button{ Text = "5" };
			set5Button.Clicked += delegate(object sender, EventArgs e) {
				numeroDePersonasEntry.Text = "5";
				numeroDePersonasStepper.Value = 5;
			};
			var set6Button = new Button{ Text = "6" };
			set6Button.Clicked += delegate(object sender, EventArgs e) {
				numeroDePersonasEntry.Text = "6";
				numeroDePersonasStepper.Value = 6;
			};
			var set7Button = new Button{ Text = "7" };
			set7Button.Clicked += delegate(object sender, EventArgs e) {
				numeroDePersonasEntry.Text = "7";
				numeroDePersonasStepper.Value = 7;
			};
			var set8Button = new Button{ Text = "8" };
			set8Button.Clicked += delegate(object sender, EventArgs e){
				numeroDePersonasEntry.Text = "8";
				numeroDePersonasStepper.Value = 8;
			};
			numeroDePersonasStepper.ValueChanged += delegate(object sender, ValueChangedEventArgs e) {
				try
				{
					int numeroDePersonas =  Int32.Parse( numeroDePersonasEntry.Text ) ;
					numeroDePersonasEntry.Text = "" + e.NewValue ;
				}
				catch(Exception exception)
				{

				}
			};
			var totalDeLaComidaEntry = 
				new Entry {
				Text = "500"
			};
			var plus500Button = new Button{ Text = "+500" };
			plus500Button.Clicked += delegate(object sender, EventArgs e){
				try
				{
					float totalDeLaComida =  float.Parse( totalDeLaComidaEntry.Text ) ;
					totalDeLaComidaEntry.Text = "" + ( totalDeLaComida + 500f);
				}
				catch( Exception exception )
				{
				}
			};
			var plus300Button = new Button{ Text = "+300" };
			plus300Button.Clicked += delegate(object sender, EventArgs e){
				try
				{
					float totalDeLaComida =  float.Parse( totalDeLaComidaEntry.Text ) ;
					totalDeLaComidaEntry.Text = "" + ( totalDeLaComida + 300f);
				}
				catch( Exception exception )
				{
				}
			};
			var plus100Button = new Button{ Text = "+100" };
			plus100Button.Clicked += delegate(object sender, EventArgs e){
				try
				{
					float totalDeLaComida =  float.Parse( totalDeLaComidaEntry.Text ) ;
					totalDeLaComidaEntry.Text = "" + ( totalDeLaComida + 100f );
				}
				catch( Exception exception )
				{
				}
			};
			var plus50Button = new Button{ Text = "+50" };
			plus50Button.Clicked += delegate(object sender, EventArgs e){
				try
				{
					float totalDeLaComida =  float.Parse( totalDeLaComidaEntry.Text ) ;
					totalDeLaComidaEntry.Text = "" + ( totalDeLaComida + 50f);
				}
				catch( Exception exception )
				{
				}
			};
			var plus30Button = new Button{ Text = "+30" };
			plus30Button.Clicked += delegate(object sender, EventArgs e){
				try
				{
					float totalDeLaComida =  float.Parse( totalDeLaComidaEntry.Text ) ;
					totalDeLaComidaEntry.Text = "" + ( totalDeLaComida + 30f);
				}
				catch( Exception exception )
				{
				}
			};
			var plus10Button = new Button{ Text = "+10" };
			plus10Button.Clicked += delegate(object sender, EventArgs e){
				try
				{
					float totalDeLaComida =  float.Parse( totalDeLaComidaEntry.Text ) ;
					totalDeLaComidaEntry.Text = "" + ( totalDeLaComida + 10f);
				}
				catch( Exception exception )
				{
				}
			};
			var plus5Button = new Button{ Text = "+5" };
			plus5Button.Clicked += delegate(object sender, EventArgs e){
				try
				{
					float totalDeLaComida =  float.Parse( totalDeLaComidaEntry.Text ) ;
					totalDeLaComidaEntry.Text = "" + ( totalDeLaComida + 5f);
				}
				catch( Exception exception )
				{
				}
			};
			var plus3Button = new Button{ Text = "+3" };
			plus3Button.Clicked += delegate(object sender, EventArgs e){
				try
				{
					float totalDeLaComida =  float.Parse( totalDeLaComidaEntry.Text ) ;
					totalDeLaComidaEntry.Text = "" + ( totalDeLaComida + 3f);
				}
				catch( Exception exception )
				{
				}
			};
			var plus1Button = new Button{ Text = "+1" };
			plus1Button.Clicked += delegate(object sender, EventArgs e){
				try
				{
					float totalDeLaComida =  float.Parse( totalDeLaComidaEntry.Text ) ;
					totalDeLaComidaEntry.Text = "" + ( totalDeLaComida + 1f);
				}
				catch( Exception exception )
				{
				}
			};
			var porcentajeDePropinaEntry = 
				new Entry {
				Text = "10"
			};
			var porcentajeDePropinaSlider = 
				new Slider(0,100,10) ;

			porcentajeDePropinaSlider.ValueChanged += delegate(object sender, ValueChangedEventArgs e) {
				porcentajeDePropinaEntry.Text = "" + e.NewValue;
			}; 
			var button = new Button {
				Text = "Calcular propina",
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				FontAttributes = FontAttributes.Bold
			};
				
			MainPage = new ContentPage {
				Content = 
					new ContentView{
					Padding = 40,
						Content = 
						new StackLayout {
						VerticalOptions = LayoutOptions.Center,
						Children = {
							new Label {
								XAlign = TextAlignment.Center,
								Text = "Numero de personas",
								FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
								FontAttributes = FontAttributes.Bold
							},
							new StackLayout {
								Orientation = StackOrientation.Horizontal,
								Padding = 20,
								Children ={
									set3Button,
									set4Button,
									set5Button,
									set6Button,
									set7Button,
									set8Button
								}
							},
							new StackLayout {
								Orientation = StackOrientation.Horizontal,
								Padding = 20,
								Children ={
									numeroDePersonasStepper,

								}
							},
							numeroDePersonasEntry,
							new Label {
								XAlign = TextAlignment.Center,
								Text = "Total de la comida",
								FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
								FontAttributes = FontAttributes.Bold
							},
							new StackLayout {
								Orientation = StackOrientation.Horizontal,
								Padding = 20,
								Children ={
									new StackLayout {
										Orientation = StackOrientation.Vertical,
										Padding = 20,
										Children ={
											plus500Button,
											plus300Button,
											plus100Button,
										}
									},
									new StackLayout {
										Orientation = StackOrientation.Vertical,
										Padding = 20,
										Children ={
											plus50Button,
											plus30Button,
											plus10Button,
										}
									},
									new StackLayout {
										Orientation = StackOrientation.Vertical,
										Padding = 20,
										Children ={
											plus5Button,
											plus3Button,
											plus1Button,
										}
									},
								}
							},
							totalDeLaComidaEntry,
							new Label {
								XAlign = TextAlignment.Center,
								Text = "Porcentaje de propina ( % )",
								FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
								FontAttributes = FontAttributes.Bold
							},
							porcentajeDePropinaSlider,
							porcentajeDePropinaEntry,
							button
						}
					}
				}
			};


			button.Clicked +=   delegate(object sender, EventArgs e) {
				try
				{
					int numeroDePersonas =  Int32.Parse( numeroDePersonasEntry.Text ) ;
					float totalDeLaComida = float.Parse( totalDeLaComidaEntry.Text );
					float porcentajeDePropina = float.Parse( porcentajeDePropinaEntry.Text );
					float propinaPorPersona = ( totalDeLaComida / (float)numeroDePersonas ) * (porcentajeDePropina / 100f);
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

