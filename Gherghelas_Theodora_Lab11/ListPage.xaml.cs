using Gherghelas_Theodora_Lab11.Models;
namespace Gherghelas_Theodora_Lab11;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
		InitializeComponent();
	}

	async void OnSaveButtonClicked(object sender, EventArgs e)
	{
		var slist = (ShopList)BindingContext;
		slist.Date = DateTime.UtcNow;
		await App.Database.SaveShopListAsync(slist);
		await Navigation.PopAsync(); //asta trimite pe pag precedenta
	}

	async void OnDeleteButtonClicked(object sender, EventArgs e)
	{
		var slist = (ShopList)BindingContext;
		await App.Database.DeleteShopListAsync(slist);
		await Navigation.PopAsync();
	}
}