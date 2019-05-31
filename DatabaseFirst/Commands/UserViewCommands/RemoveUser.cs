using DatabaseFirst.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DatabaseFirst.Commands.UserViewCommands
{
    public class RemoveUser : ICommand
    {
        public UserViewModel UserViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public RemoveUser(UserViewModel UserViewModel)
        {
            this.UserViewModel = UserViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            using (MyDatabaseEntities db = new MyDatabaseEntities())
            {
                //db.Users.Remove()
            }
        }
    }
}
