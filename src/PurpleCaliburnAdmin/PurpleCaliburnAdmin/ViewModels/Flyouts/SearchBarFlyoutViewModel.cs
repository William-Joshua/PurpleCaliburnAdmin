using Caliburn.Micro;
using PurpleCaliburnAdmin.Models;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PurpleCaliburnAdmin.ViewModels.Flyouts
{
    public class SearchBarFlyoutViewModel: FlyoutPageViewModel
    {
        public SearchBarFlyoutViewModel()
        {
            this.Margin = new Thickness(140, 0, 140, 0);
            this.IsModal = true;
            this.IsPinned = false;
            this.TitleVisibility = Visibility.Collapsed;
            this.CloseButtonVisibility = Visibility.Collapsed;
            this.Position = Position.Top;
            this.Theme = FlyoutTheme.Dark;
        }
    }
}
