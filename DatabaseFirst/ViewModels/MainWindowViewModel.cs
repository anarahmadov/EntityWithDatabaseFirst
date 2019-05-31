using DatabaseFirst.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DatabaseFirst.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ShowUsersCommand ShowUsersCommand => new ShowUsersCommand(this);
        public ShowNewsCommand ShowNewsCommand => new ShowNewsCommand(this);
        public ShowCommentsCommand ShowCommentsCommand => new ShowCommentsCommand(this);

        public Grid Grid { get; set; }      

        public MainWindowViewModel()
        {
            
        }
    }
}
