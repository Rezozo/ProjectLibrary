using ProjectLibrary;
using System;
using System.Windows.Forms;

namespace ProjectUI
{
    public partial class ProjectList : Form
    {
        private UIEditor uiEditor = new UIEditor();

        public ProjectList()
        {
            InitializeComponent();
        }

        private void ProjectList_Load(object sender, EventArgs e)
        {
            uiEditor.ProjectView = projectView;
            UpdateProject();
        }

        private void UpdateProject()
        {
            uiEditor.RefreshProjectList();
        }

        private void addProject_Click(object sender, EventArgs e)
        {
            EditProjectForm editProjectForm = new EditProjectForm();
            editProjectForm.IsEdit = false;
            editProjectForm.ShowDialog();

            UpdateProject();
        }

        private void projectView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = projectView.Rows[e.RowIndex];

            if (row.Cells != null)
            {
                ChooseForm chooseForm = new ChooseForm();
                chooseForm.ProjectId = (int) row.Cells["Id"].Value;
                chooseForm.Title = (string)row.Cells["Title"].Value;
                chooseForm.Description = (string)row.Cells["Description"].Value;
                chooseForm.dateTo = DateTime.Parse(row.Cells["DateTo"].Value.ToString());
                chooseForm.dateFrom = DateTime.Parse(row.Cells["DateFrom"].Value.ToString());
                chooseForm.ShowDialog();
            }

            UpdateProject();
        }
    }
}
