
namespace WindowsFormsApp
{
    partial class Form3
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
            this.Employename = new System.Windows.Forms.Label();
            this.Basicsalary = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.Employeid = new System.Windows.Forms.Label();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnDirectoryInfo = new System.Windows.Forms.Button();
            this.btnFileinfo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // Employename
            // 
            this.Employename.AutoSize = true;
            this.Employename.Location = new System.Drawing.Point(104, 137);
            this.Employename.Name = "Employename";
            this.Employename.Size = new System.Drawing.Size(141, 17);
            this.Employename.TabIndex = 1;
            this.Employename.Text = "Enter Employe Name";
            this.Employename.Click += new System.EventHandler(this.label2_Click);
            // 
            // Basicsalary
            // 
            this.Basicsalary.AutoSize = true;
            this.Basicsalary.Location = new System.Drawing.Point(110, 191);
            this.Basicsalary.Name = "Basicsalary";
            this.Basicsalary.Size = new System.Drawing.Size(124, 17);
            this.Basicsalary.TabIndex = 2;
            this.Basicsalary.Text = "Enter Basic Salary";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(255, 67);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(194, 22);
            this.txtid.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(265, 137);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(194, 22);
            this.txtname.TabIndex = 4;
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(255, 191);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(194, 22);
            this.txtsalary.TabIndex = 5;
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(304, 301);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(111, 37);
            this.btnBinaryRead.TabIndex = 6;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(144, 301);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(111, 37);
            this.btnBinaryWrite.TabIndex = 7;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(517, 60);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(111, 37);
            this.btnCreateFolder.TabIndex = 8;
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(654, 60);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(111, 37);
            this.btnCreateFile.TabIndex = 9;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // Employeid
            // 
            this.Employeid.AutoSize = true;
            this.Employeid.Location = new System.Drawing.Point(128, 60);
            this.Employeid.Name = "Employeid";
            this.Employeid.Size = new System.Drawing.Size(117, 17);
            this.Employeid.TabIndex = 10;
            this.Employeid.Text = "Enter Employe ID";
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(572, 118);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(120, 36);
            this.btnDeleteFile.TabIndex = 11;
            this.btnDeleteFile.Text = "Delete File";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnDirectoryInfo
            // 
            this.btnDirectoryInfo.Location = new System.Drawing.Point(551, 216);
            this.btnDirectoryInfo.Name = "btnDirectoryInfo";
            this.btnDirectoryInfo.Size = new System.Drawing.Size(150, 33);
            this.btnDirectoryInfo.TabIndex = 12;
            this.btnDirectoryInfo.Text = "Directory Info";
            this.btnDirectoryInfo.UseVisualStyleBackColor = true;
            this.btnDirectoryInfo.Click += new System.EventHandler(this.btnDirectoryInfo_Click);
            // 
            // btnFileinfo
            // 
            this.btnFileinfo.Location = new System.Drawing.Point(551, 279);
            this.btnFileinfo.Name = "btnFileinfo";
            this.btnFileinfo.Size = new System.Drawing.Size(150, 33);
            this.btnFileinfo.TabIndex = 13;
            this.btnFileinfo.Text = "File Info";
            this.btnFileinfo.UseVisualStyleBackColor = true;
            this.btnFileinfo.Click += new System.EventHandler(this.btnFileinfo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(551, 353);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 33);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFileinfo);
            this.Controls.Add(this.btnDirectoryInfo);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.Employeid);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.Basicsalary);
            this.Controls.Add(this.Employename);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Employename;
        private System.Windows.Forms.Label Basicsalary;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Label Employeid;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnDirectoryInfo;
        private System.Windows.Forms.Button btnFileinfo;
        private System.Windows.Forms.Button btnDelete;
    }
}