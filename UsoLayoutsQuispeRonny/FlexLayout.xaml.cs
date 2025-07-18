namespace UsoLayoutsQuispeRonny;

public partial class FlexLayout : ContentPage
{
    public FlexLayout()
    {
        InitializeComponent();
    }

    private async void OnGoToAbsoluteLayoutClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"///{nameof(AbsoluteLayout)}");
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///StackLayout");
    }

}
