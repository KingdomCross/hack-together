using Microsoft.Graph.Models;

namespace MAUIwithMSGRaph;

public partial class MainPage : ContentPage
{
	int count = 0;
    private GraphService graphService;
    private User user;
    public MainPage()
	{
		InitializeComponent();
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

    private async void GetUserInfoBtn_Clicked(object sender, EventArgs e)
    {
        [RelayCommand]
        private async Task LoadUserInformation()
        {
            var service = new GraphService();
            Microsoft.Graph.Models.User user = await service.GetMyDetailsAsync();
            helloMessage = $"Hello, {user.DisplayName}";

            UserName = user.DisplayName;
            UserGivenName = user.GivenName;
            UserSurname = user.Surname;
            UserPrincipalName = user.UserPrincipalName;
        }
    }
}

