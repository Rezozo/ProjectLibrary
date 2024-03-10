namespace ProjectUI
{
    partial class ChooseTaskForm
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
            this.removeTaskBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.editTaskBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // removeTaskBtn
            // 
            this.removeTaskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeTaskBtn.Location = new System.Drawing.Point(152, 98);
            this.removeTaskBtn.Name = "removeTaskBtn";
            this.removeTaskBtn.Size = new System.Drawing.Size(257, 38);
            this.removeTaskBtn.TabIndex = 5;
            this.removeTaskBtn.Text = "Удалить задачу";
            this.removeTaskBtn.UseVisualStyleBackColor = true;
            this.removeTaskBtn.Click += new System.EventHandler(this.removeTaskBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(159, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите действие";
            // 
            // editTaskBtn
            // 
            this.editTaskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editTaskBtn.Location = new System.Drawing.Point(152, 161);
            this.editTaskBtn.Name = "editTaskBtn";
            this.editTaskBtn.Size = new System.Drawing.Size(257, 38);
            this.editTaskBtn.TabIndex = 6;
            this.editTaskBtn.Text = "Редактировать задачу";
            this.editTaskBtn.UseVisualStyleBackColor = true;
            this.editTaskBtn.Click += new System.EventHandler(this.editTaskBtn_Click);
            // 
            // ChooseTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 279);
            this.Controls.Add(this.editTaskBtn);
            this.Controls.Add(this.removeTaskBtn);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(578, 326);
            this.MinimumSize = new System.Drawing.Size(578, 326);
            this.Name = "ChooseTaskForm";
            this.Text = "Выбор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button removeTaskBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editTaskBtn;
    }
}