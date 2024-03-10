namespace ProjectUI
{
    partial class EditTaskForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.isDoneCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(129, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(129, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Описание задачи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(129, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Название задачи";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTxt.Location = new System.Drawing.Point(133, 172);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(303, 56);
            this.descriptionTxt.TabIndex = 16;
            // 
            // titleTxt
            // 
            this.titleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTxt.Location = new System.Drawing.Point(133, 111);
            this.titleTxt.MaxLength = 100;
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(303, 28);
            this.titleTxt.TabIndex = 15;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(133, 276);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(141, 39);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.Location = new System.Drawing.Point(289, 276);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(147, 39);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Отменить";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(236, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Задача";
            // 
            // isDoneCheck
            // 
            this.isDoneCheck.AutoSize = true;
            this.isDoneCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isDoneCheck.Location = new System.Drawing.Point(133, 236);
            this.isDoneCheck.Name = "isDoneCheck";
            this.isDoneCheck.Size = new System.Drawing.Size(127, 26);
            this.isDoneCheck.TabIndex = 22;
            this.isDoneCheck.Text = "Выполнена";
            this.isDoneCheck.UseVisualStyleBackColor = true;
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 385);
            this.Controls.Add(this.isDoneCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(594, 432);
            this.MinimumSize = new System.Drawing.Size(594, 389);
            this.Name = "EditTaskForm";
            this.Text = "Работа с задачами";
            this.Load += new System.EventHandler(this.EditTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isDoneCheck;
    }
}