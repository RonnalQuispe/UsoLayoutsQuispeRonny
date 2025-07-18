namespace UsoLayoutsQuispeRonny;

public partial class GridLayout : ContentPage
{
	public GridLayout()
	{
		InitializeComponent();
	}
    private async void OnGoToStackLayoutClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"///{nameof(StackLayout)}");

    }
}