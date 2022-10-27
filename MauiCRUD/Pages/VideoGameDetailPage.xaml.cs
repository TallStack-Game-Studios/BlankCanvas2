using MauiCRUD.Logic;
using MauiCRUD.Logic.Model;

namespace MauiCRUD.Pages;

public partial class VideoGameDetailPage : ContentPage
{
	public VideoGameDetailPage()
	{
		InitializeComponent();
	}

	private async void CancelButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();

	}

	private async void SaveButton_Clicked(object sender, EventArgs e)
	{
		//VideoGamesLogic videoGamesLogic = new VideoGamesLogic();
		//GameModel model = new GameModel();
		var model = (GameModel)BindingContext;
		if(model.ID == 0)
		{
			new VideoGamesLogic().AddVideoGame(model);
		}
		else
		{
            new VideoGamesLogic().UpdateVideoGame(model);
        }
		await Navigation.PopAsync();
	}

	private async void DeleteButton_Clicked(object sender, EventArgs e)
	{
		var model = (GameModel)BindingContext;

		new VideoGamesLogic().RemoveVideoGameByID(model.ID);
		await Navigation.PopAsync();
	}
}