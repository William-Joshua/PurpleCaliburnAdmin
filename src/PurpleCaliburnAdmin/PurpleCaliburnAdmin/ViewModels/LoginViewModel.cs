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
    [Export(typeof(LoginViewModel))]
    public class LoginViewModel : Conductor<object>.Collection.OneActive
    {
        private readonly IWindowManager _windowManager;
        private readonly IDialogCoordinator _dialogCoordinator;


        [ImportingConstructor]
        public LoginViewModel(IWindowManager windowManager, IDialogCoordinator dialogCoordinator)
        {
            _windowManager = windowManager;
            _dialogCoordinator = dialogCoordinator;
        }
    }
}
