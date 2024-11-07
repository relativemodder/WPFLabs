using Entities;
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

namespace WPFLabs.Components
{
    /// <summary>
    /// Interaction logic for TaskBlock.xaml
    /// </summary>
    public partial class TaskBlock : UserControl
    {
        private TaskModel? task;

        public TaskBlock()
        {
            InitializeComponent();
        }

        public void LoadData(TaskModel task)
        {
            this.task = task;
            InitComponents();
        }
        
        private void InitComponents()
        {
            if (task == null)
            {
                return;
            }
            TaskTitleTextBlock.Text = task.Name;
            TaskTimeTextBlock.Text = task.Time.ToShortTimeString();

            CompletedIcon.Visibility = Visibility.Collapsed;
            UncompletedIcon.Visibility = Visibility.Collapsed;

            if (task.Completed)
            {
                CompletedIcon.Visibility = Visibility.Visible;
            }
            else
            {
                UncompletedIcon.Visibility = Visibility.Visible;
            }
        }
    }
}
