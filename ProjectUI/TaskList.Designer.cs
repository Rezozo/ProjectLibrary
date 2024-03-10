namespace ProjectUI
{
    partial class TaskList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addTask = new System.Windows.Forms.Button();
            this.taskView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taskView)).BeginInit();
            this.SuspendLayout();
            // 
            // addTask
            // 
            this.addTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTask.Location = new System.Drawing.Point(572, 12);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(221, 32);
            this.addTask.TabIndex = 7;
            this.addTask.Text = "Добавить задачу";
            this.addTask.UseVisualStyleBackColor = true;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // taskView
            // 
            this.taskView.AllowUserToAddRows = false;
            this.taskView.AllowUserToDeleteRows = false;
            this.taskView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.taskView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Description,
            this.IsDone});
            this.taskView.GridColor = System.Drawing.SystemColors.Control;
            this.taskView.Location = new System.Drawing.Point(18, 97);
            this.taskView.MultiSelect = false;
            this.taskView.Name = "taskView";
            this.taskView.RowHeadersWidth = 51;
            this.taskView.RowTemplate.Height = 24;
            this.taskView.Size = new System.Drawing.Size(775, 398);
            this.taskView.TabIndex = 6;
            this.taskView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taskView_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Номер";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Title
            // 
            this.Title.HeaderText = "Название";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание";
            this.Description.MaxInputLength = 18;
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 250;
            // 
            // IsDone
            // 
            this.IsDone.HeaderText = "Выполнен";
            this.IsDone.MinimumWidth = 6;
            this.IsDone.Name = "IsDone";
            this.IsDone.ReadOnly = true;
            this.IsDone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsDone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsDone.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(616, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Для осуществления действия, нажмите два раза на выбранную задачу";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список всех задач";
            // 
            // TaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 507);
            this.Controls.Add(this.addTask);
            this.Controls.Add(this.taskView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaskList";
            this.Text = "Список задач";
            this.Load += new System.EventHandler(this.TaskList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.DataGridView taskView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDone;
    }
}