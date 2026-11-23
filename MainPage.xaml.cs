using System.Runtime.InteropServices.ObjectiveC;

namespace MauiApp01;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object? sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private void Button_Clicked(object sender, EventArgs e)
	{
	}

    private void ClearBtn_Clicked(object sender, EventArgs e)
	{
		
		CounterBtn.Text = $"Clicked {count = 0} time";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}
