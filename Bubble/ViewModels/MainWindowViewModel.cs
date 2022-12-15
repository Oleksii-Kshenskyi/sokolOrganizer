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
        private void OnCloseApplicationCommandExecuted(object parameter) => Application.Current.Shutdown();
        #endregion
        #region DragMoveCommand
        public ICommand DragMoveCommand { get; }

        private bool CanDragMoveCommandExecute(object parameter) => true;
        private void OnDragMoveCommandExecuted(object parameter) => Window.DragMove();

        #endregion
        #endregion
        public MainWindowViewModel()
        {
            #region Command

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            DragMoveCommand = new LambdaCommand(OnDragMoveCommandExecuted, CanDragMoveCommandExecute);
            #endregion

        }
    }
}
