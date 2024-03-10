using ProjectLibrary;
using ProjectLibrary.models;
using System;
using System.Windows.Controls;
using System.Windows.Forms;

namespace ProjectUI
{
    public partial class EditTaskForm : Form
    {
        public UIEditor UIEditor = new UIEditor();
        public bool IsEdit { get; set; }
        public int ProjectId { get; set; }  
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }

        public EditTaskForm()
        {
            InitializeComponent();
        }

        private void EditTaskForm_Load(object sender, EventArgs e)
        {
            titleTxt.Text = Title;
            descriptionTxt.Text = Description;
            isDoneCheck.Checked = IsDone;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titleTxt.Text))
            {
                MessageBox.Show("Заполните данные корректно");
                return;
            }

            Task task = new Task(Id, titleTxt.Text, descriptionTxt.Text, isDoneCheck.Checked, ProjectId);
            if (IsEdit)
            {
                UIEditor.EditTask(task);
            } else
            {
                UIEditor.CreateTask(task);
            }
            Close();
        }
    }
}
