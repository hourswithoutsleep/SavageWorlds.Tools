using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavageWorlds.Tools.Interfaces
{
    public interface IDataAccess
    {
        public Task<List<SettingRule>> GetSettingRules();
        public Task<SettingRule> GetSettingRule(int id);
        public Task<int> AddSettingRule(SettingRule item);
        public Task<int> DeleteSettingRule(SettingRule item);
        public Task<int> UpdateSettingRule(SettingRule item);
    }
}
