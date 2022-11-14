using ShopProductsList.Models;

namespace ShopProductsList.Views;

public partial class CreateProductForm : ContentPage
{
	public CreateProductForm()
	{
		InitializeComponent();
	}

	private async void AddButton_Clicked(object sender, EventArgs e)
	{
		try
		{
			string name = ProductName.Text;
			string desc = ProductDesc.Text;
			decimal price = decimal.Parse(ProductPrice.Text);
			int quantity = int.Parse(ProductQuantity.Text);
			Product product = new Product(name, desc, price, quantity);
			MainPage.AddProductToList(product);
			await Navigation.PopAsync();
		}
		catch(Exception)
		{

		}
	}
}