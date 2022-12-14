using Bubble.Infrastructure.Commands;
using Bubble.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Bubble.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Command

        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecute(object parameter) => true;
        private void OnCloseApplicationCommandExecutd(object parameter) 
        {
            Application.Current.Shutdown();
        }

        #endregion

        #endregion
        public MainWindowViewModel()
        {
            #region Command

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecutd, CanCloseApplicationCommandExecute);
            
            #endregion

        }
    }
}
