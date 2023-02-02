using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavageWorlds.Tools.Data
{
    public class Database : IDataAccess
    {
        private readonly SQLiteAsyncConnection _connection;

        public Database()
        {
            var dataDir = FileSystem.AppDataDirectory;
            var databasePath = Path.Combine(dataDir, "SettingRules");

            string _dbEncryptionKey = SecureStorage.GetAsync("dbKey").Result;

            if(string.IsNullOrEmpty(_dbEncryptionKey))
            {
                Guid g = Guid.NewGuid();
                _dbEncryptionKey = g.ToString();
                SecureStorage.SetAsync("dbKey", _dbEncryptionKey);
            }

            var dbOptions = new SQLiteConnectionString(databasePath, true, key: _dbEncryptionKey);
            _connection = new SQLiteAsyncConnection(dbOptions);

            _ = SetupDatabase();
        }

        private async Task SetupDatabase()
        {
            await _connection.CreateTableAsync<SettingRule>();
            var count = await _connection.Table<SettingRule>().CountAsync();
            if(count == 0)
            {
                await LoadData();
            }
        }

        private async Task LoadData()
        {
            #region Data
            var data = new List<SettingRule>
            {
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition",
                    CanDelete = false,
                    PageNumber = 136,
                    RuleName = "Born A Hero"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition",
                    CanDelete = false,
                    PageNumber = 136,
                    RuleName = "Conviction"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition",
                    CanDelete = false,
                    PageNumber = 137,
                    RuleName = "Creative Combat"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition",
                    CanDelete = false,
                    PageNumber = 138,
                    RuleName = "Dumb Luck"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition",
                    CanDelete = false,
                    PageNumber = 138,
                    RuleName = "Dynamic Backlash"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition",
                    CanDelete = false,
                    PageNumber = 138,
                    RuleName = "Fanatics"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition",
                    CanDelete = false,
                    PageNumber = 139,
                    RuleName = "Fast Healing"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition",
                    CanDelete = false,
                    PageNumber = 139,
                    RuleName = "Gritty Damage"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition",
                    CanDelete = false,
                    PageNumber = 139,
                    RuleName = "Hard Choices"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition",
                    CanDelete = false,
                    PageNumber = 140,
                    RuleName = "Heroes Never Die"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition",
                    CanDelete = false,
                    PageNumber = 140,
                    RuleName = "High Adventure"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition",
                    CanDelete = false,
                    PageNumber = 140,
                    RuleName = "More Skill Points"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition",
                    CanDelete = false,
                    PageNumber = 140,
                    RuleName = "Multiple Languages"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition",
                    CanDelete = false,
                    PageNumber = 140,
                    RuleName = "No Power Points"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition",
                    CanDelete = false,
                    PageNumber = 141,
                    RuleName = "Skill Specialization"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition",
                    CanDelete = false,
                    PageNumber = 141,
                    RuleName = "Unarmored Hero"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition",
                    CanDelete = false,
                    PageNumber = 141,
                    RuleName = "Wound Cap"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Fantasy Companion",
                    CanDelete = false,
                    PageNumber = 76,
                    RuleName = "Betrayal"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Fantasy Companion",
                    CanDelete = false,
                    PageNumber = 76,
                    RuleName = "Difficult Healing"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Fantasy Companion",
                    CanDelete = false,
                    PageNumber = 77,
                    RuleName = "Betrayal"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Fantasy Companion",
                    CanDelete = false,
                    PageNumber = 77,
                    RuleName = "Downtime"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Fantasy Companion",
                    CanDelete = false,
                    PageNumber = 79,
                    RuleName = "Giant Foes"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Fantasy Companion",
                    CanDelete = false,
                    PageNumber = 79,
                    RuleName = "Villainous Conviction"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Super Powers Companion",
                    CanDelete = false,
                    PageNumber = 29,
                    RuleName = "Comic Book Combat"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Super Powers Companion",
                    CanDelete = false,
                    PageNumber = 34,
                    RuleName = "Death & Defeat"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Super Powers Companion",
                    CanDelete = false,
                    PageNumber = 34,
                    RuleName = "No Finishing Moves"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Super Powers Companion",
                    CanDelete = false,
                    PageNumber = 34,
                    RuleName = "Larger Than Life"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Super Powers Companion",
                    CanDelete = false,
                    PageNumber = 34,
                    RuleName = "Mega Destruction"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Super Powers Companion",
                    CanDelete = false,
                    PageNumber = 35,
                    RuleName = "Never Surrender"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Super Powers Companion",
                    CanDelete = false,
                    PageNumber = 35,
                    RuleName = "Throwdown"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Super Powers Companion",
                    CanDelete = false,
                    PageNumber = 35,
                    RuleName = "Training Montage"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Super Powers Companion",
                    CanDelete = false,
                    PageNumber = 36,
                    RuleName = "Villainous Conviction"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Horror Companion",
                    CanDelete = false,
                    PageNumber = 38,
                    RuleName = "Backlash"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Horror Companion",
                    CanDelete = false,
                    PageNumber = 38,
                    RuleName = "Buckets of Blood"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Horror Companion",
                    CanDelete = false,
                    PageNumber = 39,
                    RuleName = "Difficult Healing"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Horror Companion",
                    CanDelete = false,
                    PageNumber = 39,
                    RuleName = "Downtime"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Horror Companion",
                    CanDelete = false,
                    PageNumber = 41,
                    RuleName = "Environmental Phenomena"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Horror Companion",
                    CanDelete = false,
                    PageNumber = 43,
                    RuleName = "Expanded Fear Effects"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Horror Companion",
                    CanDelete = false,
                    PageNumber = 45,
                    RuleName = "Playing To The Tropes"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Horror Companion",
                    CanDelete = false,
                    PageNumber = 46,
                    RuleName = "Signs And Portents"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Horror Companion",
                    CanDelete = false,
                    PageNumber = 47,
                    RuleName = "Slaughter Rules"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Horror Companion",
                    CanDelete = false,
                    PageNumber = 48,
                    RuleName = "Villainous Conviction"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Horror Companion",
                    CanDelete = false,
                    PageNumber = 48,
                    RuleName = "Wards And Binds"
                },
                new SettingRule
                {
                    BookName = "Savage Worlds Adventure Edition Horror Companion",
                    CanDelete = false,
                    PageNumber = 50,
                    RuleName = "Wild Cards"
                }
            };
            #endregion
            await _connection.InsertAllAsync(data);
        }

        public async Task<List<SettingRule>> GetSettingRules()
        {
            return await _connection.Table<SettingRule>().ToListAsync();
        }

        public async Task<SettingRule> GetSettingRule(int id)
        {
            var query = _connection.Table<SettingRule>().Where(rec => rec.Id == id);
            return  await query.FirstOrDefaultAsync();
        }

        public async Task<int> AddSettingRule(SettingRule item)
        {
            return await _connection.InsertAsync(item);
        }

        public async Task<int> DeleteSettingRule(SettingRule item)
        {
            return await _connection.DeleteAsync(item);
        }

        public async Task<int> UpdateSettingRule(SettingRule item)
        {
            return await _connection.UpdateAsync(item);
        }
    }
}
