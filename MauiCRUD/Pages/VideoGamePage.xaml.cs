using MauiCRUD.Logic;
using MauiCRUD.Logic.Model;
using Microsoft.Maui.Controls;
using System;
namespace MauiCRUD.Pages;

public partial class VideoGamePage : ContentPage
{
	public VideoGamePage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		var Repo = new VideoGamesLogic();
		GamesListView.ItemsSource = Repo.GetVideoGames();
		BindingContext = Repo.GetVideoGames();
	}

	//Add New Item Function
	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Pages.VideoGameDetailPage { BindingContext = new GameModel() });
	}

	//Update or Delete Item Function
	private async void GamesListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
		GameModel model = (GameModel)e.SelectedItem;
        ArgumentNullException.ThrowIfNull(model);

        await Navigation.PushAsync(new Pages.VideoGameDetailPage { BindingContext = model });
    }
}