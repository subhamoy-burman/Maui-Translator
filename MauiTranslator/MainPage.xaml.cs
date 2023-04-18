using CommunityToolkit.Maui.Storage;
using System.Threading;
namespace MauiTranslator;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        var folderPickerResult = await FilePicker.Default.PickAsync();
        if (folderPickerResult != null)
        {
            oldFileEntry.Text = folderPickerResult.FileName;
        }
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        var folderPickerResult = await FilePicker.Default.PickAsync();
        if (folderPickerResult != null)
        {
            newFileEntry.Text = folderPickerResult.FileName;
        }
    }
}

