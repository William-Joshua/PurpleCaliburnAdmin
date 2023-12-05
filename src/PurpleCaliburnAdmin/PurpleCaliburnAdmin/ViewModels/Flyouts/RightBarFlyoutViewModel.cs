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
    public class RightBarFlyoutViewModel:FlyoutPageViewModel
    {
        public RightBarFlyoutViewModel()
        {
            this.Position = Position.Right;
        }
    }
}
