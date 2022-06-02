namespace MauiScooter;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        App.Current.MainPage = new FirstPage();
    }
}

