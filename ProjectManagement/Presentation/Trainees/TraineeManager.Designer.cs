﻿namespace ProjectManagement.Presentation.Trainees
{
    partial class TraineeManager
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
            this.traineeForm1 = new ProjectManagement.Presentation.Trainees.TraineeForm();
            this.traineeDataGrid1 = new ProjectManagement.Presentation.Trainees.TraineeDataGrid();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_new = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // traineeForm1
            // 
            this.traineeForm1.Location = new System.Drawing.Point(3, 51);
            this.traineeForm1.Name = "traineeForm1";
            this.traineeForm1.Size = new System.Drawing.Size(315, 389);
            this.traineeForm1.TabIndex = 0;
            // 
            // traineeDataGrid1
            // 
            this.traineeDataGrid1.Location = new System.Drawing.Point(324, 51);
            this.traineeDataGrid1.Name = "traineeDataGrid1";
            this.traineeDataGrid1.Size = new System.Drawing.Size(525, 326);
            this.traineeDataGrid1.TabIndex = 1;
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(12, 446);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 2;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(219, 12);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(75, 23);
            this.bt_Delete.TabIndex = 4;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = true;
            // 
            // bt_new
            // 
            this.bt_new.Location = new System.Drawing.Point(12, 12);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(75, 23);
            this.bt_new.TabIndex = 5;
            this.bt_new.Text = "New";
            this.bt_new.UseVisualStyleBackColor = true;
            // 
            // TraineeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 496);
            this.Controls.Add(this.bt_new);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.traineeDataGrid1);
            this.Controls.Add(this.traineeForm1);
            this.Name = "TraineeManager";
            this.Text = "TraineeManager";
            this.ResumeLayout(false);

        }

        #endregion

        private TraineeForm traineeForm1;
        private TraineeDataGrid traineeDataGrid1;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_new;
    }
}