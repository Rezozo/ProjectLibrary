using ProjectLibrary;
using System;
using System.Windows.Forms;

namespace ProjectUI
{
    public partial class ChooseForm : Form
    {
        private UIEditor UIEditor = new UIEditor();
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime dateTo { get; set; }
        public DateTime dateFrom { get; set; }
        public ChooseForm()
        {
            InitializeComponent();
        }

        private void removeProjectBtn_Click(object sender, EventArgs e)
        {
            UIEditor.DeleteProject(ProjectId);
            Close();
        }

        private void showTasksBtn_Click(object sender, EventArgs e)
        {
            TaskList taskList = new TaskList();
            taskList.ProjectId = ProjectId;
            taskList.ShowDialog();
            Close();
        }

        private void editProjectBtn_Click(object sender, EventArgs e)
        {
            EditProjectForm editProjectForm = new EditProjectForm();
            editProjectForm.IsEdit = true;
            editProjectForm.Id = ProjectId;
            editProjectForm.Title = Title;
            editProjectForm.Description = Description;
            editProjectForm.dateTo = dateTo;
            editProjectForm.dateFrom = dateFrom;
            editProjectForm.ShowDialog();
            Close();
        }
    }
}
