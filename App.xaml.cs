namespace ShopProductsList;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		Settings.CheckFileSystem();
		MainPage = new AppShell();
	}
}
