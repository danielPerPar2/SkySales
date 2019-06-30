namespace SkySales.Presentation.WinForm
{
    partial class Form1
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
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.lblStudentAge = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.txtStudentAge = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(57, 38);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(19, 17);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Id";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(57, 67);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(45, 17);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Name";
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.Location = new System.Drawing.Point(57, 95);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(65, 17);
            this.lblStudentSurname.TabIndex = 2;
            this.lblStudentSurname.Text = "Surname";
            // 
            // lblStudentAge
            // 
            this.lblStudentAge.AutoSize = true;
            this.lblStudentAge.Location = new System.Drawing.Point(57, 123);
            this.lblStudentAge.Name = "lblStudentAge";
            this.lblStudentAge.Size = new System.Drawing.Size(33, 17);
            this.lblStudentAge.TabIndex = 3;
            this.lblStudentAge.Text = "Age";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(150, 33);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(100, 22);
            this.txtStudentId.TabIndex = 4;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(150, 62);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 22);
            this.txtStudentName.TabIndex = 5;
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.Location = new System.Drawing.Point(150, 90);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(100, 22);
            this.txtStudentSurname.TabIndex = 6;
            // 
            // txtStudentAge
            // 
            this.txtStudentAge.Location = new System.Drawing.Point(150, 118);
            this.txtStudentAge.Name = "txtStudentAge";
            this.txtStudentAge.Size = new System.Drawing.Size(100, 22);
            this.txtStudentAge.TabIndex = 7;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(64, 176);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 31);
            this.btnAddStudent.TabIndex = 8;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(164, 176);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(99, 52);
            this.btnGetAll.TabIndex = 9;
            this.btnGetAll.Text = "Get All Students";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.BtnGetAll_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(386, 176);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(75, 31);
            this.btnUpdateStudent.TabIndex = 10;
            this.btnUpdateStudent.Text = "Update";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.BtnUpdateStudent_Click);
            // 
            // btnGetById
            // 
            this.btnGetById.Location = new System.Drawing.Point(286, 176);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(75, 31);
            this.btnGetById.TabIndex = 11;
            this.btnGetById.Text = "Get by Id";
            this.btnGetById.UseVisualStyleBackColor = true;
            this.btnGetById.Click += new System.EventHandler(this.BtnGetById_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(481, 176);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(75, 31);
            this.btnDeleteStudent.TabIndex = 12;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.BtnDeleteStudent_Click);
            // 
            // listViewStudents
            // 
            this.listViewStudents.Location = new System.Drawing.Point(64, 252);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(570, 167);
            this.listViewStudents.TabIndex = 13;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.listViewStudents);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtStudentAge);
            this.Controls.Add(this.txtStudentSurname);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.lblStudentAge);
            this.Controls.Add(this.lblStudentSurname);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblStudentId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.Label lblStudentAge;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.TextBox txtStudentAge;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.ListView listViewStudents;
    }
}

