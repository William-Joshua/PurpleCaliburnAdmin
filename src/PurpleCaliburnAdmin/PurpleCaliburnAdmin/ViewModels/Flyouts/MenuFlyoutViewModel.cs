using Caliburn.Micro;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleCaliburnAdmin.ViewModels.Flyouts
{
    public abstract class MenuFlyoutViewModel : PropertyChangedBase
    {
        private string header = string.Empty;
        private bool isOpen;
        private Position position;
        private FlyoutTheme theme = FlyoutTheme.Light;

        public string Header
        {
            get => this.header;
            set
            {
                if (value == this.header)
                {
                    return;
                }

                this.header = value;
                this.NotifyOfPropertyChange(() => this.Header);
            }
        }

        public bool IsOpen
        {
            get => this.isOpen;
            set
            {
                if (value.Equals(this.isOpen))
                {
                    return;
                }

                this.isOpen = value;
                this.NotifyOfPropertyChange(() => this.IsOpen);
            }
        }

        public Position Position
        {
            get => this.position;
            set
            {
                if (value == this.position)
                {
                    return;
                }

                this.position = value;
                this.NotifyOfPropertyChange(() => this.Position);
            }
        }

        public FlyoutTheme Theme
        {
            get => this.theme;
            set
            {
                if (value == this.theme)
                {
                    return;
                }

                this.theme = value;
                this.NotifyOfPropertyChange(() => this.Theme);
            }
        }
    }
}
