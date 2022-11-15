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
        CountSum();
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

    public static void DeleteProductFromList(Product product)
    {
        products.Remove(product);
    }
    public static void EditProductFromList(Product product)
    {
        for (int i = 0; i < products.Count; i++)
        {
            if (product.Id == products[i].Id)
            {
                products[i] = product;
                break;
            }
        }
    }

    private async void productsList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        await Navigation.PushAsync(new Views.EditProductForm(products[e.ItemIndex]));
    }

    void CountSum()
    {
        decimal sum = 0;
        foreach(Product p in products)
        {
            sum += p.PriceNb * p.QuantityNb;
        }
        Sum.Text = sum.ToString()+" zł";
    }
}

