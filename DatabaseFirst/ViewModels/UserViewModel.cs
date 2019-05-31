using DatabaseFirst.Commands.UserViewCommands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public AddUser AddUser => new AddUser(this);
        public RemoveUser RemoveUser => new RemoveUser(this);
        public UpdateUser UpdateUser => new UpdateUser(this);
        public LoadUsers LoadUsers => new LoadUsers(this);

        private User currentUser;
        public User CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(CurrentUser)));
            }
        }

        private ObservableCollection<User> allUsers;
        public ObservableCollection<User> AllUsers
        {
            get
            {
                return allUsers;
            }
            set
            {
                allUsers = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(AllUsers)));
            }
        }

        public UserViewModel()
        {
            AllUsers = new ObservableCollection<User>();

            CurrentUser = new User();
        }
    }
}
