using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TaskPlanner
{
    public static class Database
    {
        static readonly string path = @"d:\Visual Projects\db.txt"; //program will create an empty file at this location if not changed
        private static BindingList<Task> TaskList = new BindingList<Task>();
        private static List<Task> FilteredTasks = new List<Task>();
        private static BindingList<Task> FilteredOutput = new BindingList<Task>();
      
        public static void LoadTasks()
        {
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    while (reader.Peek() >= 0)
                    {
                        string _readString;
                        string[] _sortedArray;
                        _readString = reader.ReadLine();
                        _sortedArray = _readString.Split(';');
                        Task _currentTask = new Task
                        {
                            TaskID = int.Parse(_sortedArray[0]),
                            Creator = _sortedArray[1],
                            ShortTitle = _sortedArray[2],
                            Description = _sortedArray[3],
                            TaskGroup = _sortedArray[4],
                            DueDate = _sortedArray[5]
                        };
                        TaskList.Add(_currentTask);
                    }
                }
            } else { using (File.Create(path)) { } }

        }

        public static void AddTask(int id, string creator, string name, string description, string group, string dueDate)
        {
            TaskList.Add(new Task(id, creator, name, description, group, dueDate));
            using StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine("{0};{1};{2};{3};{4};{5}", id, creator, name, description, group, dueDate);
         }



        public static BindingList<Task> LoadData()
        {
            LoadTasks();
            FilterTasks();
            return FilteredOutput;
        }


        public static int GetID()
        {
            var _lastTask = new Task();
            bool _exceptionFlag = false;

            try { _lastTask = TaskList.Last(); }
            catch 
            {
                _exceptionFlag = true;
                MessageBox.Show("The database is empty, starting a new database");
            }
            //some delicate ID handling incoming
            if (_exceptionFlag != true) { return _lastTask.TaskID + 1; }
            else
            { return _lastTask.TaskID; }
            
        }

        public static void FilterTasks() //this is messy but I have not found a better solution yet
        {
            switch (UserDatabase.GetActive())
            {
                case 0:
                    FilteredTasks = TaskList.Where
                         (task => task.TaskGroup == "Family" || task.TaskGroup == "Parents" || task.TaskGroup == "Kids" || task.TaskGroup == "Personal: Dad").ToList();
                    var listBinding = new BindingList<Task>(FilteredTasks);
                    FilteredOutput = listBinding;

                    break;
                case 1:

                    FilteredTasks = TaskList.Where
                        (task => task.TaskGroup == "Family" || task.TaskGroup == "Parents" || task.TaskGroup == "Kids" || task.TaskGroup == "Personal: Mom").ToList();
                    var listBinding1 = new BindingList<Task>(FilteredTasks);
                    FilteredOutput = listBinding1;
                    break;
                case 2:

                    FilteredTasks = TaskList.Where
                        (task => task.TaskGroup == "Family" || task.TaskGroup == "Kids" || task.TaskGroup == "Personal: Boy").ToList();
                    var listBinding2 = new BindingList<Task>(FilteredTasks);
                    FilteredOutput = listBinding2;
                    break;
                case 3:
 
                    FilteredTasks = TaskList.Where
                        (task => task.TaskGroup == "Family" || task.TaskGroup == "Kids" || task.TaskGroup == "Personal: Girl").ToList();
                    var listBinding3 = new BindingList<Task>(FilteredTasks);
                    FilteredOutput = listBinding3;
                    break;
            }
        }

        
        public static void MarkDone(string search)
        {
            string[] _lines = File.ReadAllLines(path); //copying and rewriting the file
            File.Delete(path);
            using (StreamWriter writer = File.AppendText(path))

            {
                foreach (string line in _lines)
                {
                    if (line.IndexOf(search) >= 0)
                    {
                       continue;
                    }
                    else
                    {
                        writer.WriteLine(line);
                    }
                }
            } 

        }
    }
}
