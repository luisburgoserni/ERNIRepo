namespace MiPrimerMAUIApp;

public partial class MainPage : ContentPage
{
	int count = 0;

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

	private void OnDecreaseClicked(object sender, EventArgs e)
	{
		count--;

		CounterBtn.Text = $"Clicked {count} time";
        SemanticScreenReader.Announce(CounterBtn.Text);

        for (int i = 0; i < 20; i++)
		{
			CounterBtn2.Text = i.ToString();
			SemanticScreenReader.Announce(CounterBtn2.Text);
			Thread.Sleep(200);

        }

		CounterBtn2.BackgroundColor = Color.FromRgb(0, 128, 0);
    }
}

