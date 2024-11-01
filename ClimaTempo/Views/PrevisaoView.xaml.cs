using ClimaTempo.ViewModels;

namespace ClimaTempo.Views;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
		BindingContext = new PrevisaoViewModel();
	}
}