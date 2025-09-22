using Sciencecalculator.ViewModels;

namespace Sciencecalculator.Views;

public partial class CalculatorPage : ContentPage
{
	public CalculatorPage()
    {
        InitializeComponent();

        this.BindingContext = new CalculatorPageViewModels();
    }
}