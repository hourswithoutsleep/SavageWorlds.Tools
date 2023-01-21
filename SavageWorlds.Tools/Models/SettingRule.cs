using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavageWorlds.Tools.Models
{
    public class SettingRule
    {
        public int Id { get; set; }
        public string RuleName { get; set; }
        public string BookName { get; set; }
        public int PageNumber { get; set; }
        public string Description { get; set; }
        public bool CanDelete { get; set; } = true;
    }
}
