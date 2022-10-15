using ProjectX_Frontend.ViewModels;
using ProjectX_Frontend.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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


            //UpdateViewCommand = new UpdateViewCommand();
            // UpdateViewCommand.Execute("Home");

            // MainViewModel MainWiewModel = new MainWiewModel();


            // UpdateViewCommand UpdateViewCommand = new UpdateViewCommand();
            // UpdateViewCommand.Execute("Home");

            // MainViewModel.UpdateViewCommand.Execute("Home");

            //viewModel.SelectedViewModel = new HomeViewModel();


            //viewModel.SelectedViewModel = new HomeViewModel();


            // string testing = "Home";
            // object obj = testing;

            //this.UpdateViewCommand("Home");

            //viewModel.SelectedViewModel = new HomeViewModel();

            //UpdateViewCommand UpdateViewCommand = new UpdateViewCommand("Home");
            //string testing = "Home";
            //object obj = testing;
            //Execute(obj);
        }
        public void Execute(object parameter)
        {

            switch (parameter.ToString())
            {
                case "Home":
                    viewModel.SelectedViewModel = new HomeViewModel();
                    break;

                case "Account":
                    viewModel.SelectedViewModel = new AccountViewModel();
                    break;

                case "Cat":
                    viewModel.SelectedViewModel = new CatViewModel();
                    break; 

                default:
                    break;
            }
        }
    }
}
