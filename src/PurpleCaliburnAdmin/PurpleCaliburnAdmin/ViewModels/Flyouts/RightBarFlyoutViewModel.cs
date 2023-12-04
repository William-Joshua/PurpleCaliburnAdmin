using Caliburn.Micro;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleCaliburnAdmin.ViewModels.Flyouts
{
    public class RightBarFlyoutViewModel
    {
        public IObservableCollection<NavMenuItemEntryModel> FlyoutMenuItems { get; set; }
        public RightFlyoutBarViewModel(List<NavMenuItemEntryModel> flyoutMenuItems)
        {
            this.Position = Position.Right;
            FlyoutMenuItems = new BindableCollection<NavMenuItemEntryModel>(flyoutMenuItems);
        }
    }
}
