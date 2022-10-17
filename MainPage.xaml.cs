namespace ShopProductsList;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void ToolbarItem_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Views.CurrentPage());
	}
}

