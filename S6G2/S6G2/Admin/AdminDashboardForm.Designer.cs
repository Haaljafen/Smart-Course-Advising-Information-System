namespace S6G2.Admain
{
    partial class AdminDashboardForm
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdvisors = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelheader = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelAdvisors = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelCourses = new System.Windows.Forms.Panel();
            this.lblCoursesTitle = new System.Windows.Forms.Label();
            this.panelStudents = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.cmbSpecialization = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtCourseType = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialization = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelMenu.SuspendLayout();
            this.panelheader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelAdvisors.SuspendLayout();
            this.panelCourses.SuspendLayout();
            this.panelStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.Menu;
            this.panelMenu.Controls.Add(this.logoutBtn);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.btnAdvisors);
            this.panelMenu.Controls.Add(this.btnStudents);
            this.panelMenu.Controls.Add(this.btnCourses);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 655);
            this.panelMenu.TabIndex = 0;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Red;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.logoutBtn.Location = new System.Drawing.Point(12, 598);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(190, 45);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Menu";
            // 
            // btnAdvisors
            // 
            this.btnAdvisors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvisors.Location = new System.Drawing.Point(24, 278);
            this.btnAdvisors.Name = "btnAdvisors";
            this.btnAdvisors.Size = new System.Drawing.Size(178, 49);
            this.btnAdvisors.TabIndex = 2;
            this.btnAdvisors.Text = "Manage Advisors";
            this.btnAdvisors.UseVisualStyleBackColor = true;
            this.btnAdvisors.Click += new System.EventHandler(this.btnAdvisors_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Location = new System.Drawing.Point(24, 198);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(178, 49);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "Manage Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.SystemColors.Window;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Location = new System.Drawing.Point(24, 123);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(178, 48);
            this.btnCourses.TabIndex = 0;
            this.btnCourses.Text = "Manage Courses";
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.SystemColors.Menu;
            this.panelheader.Controls.Add(this.label1);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(220, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(788, 100);
            this.panelheader.TabIndex = 4;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panelCourses);
            this.panelContent.Controls.Add(this.panelAdvisors);
            this.panelContent.Controls.Add(this.panelStudents);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(220, 100);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(788, 555);
            this.panelContent.TabIndex = 5;
            // 
            // panelAdvisors
            // 
            this.panelAdvisors.Controls.Add(this.label5);
            this.panelAdvisors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdvisors.Location = new System.Drawing.Point(0, 0);
            this.panelAdvisors.Name = "panelAdvisors";
            this.panelAdvisors.Size = new System.Drawing.Size(788, 555);
            this.panelAdvisors.TabIndex = 1;
            this.panelAdvisors.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Manage Advisors";
            // 
            // panelCourses
            // 
            this.panelCourses.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCourses.Controls.Add(this.label9);
            this.panelCourses.Controls.Add(this.txtCourseType);
            this.panelCourses.Controls.Add(this.txtLevel);
            this.panelCourses.Controls.Add(this.txtCourseCode);
            this.panelCourses.Controls.Add(this.chkIsActive);
            this.panelCourses.Controls.Add(this.label11);
            this.panelCourses.Controls.Add(this.label10);
            this.panelCourses.Controls.Add(this.label8);
            this.panelCourses.Controls.Add(this.cmbSpecialization);
            this.panelCourses.Controls.Add(this.btnAddCourse);
            this.panelCourses.Controls.Add(this.btnUpdateCourse);
            this.panelCourses.Controls.Add(this.btnDeleteCourse);
            this.panelCourses.Controls.Add(this.label7);
            this.panelCourses.Controls.Add(this.label6);
            this.panelCourses.Controls.Add(this.txtCredits);
            this.panelCourses.Controls.Add(this.txtCourseName);
            this.panelCourses.Controls.Add(this.txtCourseId);
            this.panelCourses.Controls.Add(this.label3);
            this.panelCourses.Controls.Add(this.dgvCourses);
            this.panelCourses.Controls.Add(this.lblCoursesTitle);
            this.panelCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCourses.Location = new System.Drawing.Point(0, 0);
            this.panelCourses.Name = "panelCourses";
            this.panelCourses.Size = new System.Drawing.Size(788, 555);
            this.panelCourses.TabIndex = 0;
            this.panelCourses.Visible = false;
            this.panelCourses.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCourses_Paint);
            // 
            // lblCoursesTitle
            // 
            this.lblCoursesTitle.AutoSize = true;
            this.lblCoursesTitle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoursesTitle.Location = new System.Drawing.Point(39, 23);
            this.lblCoursesTitle.Name = "lblCoursesTitle";
            this.lblCoursesTitle.Size = new System.Drawing.Size(153, 24);
            this.lblCoursesTitle.TabIndex = 0;
            this.lblCoursesTitle.Text = "Manage Courses";
            // 
            // panelStudents
            // 
            this.panelStudents.Controls.Add(this.label4);
            this.panelStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStudents.Location = new System.Drawing.Point(0, 0);
            this.panelStudents.Name = "panelStudents";
            this.panelStudents.Size = new System.Drawing.Size(788, 555);
            this.panelStudents.TabIndex = 1;
            this.panelStudents.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Manage Students";
            // 
            // dgvCourses
            // 
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseID,
            this.Specialization,
            this.CourseName,
            this.CreditHours,
            this.CourseCode,
            this.Level,
            this.CourseType,
            this.IsActive});
            this.dgvCourses.Location = new System.Drawing.Point(34, 65);
            this.dgvCourses.MultiSelect = false;
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RowHeadersWidth = 62;
            this.dgvCourses.RowTemplate.Height = 28;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(711, 257);
            this.dgvCourses.TabIndex = 1;
            this.dgvCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course ID";
            // 
            // txtCourseId
            // 
            this.txtCourseId.Location = new System.Drawing.Point(156, 353);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.Size = new System.Drawing.Size(102, 26);
            this.txtCourseId.TabIndex = 3;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(156, 431);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(102, 26);
            this.txtCourseName.TabIndex = 4;
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(156, 471);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(102, 26);
            this.txtCredits.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Course Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Credits";
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.Color.Red;
            this.btnDeleteCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCourse.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCourse.Location = new System.Drawing.Point(559, 464);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(191, 34);
            this.btnDeleteCourse.TabIndex = 8;
            this.btnDeleteCourse.Text = "Delete";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.Location = new System.Drawing.Point(650, 418);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(100, 34);
            this.btnUpdateCourse.TabIndex = 9;
            this.btnUpdateCourse.Text = "Update";
            this.btnUpdateCourse.UseVisualStyleBackColor = true;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(558, 418);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(86, 34);
            this.btnAddCourse.TabIndex = 10;
            this.btnAddCourse.Text = "Add";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // cmbSpecialization
            // 
            this.cmbSpecialization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecialization.FormattingEnabled = true;
            this.cmbSpecialization.Location = new System.Drawing.Point(305, 471);
            this.cmbSpecialization.Name = "cmbSpecialization";
            this.cmbSpecialization.Size = new System.Drawing.Size(196, 28);
            this.cmbSpecialization.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Course Code";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Level";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(301, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Course Type";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Location = new System.Drawing.Point(573, 359);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(95, 24);
            this.chkIsActive.TabIndex = 16;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(158, 390);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(100, 26);
            this.txtCourseCode.TabIndex = 17;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(406, 353);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(100, 26);
            this.txtLevel.TabIndex = 19;
            // 
            // txtCourseType
            // 
            this.txtCourseType.Location = new System.Drawing.Point(406, 391);
            this.txtCourseType.Name = "txtCourseType";
            this.txtCourseType.Size = new System.Drawing.Size(100, 26);
            this.txtCourseType.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Specialization";
            // 
            // CourseID
            // 
            this.CourseID.DataPropertyName = "CourseID";
            this.CourseID.HeaderText = "Course ID";
            this.CourseID.MinimumWidth = 8;
            this.CourseID.Name = "CourseID";
            this.CourseID.ReadOnly = true;
            this.CourseID.Width = 150;
            // 
            // Specialization
            // 
            this.Specialization.DataPropertyName = "SpecializationID";
            this.Specialization.HeaderText = "Specialization";
            this.Specialization.MinimumWidth = 8;
            this.Specialization.Name = "Specialization";
            this.Specialization.ReadOnly = true;
            this.Specialization.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Specialization.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Specialization.Width = 150;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.MinimumWidth = 8;
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            this.CourseName.Width = 150;
            // 
            // CreditHours
            // 
            this.CreditHours.DataPropertyName = "CreditHours";
            this.CreditHours.HeaderText = "Credits";
            this.CreditHours.MinimumWidth = 8;
            this.CreditHours.Name = "CreditHours";
            this.CreditHours.ReadOnly = true;
            this.CreditHours.Width = 150;
            // 
            // CourseCode
            // 
            this.CourseCode.DataPropertyName = "CourseCode";
            this.CourseCode.HeaderText = "Course Code";
            this.CourseCode.MinimumWidth = 8;
            this.CourseCode.Name = "CourseCode";
            this.CourseCode.ReadOnly = true;
            this.CourseCode.Width = 150;
            // 
            // Level
            // 
            this.Level.DataPropertyName = "Level";
            this.Level.HeaderText = "Level";
            this.Level.MinimumWidth = 8;
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.Width = 150;
            // 
            // CourseType
            // 
            this.CourseType.DataPropertyName = "CourseType";
            this.CourseType.HeaderText = "CourseType";
            this.CourseType.MinimumWidth = 8;
            this.CourseType.Name = "CourseType";
            this.CourseType.ReadOnly = true;
            this.CourseType.Width = 150;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "Active";
            this.IsActive.MinimumWidth = 8;
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsActive.Width = 150;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 655);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelheader);
            this.Controls.Add(this.panelMenu);
            this.Name = "AdminDashboardForm";
            this.Text = "AdminDashboardForm";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelAdvisors.ResumeLayout(false);
            this.panelAdvisors.PerformLayout();
            this.panelCourses.ResumeLayout(false);
            this.panelCourses.PerformLayout();
            this.panelStudents.ResumeLayout(false);
            this.panelStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAdvisors;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelCourses;
        private System.Windows.Forms.Label lblCoursesTitle;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Panel panelStudents;
        private System.Windows.Forms.Panel panelAdvisors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.ComboBox cmbSpecialization;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCourseType;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Specialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}