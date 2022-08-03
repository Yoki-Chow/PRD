using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRD电气.ViewModels
{
    public class MainViewModels : ViewModelBase
    {
        public ObservableCollection<EquipmentViewModel> Equipments { get; set; }
        public MainViewModels()
        {
            Equipments = new ObservableCollection<EquipmentViewModel>();
        }

        private string _floorFormat;
        public string FloorFormat
        {
            get { return _floorFormat; }
            set
            {
                _floorFormat = value;
                OnPropertyChanged(nameof(FloorFormat));
            }
        }
    }
}
