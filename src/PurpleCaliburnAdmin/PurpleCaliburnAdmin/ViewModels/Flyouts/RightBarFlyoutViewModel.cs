using Caliburn.Micro;
using MahApps.Metro.Controls;
using PurpleCaliburnAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleCaliburnAdmin.ViewModels.Flyouts
{
    public class RightBarFlyoutViewModel:MenuFlyoutViewModel
    {
        public IObservableCollection<FlyoutMenuItemEntryModel> FlyoutMenuItems { get; set; }
        public RightBarFlyoutViewModel(List<FlyoutMenuItemEntryModel> flyoutMenuItems)
        {
            this.Position = Position.Right;
            FlyoutMenuItems = new BindableCollection<FlyoutMenuItemEntryModel>(flyoutMenuItems);
        }
    }
}
