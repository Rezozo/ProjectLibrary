using ProjectLibrary;
using ProjectLibrary.models;
using System;
using System.Windows.Forms;

namespace ProjectUI
{
    public partial class EditProjectForm : Form
    {
        public UIEditor UIEditor = new UIEditor();
        public bool IsEdit { get; set; }
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime dateTo { get; set; }
        public DateTime dateFrom { get; set; }

        public EditProjectForm()
        {
            InitializeComponent();
        }

        private void EditProjectForm_Load(object sender, EventArgs e)
        {
            titleTxt.Text = Title;
            descriptionTxt.Text = Description;
            if (dateFrom > DateTime.MinValue)
            {
                dateFromPicker.Value = dateFrom;
                dateToPicker.Value = dateTo;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titleTxt.Text) || (dateToPicker.Value < dateFromPicker.Value))
            {
                MessageBox.Show("Заполните данные корректно");
                return;
            }

            Project project = new Project(Id, titleTxt.Text, descriptionTxt.Text, dateToPicker.Value, dateFromPicker.Value, null);
            if (IsEdit)
            {
                UIEditor.EditProject(project);
            }
            else
            {
                UIEditor.CreateProject(project);
            }
            Close();
        }
    }
}
