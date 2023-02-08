using SavageWorlds.Tools.Data;
using SavageWorlds.Tools.Models;
using SavageWorlds.Tools.ViewModels;
using System.Collections.ObjectModel;

namespace SavageWorlds.Tools;

public partial class MainPage : ContentPage
{
	
	public MainPage(MainPageViewModel model)
	{
		InitializeComponent();
		_ = Setup(model);
	}

	public async Task Setup(MainPageViewModel model)
	{
		BindingContext = model;
	}
}

