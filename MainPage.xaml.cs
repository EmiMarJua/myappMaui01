
namespace MauiApp01;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private string _display= "0";
    private string _expression = " ";
    private double? _accumulator;
    private string? _operator;
    private bool _resetOnNextDigit;

    //public MainViewModel(){
        // DigitCommand = new Command<string>(OnDigit);
        // OperatorCommand =  new Command<string>(OnOperator);
        // EqualsCommand = new Command(OnEquals);
        //  ClearCommand = new Command(OnClear);
        //  DecimalCommand = new Command(OnDecimal);
        //  ToggleSignCommand = new Command(OnToggleSing);
        //  PercentCommand = new Command(OnPercent);
        //  
        //
    //}

}
