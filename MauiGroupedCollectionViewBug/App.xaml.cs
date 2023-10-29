namespace MauiGroupedCollectionViewBug;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        // This causes the group header to be continuously recreated when scrolling
        MainPage = new NavigationPage(new MainPage(new MainPageViewModel()));

        // This works fine
        //MainPage = new MainPage(new MainPageViewModel());
    }
}

