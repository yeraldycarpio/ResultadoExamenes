namespace ResultadoExamenes;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void Resultado_Clicked(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(notaA.Text)
					  && !string.IsNullOrEmpty(notaB.Text)
					  && !string.IsNullOrEmpty(notaC.Text)
					  && !string.IsNullOrEmpty(notaD.Text)
					  && !string.IsNullOrEmpty(notaE.Text))
		{

			var nota1 = Convert.ToDouble(notaA.Text);
			var nota2 = Convert.ToDouble(notaB.Text);
			var nota3 = Convert.ToDouble(notaC.Text);
			var nota4 = Convert.ToDouble(notaD.Text);
			var nota5 = Convert.ToDouble(notaE.Text);
			var Resultado = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
			notaFinal.Text = Convert.ToString(Resultado);
		}
		else
		{
			DisplayAlert("Error", "Digite sus notas", "Gracias;)");
		}


	}
}

