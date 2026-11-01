using Microsoft.Extensions.DependencyInjection;

namespace NumberGuessingGame;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		Window window = new Window(new AppShell())
		{
			Width = 700,
			Height = 700
		};

		return window;
	}
}
