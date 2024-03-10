namespace ProjectUI
{
    partial class EditProjectForm
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.dateToPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(241, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Проект";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.Location = new System.Drawing.Point(294, 334);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(147, 39);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Отменить";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(135, 334);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(144, 39);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // titleTxt
            // 
            this.titleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTxt.Location = new System.Drawing.Point(138, 89);
            this.titleTxt.MaxLength = 100;
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(303, 28);
            this.titleTxt.TabIndex = 4;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTxt.Location = new System.Drawing.Point(138, 150);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(303, 56);
            this.descriptionTxt.TabIndex = 5;
            // 
            // dateFromPicker
            // 
            this.dateFromPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateFromPicker.Location = new System.Drawing.Point(138, 237);
            this.dateFromPicker.Name = "dateFromPicker";
            this.dateFromPicker.Size = new System.Drawing.Size(303, 22);
            this.dateFromPicker.TabIndex = 6;
            // 
            // dateToPicker
            // 
            this.dateToPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateToPicker.Location = new System.Drawing.Point(138, 292);
            this.dateToPicker.Name = "dateToPicker";
            this.dateToPicker.Size = new System.Drawing.Size(303, 22);
            this.dateToPicker.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(134, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Название проекта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(134, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Описание проекта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(134, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата начала";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(134, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата окончания";
            // 
            // EditProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 385);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateToPicker);
            this.Controls.Add(this.dateFromPicker);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(594, 432);
            this.MinimumSize = new System.Drawing.Size(594, 432);
            this.Name = "EditProjectForm";
            this.Text = "Работа с проектами";
            this.Load += new System.EventHandler(this.EditProjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.DateTimePicker dateFromPicker;
        private System.Windows.Forms.DateTimePicker dateToPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}