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
using System.Windows.Shapes;

namespace ChronoTask
{
    /// <summary>
    /// Interaction logic for UpdateProjectDialog.xaml
    /// </summary>
    public partial class UpdateProjectDialog : Window
    {
        public string ProjectName { get; private set; }

        public UpdateProjectDialog(Project project)
        {
            InitializeComponent();
            ProjectNameTextBox.Text = project.Name;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            ProjectName = ProjectNameTextBox.Text;
            DialogResult = true;
        }
    }

}
