using Caliburn.Micro;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PurpleCaliburnAdmin.ViewModels.Flyouts
{
    public abstract class FlyoutPageViewModel : PropertyChangedBase
    {
        private string header = string.Empty;
        private bool isOpen;
        private Position position;
        private FlyoutTheme theme = FlyoutTheme.Light;
        private Thickness margin = new Thickness(0);
        private Visibility closeButtonVisibility = Visibility.Visible;
        private Visibility titleVisibility = Visibility.Visible;
        private bool isModal = false;
        private bool isPinned = true;

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

        /// <summary>
        /// 两边缩进
        /// </summary>
        public Thickness Margin
        {
            get => this.margin;
            set
            {
                if (value == this.margin)
                {
                    return;
                }

                this.margin = value;
                this.NotifyOfPropertyChange(() => this.Margin);
            }
        }

        public Visibility CloseButtonVisibility
        {
            get => this.closeButtonVisibility;
            set
            {
                if (value == this.closeButtonVisibility)
                {
                    return;
                }

                this.closeButtonVisibility = value;
                this.NotifyOfPropertyChange(() => this.CloseButtonVisibility);
            }
        }
        /// <summary>
        /// Flyout 时禁止其他操作
        /// </summary>
        public bool IsModal
        {
            get => this.isModal;
            set
            {
                if (value == this.isModal)
                {
                    return;
                }

                this.isModal = value;
                this.NotifyOfPropertyChange(() => this.IsModal);
            }
        }

        /// <summary>
        /// 点击其他地方关闭
        /// </summary>
        public bool IsPinned
        {
            get => this.isPinned;
            set
            {
                if (value == this.isPinned)
                {
                    return;
                }

                this.isPinned = value;
                this.NotifyOfPropertyChange(() => this.IsPinned);
            }
        }





        public Visibility TitleVisibility
        {
            get => this.titleVisibility;
            set
            {
                if (value == this.titleVisibility)
                {
                    return;
                }

                this.titleVisibility = value;
                this.NotifyOfPropertyChange(() => this.TitleVisibility);
            }
        }
    }
}
