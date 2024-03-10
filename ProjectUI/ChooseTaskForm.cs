using ProjectLibrary;
using System.Windows.Forms;

namespace ProjectUI
{
    public partial class ChooseTaskForm : Form
    {
        private UIEditor UIEditor = new UIEditor();
        public int ProjectId { get; set; }
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; } 

        public ChooseTaskForm()
        {
            InitializeComponent();
        }

        private void removeTaskBtn_Click(object sender, System.EventArgs e)
        {
            UIEditor.DeleteTask(Id);
            Close();
        }

        private void editTaskBtn_Click(object sender, System.EventArgs e)
        {
            EditTaskForm editTaskForm = new EditTaskForm();
            editTaskForm.IsEdit = true;
            editTaskForm.ProjectId = ProjectId;
            editTaskForm.Id = Id;
            editTaskForm.Title = Title;
            editTaskForm.Description = Description;
            editTaskForm.IsDone = IsDone;
            editTaskForm.ShowDialog();
            Close();
        }
    }
}
