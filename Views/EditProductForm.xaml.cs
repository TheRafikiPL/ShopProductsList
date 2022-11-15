using ShopProductsList.Models;

namespace ShopProductsList.Views;

public partial class EditProductForm : ContentPage
{
	Product temp;
	public EditProductForm(Product p)
	{
        InitializeComponent();
        temp = p;
		ProductName.Text = temp.Name;
		ProductDesc.Text = temp.Description;
		ProductPrice.Text = temp.PriceNb.ToString();
		ProductQuantity.Text = temp.Quantity;
	}

	private async void EditButton_Clicked(object sender, EventArgs e)
	{
        try
        {
            Product tmp = temp;
            tmp.Name = ProductName.Text;
            tmp.Description = ProductDesc.Text;
            tmp.PriceNb = decimal.Parse(ProductPrice.Text);
            tmp.QuantityNb = int.Parse(ProductQuantity.Text);
            MainPage.EditProductFromList(tmp);
        }
        catch (Exception)
        {

        }
        await Navigation.PopAsync();
    }

	private async void DeleteButton_Clicked(object sender, EventArgs e)
	{
        MainPage.DeleteProductFromList(temp);
        await Navigation.PopAsync();
    }
}