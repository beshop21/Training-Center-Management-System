namespace Training_Center_Management_System
{
    partial class FrmMain
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
            this.TrainingStrip = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StudentToolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CoursestoolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.EnrollmentstoolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.UserstoolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingstoolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.TrainingStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TrainingStrip
            // 
            this.TrainingStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StudentToolstrip,
            this.CoursestoolStrip,
            this.EnrollmentstoolStrip,
            this.UserstoolStrip,
            this.SettingstoolStrip});
            this.TrainingStrip.Location = new System.Drawing.Point(0, 0);
            this.TrainingStrip.Name = "TrainingStrip";
            this.TrainingStrip.Size = new System.Drawing.Size(926, 72);
            this.TrainingStrip.TabIndex = 0;
            this.TrainingStrip.Text = "TrainingStrip";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Training_Center_Management_System.Properties.Resources._360_F_1936663921_Q9MXf5xaV01eDXeiWQ2whaHZKDXFzuGb;
            this.pictureBox1.Location = new System.Drawing.Point(0, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(926, 378);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // StudentToolstrip
            // 
            this.StudentToolstrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentToolstrip.Image = global::Training_Center_Management_System.Properties.Resources.People_64;
            this.StudentToolstrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.StudentToolstrip.Name = "StudentToolstrip";
            this.StudentToolstrip.Size = new System.Drawing.Size(153, 68);
            this.StudentToolstrip.Text = "Students";
            // 
            // CoursestoolStrip
            // 
            this.CoursestoolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoursestoolStrip.Image = global::Training_Center_Management_System.Properties.Resources.Test_Type_64;
            this.CoursestoolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CoursestoolStrip.Name = "CoursestoolStrip";
            this.CoursestoolStrip.Size = new System.Drawing.Size(145, 68);
            this.CoursestoolStrip.Text = "Courses";
            // 
            // EnrollmentstoolStrip
            // 
            this.EnrollmentstoolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollmentstoolStrip.Image = global::Training_Center_Management_System.Properties.Resources.Add_New_User_72;
            this.EnrollmentstoolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EnrollmentstoolStrip.Name = "EnrollmentstoolStrip";
            this.EnrollmentstoolStrip.Size = new System.Drawing.Size(291, 68);
            this.EnrollmentstoolStrip.Text = "Enrollments (Registration) ";
            // 
            // UserstoolStrip
            // 
            this.UserstoolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserstoolStrip.Image = global::Training_Center_Management_System.Properties.Resources.users_64;
            this.UserstoolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UserstoolStrip.Name = "UserstoolStrip";
            this.UserstoolStrip.Size = new System.Drawing.Size(127, 68);
            this.UserstoolStrip.Text = "Users";
            // 
            // SettingstoolStrip
            // 
            this.SettingstoolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingstoolStrip.Image = global::Training_Center_Management_System.Properties.Resources.account_settings_64;
            this.SettingstoolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SettingstoolStrip.Name = "SettingstoolStrip";
            this.SettingstoolStrip.Size = new System.Drawing.Size(148, 68);
            this.SettingstoolStrip.Text = "Settings";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TrainingStrip);
            this.MainMenuStrip = this.TrainingStrip;
            this.Name = "FrmMain";
            this.Text = "Main";
            this.TrainingStrip.ResumeLayout(false);
            this.TrainingStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TrainingStrip;
        private System.Windows.Forms.ToolStripMenuItem StudentToolstrip;
        private System.Windows.Forms.ToolStripMenuItem CoursestoolStrip;
        private System.Windows.Forms.ToolStripMenuItem EnrollmentstoolStrip;
        private System.Windows.Forms.ToolStripMenuItem UserstoolStrip;
        private System.Windows.Forms.ToolStripMenuItem SettingstoolStrip;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

