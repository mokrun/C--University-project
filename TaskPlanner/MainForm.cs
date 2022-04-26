using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskPlanner
{
    public partial class MainForm : Form
    {
        private static int Taskgroupid;//this is nesessary to keep track of who creates which tasks
        
        public static string TaskGroupName()
        {
            return Taskgroupid switch //a Dictionary refused to work here despite my firmest intentions
            {
                0 => "Family",
                1 => "Parents",
                2 => "Kids",
                3 => "Personal: Dad",
                4 => "Personal: Mom",
                5 => "Personal: Boy",
                6 => "Personal: Girl",
                _ => "",
            };
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
            DataGridViewMain.DataSource = Database.LoadData();
        }

        private void createGlobalbutton_Click(object sender, EventArgs e)
        {
            Taskgroupid = 0; //task group flag set to global
            var _newCreatemenu = new CreateTaskMenu(); 
            _newCreatemenu.ShowDialog();
        }

        private void createGroupbutton_Click(object sender, EventArgs e)
        {
            if (UserDatabase.GetActive() != 0 && UserDatabase.GetActive() != 1) 
            { Taskgroupid = 2; } //if kids press the group button it creates a kid task
            else
            { Taskgroupid = 1; }
            var _newCreatemenu = new CreateTaskMenu();
            _newCreatemenu.ShowDialog();
        }

        private void createPersonalbutton_Click(object sender, EventArgs e)
        {
            switch (UserDatabase.GetActive())
            {
                case 0:
                    Taskgroupid = 3;
                    break;
                case 1:
                    Taskgroupid = 4;
                    break;
                case 2:
                    Taskgroupid = 5;
                    break;
                case 3:
                    Taskgroupid = 6;
                    break;
                default:
                    MessageBox.Show("How did you manage to do that?");
                    break;
            }
            var _newCreatemenu = new CreateTaskMenu();
            _newCreatemenu.ShowDialog();
            
        }

        private void createKidTaskButton_Click(object sender, EventArgs e)
        {
            if (UserDatabase.GetActive() != 0 && UserDatabase.GetActive() != 1)
            { MessageBox.Show("Use the 'Create group task' button to create a kid task!"); }
            else// kids can't use this button as it duplicates behaviour of 'create group task' button
            {
                Taskgroupid = 2;
                var _newCreatemenu = new CreateTaskMenu();
                _newCreatemenu.ShowDialog();
            }
        }

        private void markdoneButton_Click(object sender, EventArgs e)
        {
            string _entered = "";
            if (UserDatabase.GetActive() != 0 && UserDatabase.GetActive() != 1)
            { MessageBox.Show("Only parents can mark tasks as done."); }
            else
            {
                try { _entered = Convert.ToString(DonetaskTextBox.Text); }
                catch (Exception exception) { MessageBox.Show(exception.Message); }
                Database.MarkDone(_entered);// searching for keyword and deleting the task
                MessageBox.Show("Task has been marked 'Done' and will be gone forever after you close the app!");
            }
        }
    }
}
