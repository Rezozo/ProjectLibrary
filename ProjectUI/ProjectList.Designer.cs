namespace ProjectUI
{
    partial class ProjectList
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.projectView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addProject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projectView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список всех проектов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(615, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Для осуществления действия, нажмите два раза на выбранный проект";
            // 
            // projectView
            // 
            this.projectView.AllowUserToAddRows = false;
            this.projectView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.projectView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Description,
            this.DateFrom,
            this.DateTo});
            this.projectView.GridColor = System.Drawing.SystemColors.Control;
            this.projectView.Location = new System.Drawing.Point(18, 95);
            this.projectView.Name = "projectView";
            this.projectView.RowHeadersWidth = 51;
            this.projectView.RowTemplate.Height = 24;
            this.projectView.Size = new System.Drawing.Size(1036, 576);
            this.projectView.TabIndex = 2;
            this.projectView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectView_CellDoubleClick);
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
            this.Title.HeaderText = "Наименование";
            this.Title.MaxInputLength = 100;
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 250;
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
            // DateFrom
            // 
            this.DateFrom.HeaderText = "Дата начала";
            this.DateFrom.MinimumWidth = 6;
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.ReadOnly = true;
            this.DateFrom.Width = 125;
            // 
            // DateTo
            // 
            this.DateTo.HeaderText = "Дата окончания";
            this.DateTo.MinimumWidth = 6;
            this.DateTo.Name = "DateTo";
            this.DateTo.ReadOnly = true;
            this.DateTo.Width = 125;
            // 
            // addProject
            // 
            this.addProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProject.Location = new System.Drawing.Point(833, 22);
            this.addProject.Name = "addProject";
            this.addProject.Size = new System.Drawing.Size(221, 48);
            this.addProject.TabIndex = 3;
            this.addProject.Text = "Добавить проект";
            this.addProject.UseVisualStyleBackColor = true;
            this.addProject.Click += new System.EventHandler(this.addProject_Click);
            // 
            // ProjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 683);
            this.Controls.Add(this.addProject);
            this.Controls.Add(this.projectView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1093, 730);
            this.MinimumSize = new System.Drawing.Size(1093, 730);
            this.Name = "ProjectList";
            this.Text = "Список проектов";
            this.Load += new System.EventHandler(this.ProjectList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView projectView;
        private System.Windows.Forms.Button addProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTo;
    }
}

