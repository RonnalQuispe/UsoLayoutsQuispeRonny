namespace UsoLayoutsQuispeRonny;

public partial class StackLayout : ContentPage
{
	public StackLayout()
	{
		InitializeComponent();
	}
    private async void OnGoToFlexLayoutClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"///{nameof(FlexLayout)}");
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///GridLayout");
    }
}