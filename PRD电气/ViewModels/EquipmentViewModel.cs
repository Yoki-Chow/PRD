using PRD电气.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRD电气.ViewModels
{
    public class EquipmentViewModel : ViewModelBase
    {
        
        public string FamilyType
        {
            get { return FamilyType; }
            set
            {
                FamilyType = value;
                OnPropertyChanged(nameof(FamilyType));
            }
        }
        public string PanelName
        {
            get { return PanelName; }
            set
            {
                PanelName = value;
                OnPropertyChanged(nameof(PanelName));
            }
        }


    }

}
