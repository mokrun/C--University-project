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
    public partial class CreateTaskMenu : Form
    {
        public CreateTaskMenu()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (FieldsFilled() == true)
            {
                string _creatorId = UserDatabase.GetActiveText();//taken from login screen and stored in the database
                int _tempId = Database.GetID() ;//taken from last ID in db.txt
                string _taskGroup = MainForm.TaskGroupName();//taken from user pressing the correct button in main form
                string _nameEntered = "", _descriptionEntered = "", _dateEntered = "";
                try { _nameEntered = Convert.ToString(NameTextbox.Text);
                    _descriptionEntered = Convert.ToString(DescriptionTextbox.Text);
                    _dateEntered = Convert.ToString(DuedateTextbox.Text);
                }
                catch (Exception exception) { MessageBox.Show(exception.Message); }
                Database.AddTask(_tempId, _creatorId, _nameEntered, _descriptionEntered, _taskGroup, _dateEntered);
               MessageBox.Show("The task was created and will be shown when the app relaunches. You can create more tasks.");
                //yes, after spending days debugging I couldn't manage to get the DataGridView to update despite updating the binding list
            }
        }
        private bool FieldsFilled() //empty fields check
        {
            if(NameTextbox.Text == string.Empty)
            {
                if(DescriptionTextbox.Text == string.Empty)
                {
                    MessageBox.Show("These fields can't be empty");
                    return false;
                }
                return false;
            }
            else return true;
        }
    }   
}
