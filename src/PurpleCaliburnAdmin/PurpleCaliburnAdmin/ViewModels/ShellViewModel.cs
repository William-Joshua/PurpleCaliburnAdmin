using Caliburn.Micro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using PurpleCaliburnAdmin.ViewModels.Flyouts;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PurpleCaliburnAdmin.ViewModels
{
    [Export(typeof(IShell))]
    public class ShellViewModel : Conductor<object>.Collection.OneActive, IShell
    {
        private readonly IWindowManager _windowManager;
        private readonly IDialogCoordinator _dialogCoordinator;

        public IObservableCollection<FlyoutPageViewModel> FlyoutPageBars { get; set; }

        [ImportingConstructor]
        public ShellViewModel(IWindowManager windowManager, IDialogCoordinator dialogCoordinator )
        {
            _windowManager = windowManager;
            _dialogCoordinator = dialogCoordinator;
            InitializeShellView();
        }

        private void InitializeShellView()
        {
            this.FlyoutPageBars = new BindableCollection<FlyoutPageViewModel>();
        }


        protected override Task OnInitializeAsync(CancellationToken cancellationToken)
        {
            this.FlyoutPageBars.Add(new SearchBarFlyoutViewModel());
            this.FlyoutPageBars.Add(new RightBarFlyoutViewModel());
            return Task.FromResult(true);
        }

        /// <summary>
        /// Shown when the view is loaded.
        /// </summary>
        /// <param name="view"></param>
        protected override void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
        }

        public void ShowSearchBar()
        {
            var flyoutPage = this.FlyoutPageBars.FirstOrDefault(flyout => flyout is SearchBarFlyoutViewModel);
            if (flyoutPage != null)
            {
                flyoutPage.IsOpen = true;
            }
        }

        public void OpenInBrowser()
        {
            Process.Start("https://github.com/William-Joshua/PurpleCaliburnAdmin");
        }
        public void NavigateBackward()
        {

        }

        public void NavigateForward()
        {

        }
    }
}
