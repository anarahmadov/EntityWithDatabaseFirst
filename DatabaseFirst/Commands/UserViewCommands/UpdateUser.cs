using DatabaseFirst.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DatabaseFirst.Commands.UserViewCommands
{
    public class UpdateUser : ICommand
    {
        public UserViewModel UserViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public UpdateUser(UserViewModel UserViewModel)
        {
            this.UserViewModel = UserViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            
        }
    }
}
