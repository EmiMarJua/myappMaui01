using System.Globalization;
using System.Windows.Input;

namespace MauiApp01;

public partial class MainPage : ContentPage
{
    private string _display= "0";
    private string _expression = "";


	public MainPage()
	{
		InitializeComponent();

        CelsiusCommand = new Command(OnConvertCelsiustoFarenheit);
        FarenheitCommand = new Command(OnConvertFarenheittoCelsius);
        
        BindingContext = this;

	}

    public string Display
    {
        get => _display;
        private set { if (_display != value) { _display = value; OnPropertyChanged(); } }
    }

    public string Expression
    {
        get => _expression;
        private set { if (_expression != value) { _expression = value; OnPropertyChanged(); } }
    }

	public ICommand CelsiusCommand {get;}
    public ICommand FarenheitCommand {get;}

    public void OnConvertCelsiustoFarenheit()
    {

       double c = double.Parse(textTemperatura.Text);
        double f = (c * 9 / 5 ) + 32;

        Display = f.ToString("0.##" , CultureInfo.CurrentCulture) + " °F";
        Expression = $"{c} °C = {Display} ";

    }

    public void OnConvertFarenheittoCelsius()
    {
        
        double f = double.Parse(textTemperatura.Text);
        double c = (f - 32) * 5/9;

        Display = c.ToString("0.##",CultureInfo.CurrentCulture) + " °C";
        Expression = $"{f} °F = {Display}" ;

    }

}
