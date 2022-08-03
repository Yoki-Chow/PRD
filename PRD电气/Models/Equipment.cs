using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRD电气.Models
{ 
    public class Equipment
    {
        public string Level { get; set; }
        public string FamilyType { get; set; }
        public string PanelName { get; set; }

        public Equipment(string level, string familyType, string panelName)
        {
            Level = level;
            FamilyType = familyType;
            PanelName = panelName;
        }

       



    }
    
}
