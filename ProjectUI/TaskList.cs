using ProjectLibrary;
using System;
using System.Windows.Forms;

namespace ProjectUI
{
    public partial class TaskList : Form
    {
        private UIEditor UIEditor = new UIEditor();
        public int ProjectId { get; set; }

        public TaskList()
        {
            InitializeComponent();
        }

        private void TaskList_Load(object sender, EventArgs e)
        {
            UIEditor.TaskView = taskView;
            UpdateTasks();
        }

        private void UpdateTasks()
        {
            UIEditor.RefreshTaskList(ProjectId);
        }

        private void taskView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = taskView.Rows[e.RowIndex];

            if (row.Cells != null)
            {
                ChooseTaskForm chooseForm = new ChooseTaskForm();
                chooseForm.ProjectId = ProjectId;
                chooseForm.Id = (int)row.Cells["Id"].Value;
                chooseForm.Title = (string)row.Cells["Title"].Value;
                chooseForm.Description = (string)row.Cells["Description"].Value;
                chooseForm.IsDone = (bool) row.Cells["IsDone"].Value;
                chooseForm.ShowDialog();
            }

            UpdateTasks();
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            EditTaskForm editTaskForm = new EditTaskForm();
            editTaskForm.IsEdit = false;
            editTaskForm.ProjectId = ProjectId;
            editTaskForm.ShowDialog();
            Close();
        }
    }
}