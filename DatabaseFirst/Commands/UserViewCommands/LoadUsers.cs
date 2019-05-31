using DatabaseFirst.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DatabaseFirst.Commands.UserViewCommands
{
    public class LoadUsers : ICommand
    {
        public UserViewModel UserViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public LoadUsers(UserViewModel UserViewModel)
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
                UserViewModel.AllUsers = new ObservableCollection<User>(db.Users.ToList());
              
            }
        }
    }
}
