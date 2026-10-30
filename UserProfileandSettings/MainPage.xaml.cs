namespace UserProfileandSettings;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnSaveChangesClicked(object sender, EventArgs e)
    {
        string name = DisplayNameEntry.Text ?? string.Empty;
        string bio = BioEditor.Text ?? string.Empty;

        // DisplayAlert shows the "Settings Saved" popup with the entered values
        await DisplayAlert(
            "Settings Saved",
            $"Name: {name}\nBio: {bio}",
            "OK");
    }
}