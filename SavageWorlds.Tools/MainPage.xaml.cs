using SavageWorlds.Tools.Data;
using SavageWorlds.Tools.Models;
using System.Collections.ObjectModel;

namespace SavageWorlds.Tools;

public partial class MainPage : ContentPage
{
	public ObservableCollection<SettingRule> Rules { get; set; } = new();
	readonly Database _database;

	public MainPage()
	{
		InitializeComponent();
		_database = new Database();

		_ = Load();
	}

	private async Task Load()
	{
		var rules = await _database.GetSettingRules();
		foreach(var rule in rules)
		{
			Rules.Add(rule);
		}
	}
}

