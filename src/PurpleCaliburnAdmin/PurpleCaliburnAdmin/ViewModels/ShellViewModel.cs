using Caliburn.Micro;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleCaliburnAdmin.ViewModels
{
    [Export(typeof(IShell))]
    public class ShellViewModel : Conductor<object>.Collection.OneActive, IShell
    {
        private readonly IWindowManager _windowManager;
        private readonly IDialogCoordinator _dialogCoordinator;



        [ImportingConstructor]
        public ShellViewModel(IWindowManager windowManager, IDialogCoordinator dialogCoordinator )
        {
            _windowManager = windowManager;
            _dialogCoordinator = dialogCoordinator;
        }


        /// <summary>
        /// Shown when the view is loaded.
        /// </summary>
        /// <param name="view"></param>
        protected override void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
        }

    }
}
