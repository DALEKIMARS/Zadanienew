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

namespace GlazkiProgram.pages
{
    
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// функция делает чтоб показывает страницу по верх окна
        /// </summary>
        /// <param name="sender">dfgfgg</param>
        /// <param name="e"></param>
        private void AgentBtn_Click(object sender, RoutedEventArgs e)
        {
            
            NavigationService.Navigate(new pages.AgentsPage());
        }
    }
}
