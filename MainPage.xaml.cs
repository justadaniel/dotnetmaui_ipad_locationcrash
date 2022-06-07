namespace DotNetMaui_LocationCrash;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();


		Task.Run(async () =>
        {
			// Comment this out and build to device again. It should run flawlessly with it commented out.
			var _status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            var _currentLocation = await Geolocation.GetLocationAsync();
        });
	}


	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
    }
}


