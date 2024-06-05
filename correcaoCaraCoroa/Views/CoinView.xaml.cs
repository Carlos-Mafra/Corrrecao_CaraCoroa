using correcaoCaraCoroa.Views;
using correcaoCaraCoroa.Models;
using correcaoCaraCoroa.ViewModels;


namespace correcaoCaraCoroa.Views;

public partial class CoinView : ContentPage
{
	public CoinView()
	{
        InitializeComponent();

        this.BindingContext = new CoinViewModel();

    }
}