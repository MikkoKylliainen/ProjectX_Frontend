using ProjectX_Frontend.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using ProjectX_Frontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX_Frontend
{
    public class Singleton
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Bio { get; set; }

        private static Singleton instance;

       private Singleton() {}

       public static Singleton Instance
       {
          get 
          {
             if (instance == null)
             {
                instance = new Singleton();
             }
             return instance;
          }
       }
    }
}
