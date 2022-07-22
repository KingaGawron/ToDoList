using System.Windows.Controls;
using ToDoList.Core.ViewModels.Pages;

namespace ToDoList
{
    /// <summary>
    /// Logika interakcji dla klasy WorkTaskPage.xaml
    /// </summary>
    public partial class WorkTaskPage : Page
    {
        public WorkTaskPage()
        {
            InitializeComponent();
            DataContext = new WorkTaskPagesViewModel();
        }
    }
}
