using ShopProductsList.Models;

namespace ShopProductsList;

public partial class MainPage : ContentPage
{
    static List<Product> products;
	public MainPage()
	{
		InitializeComponent();
        products = FileLoad.LoadCurrentToList(Settings.currentPath);
    }

    public static List<Product> GetTestProducts()
    {
        List<Product> temp = new List<Product>();
        temp.Add(new Product("Mojito", "Mojito jest super\nSuper", 5.23M, 2));
        temp.Add(new Product("Mojito", "Mojito jest super", 5.23M, 2));
        temp.Add(new Product("Mojito", "Mojito jest super", 5.23M, 2));
        temp.Add(new Product("xd", Settings.currentPath,0M,0));
        return temp;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadCurrentData();
        productsList.ItemsSource = products;
    }

    void LoadCurrentData()
    {
        FileSave.ListToFile(products, Settings.currentPath);
        products = FileLoad.LoadCurrentToList(Settings.currentPath);
    }

    private async void AddProductButt_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.CreateProductForm());
    }

    public static void AddProductToList(Product product)
    {
        products.Add(product);
    }
}

