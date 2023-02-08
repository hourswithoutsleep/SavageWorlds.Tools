using SavageWorlds.Tools.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavageWorlds.Tools.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<SettingRule> Rules { get; set; } = new();
        private readonly IDataAccess _database;

        public MainPageViewModel(IDataAccess database)
        {
            _database = database;
            _ = Load();
        }
        private async Task Load()
        {
            var rules = await _database.GetSettingRules();
            foreach (var rule in rules)
            {
                Rules.Add(rule);
            }
        }
    }
}
