using ShopProductsList.Models;
namespace ShopProductsList.Views;

public partial class CurrentPage : ContentPage
{
	List<Product> Products;
	public CurrentPage()
	{
		InitializeComponent();
	}
	public static List<Product> GetTestProducts()
	{
		List<Product> temp = new List<Product>();
		temp.Add(new Product("Mojito", "Mojito jest super", 5.23M,2));
        temp.Add(new Product("Mojito", "Mojito jest super", 5.23M, 2));
        temp.Add(new Product("Mojito", "Mojito jest super", 5.23M, 2));
        return temp;
	}
	protected override void OnAppearing()
	{
		base.OnAppearing();

        Products = GetTestProducts();
        productsList.ItemsSource = Products;
    }
	
}