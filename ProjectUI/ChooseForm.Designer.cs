namespace ProjectUI
{
    partial class ChooseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.removeProjectBtn = new System.Windows.Forms.Button();
            this.showTasksBtn = new System.Windows.Forms.Button();
            this.editProjectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(155, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите действие";
            // 
            // removeProjectBtn
            // 
            this.removeProjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeProjectBtn.Location = new System.Drawing.Point(151, 69);
            this.removeProjectBtn.Name = "removeProjectBtn";
            this.removeProjectBtn.Size = new System.Drawing.Size(257, 38);
            this.removeProjectBtn.TabIndex = 1;
            this.removeProjectBtn.Text = "Удалить проект";
            this.removeProjectBtn.UseVisualStyleBackColor = true;
            this.removeProjectBtn.Click += new System.EventHandler(this.removeProjectBtn_Click);
            // 
            // showTasksBtn
            // 
            this.showTasksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showTasksBtn.Location = new System.Drawing.Point(151, 132);
            this.showTasksBtn.Name = "showTasksBtn";
            this.showTasksBtn.Size = new System.Drawing.Size(257, 38);
            this.showTasksBtn.TabIndex = 2;
            this.showTasksBtn.Text = "Просмотр задач";
            this.showTasksBtn.UseVisualStyleBackColor = true;
            this.showTasksBtn.Click += new System.EventHandler(this.showTasksBtn_Click);
            // 
            // editProjectBtn
            // 
            this.editProjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editProjectBtn.Location = new System.Drawing.Point(151, 197);
            this.editProjectBtn.Name = "editProjectBtn";
            this.editProjectBtn.Size = new System.Drawing.Size(257, 38);
            this.editProjectBtn.TabIndex = 3;
            this.editProjectBtn.Text = "Редактировать проект";
            this.editProjectBtn.UseVisualStyleBackColor = true;
            this.editProjectBtn.Click += new System.EventHandler(this.editProjectBtn_Click);
            // 
            // ChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 279);
            this.Controls.Add(this.editProjectBtn);
            this.Controls.Add(this.showTasksBtn);
            this.Controls.Add(this.removeProjectBtn);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(578, 326);
            this.MinimumSize = new System.Drawing.Size(578, 326);
            this.Name = "ChooseForm";
            this.Text = "Выбор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeProjectBtn;
        private System.Windows.Forms.Button showTasksBtn;
        private System.Windows.Forms.Button editProjectBtn;
    }
}