namespace UsoLayoutsQuispeRonny;

public partial class AbsoluteLayout : ContentPage
{
    public AbsoluteLayout()
    {
        InitializeComponent();
    }

    private async void OnGoToGridLayoutClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"///{nameof(GridLayout)}");
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///FlexLayout");

    }

}


