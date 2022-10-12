using ProjectX_Frontend.ViewModels;
using ProjectX_Frontend.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectX_Frontend.Commands
{
    public class UpdateViewCommand : ICommand
    {
        public UpdateViewCommand()
        {
        }
        private MainViewModel viewModel;
        private string v;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public UpdateViewCommand(string v)
        {
            this.v = v;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void ShowHome ()
        {
            //viewModel.SelectedViewModel = new HomeViewModel();

            //UpdateViewCommand UpdateViewCommand = new UpdateViewCommand("Home");
            //string testing = "Home";
            //object obj = testing;
            //Execute(obj);
        }
        public void Execute(string parameter)
        {
            if(parameter.ToString() == "Home")
            {
                viewModel.SelectedViewModel = new HomeViewModel();
            }
            else if(parameter.ToString() == "Account")
            {
                viewModel.SelectedViewModel = new AccountViewModel();
            }
            else if (parameter.ToString() == "Login")
            {
                viewModel.SelectedViewModel = new LoginViewModel();
            }
        }
    }
}
