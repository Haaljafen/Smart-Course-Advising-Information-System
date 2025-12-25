namespace S6G2
{
    partial class AdviserStudentsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecializationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntakeSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sCIAS_DBDataSet = new S6G2.SCIAS_DBDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new S6G2.SCIAS_DBDataSetTableAdapters.StudentsTableAdapter();
            this.adviseeAssignmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advisee_AssignmentsTableAdapter = new S6G2.SCIAS_DBDataSetTableAdapters.Advisee_AssignmentsTableAdapter();
            this.adviseeAssignmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SemesterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advisingPlansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.advisingPlanCoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advising_Plan_CoursesTableAdapter = new S6G2.SCIAS_DBDataSetTableAdapters.Advising_Plan_CoursesTableAdapter();
            this.advising_PlansTableAdapter = new S6G2.SCIAS_DBDataSetTableAdapters.Advising_PlansTableAdapter();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.courseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new S6G2.SCIAS_DBDataSetTableAdapters.CoursesTableAdapter();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intakeSemesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIAS_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adviseeAssignmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adviseeAssignmentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advisingPlansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advisingPlanCoursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentNumber,
            this.FirstName,
            this.LastName,
            this.SpecializationID,
            this.IntakeSemester,
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNumberDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.intakeSemesterDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.specializationIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(48, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(781, 71);
            this.dataGridView1.TabIndex = 0;
            // 
            // StudentNumber
            // 
            this.StudentNumber.DataPropertyName = "StudentNumber";
            this.StudentNumber.HeaderText = "StudentNumber";
            this.StudentNumber.MinimumWidth = 6;
            this.StudentNumber.Name = "StudentNumber";
            this.StudentNumber.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // SpecializationID
            // 
            this.SpecializationID.DataPropertyName = "SpecializationID";
            this.SpecializationID.HeaderText = "SpecializationID";
            this.SpecializationID.MinimumWidth = 6;
            this.SpecializationID.Name = "SpecializationID";
            this.SpecializationID.Width = 125;
            // 
            // IntakeSemester
            // 
            this.IntakeSemester.DataPropertyName = "IntakeSemester";
            this.IntakeSemester.HeaderText = "IntakeSemester";
            this.IntakeSemester.MinimumWidth = 6;
            this.IntakeSemester.Name = "IntakeSemester";
            this.IntakeSemester.Width = 125;
            // 
            // studentsBindingSource1
            // 
            this.studentsBindingSource1.DataMember = "Students";
            this.studentsBindingSource1.DataSource = this.sCIAS_DBDataSet;
            // 
            // sCIAS_DBDataSet
            // 
            this.sCIAS_DBDataSet.DataSetName = "SCIAS_DBDataSet";
            this.sCIAS_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.sCIAS_DBDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // adviseeAssignmentsBindingSource
            // 
            this.adviseeAssignmentsBindingSource.DataMember = "Advisee_Assignments";
            this.adviseeAssignmentsBindingSource.DataSource = this.sCIAS_DBDataSet;
            // 
            // advisee_AssignmentsTableAdapter
            // 
            this.advisee_AssignmentsTableAdapter.ClearBeforeFill = true;
            // 
            // adviseeAssignmentsBindingSource1
            // 
            this.adviseeAssignmentsBindingSource1.DataMember = "Advisee_Assignments";
            this.adviseeAssignmentsBindingSource1.DataSource = this.sCIAS_DBDataSet;
            // 
            // dgvPlan
            // 
            this.dgvPlan.AutoGenerateColumns = false;
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CreatedDate,
            this.SemesterID,
            this.dataGridViewTextBoxColumn1});
            this.dgvPlan.DataSource = this.advisingPlansBindingSource;
            this.dgvPlan.Location = new System.Drawing.Point(48, 205);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.RowHeadersWidth = 51;
            this.dgvPlan.RowTemplate.Height = 24;
            this.dgvPlan.Size = new System.Drawing.Size(428, 50);
            this.dgvPlan.TabIndex = 2;
            // 
            // CreatedDate
            // 
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.HeaderText = "CreatedDate";
            this.CreatedDate.MinimumWidth = 6;
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.Width = 125;
            // 
            // SemesterID
            // 
            this.SemesterID.DataPropertyName = "SemesterID";
            this.SemesterID.HeaderText = "SemesterID";
            this.SemesterID.MinimumWidth = 6;
            this.SemesterID.Name = "SemesterID";
            this.SemesterID.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn1.HeaderText = "Status";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // advisingPlansBindingSource
            // 
            this.advisingPlansBindingSource.DataMember = "Advising_Plans";
            this.advisingPlansBindingSource.DataSource = this.sCIAS_DBDataSet;
            // 
            // studentsBindingSource2
            // 
            this.studentsBindingSource2.DataMember = "Students";
            this.studentsBindingSource2.DataSource = this.sCIAS_DBDataSet;
            // 
            // advisingPlanCoursesBindingSource
            // 
            this.advisingPlanCoursesBindingSource.DataMember = "Advising_Plan_Courses";
            this.advisingPlanCoursesBindingSource.DataSource = this.sCIAS_DBDataSet;
            // 
            // advising_Plan_CoursesTableAdapter
            // 
            this.advising_Plan_CoursesTableAdapter.ClearBeforeFill = true;
            // 
            // advising_PlansTableAdapter
            // 
            this.advising_PlansTableAdapter.ClearBeforeFill = true;
            // 
            // dgvCourses
            // 
            this.dgvCourses.AutoGenerateColumns = false;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseCodeDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn,
            this.creditHoursDataGridViewTextBoxColumn,
            this.courseTypeDataGridViewTextBoxColumn});
            this.dgvCourses.DataSource = this.coursesBindingSource;
            this.dgvCourses.Location = new System.Drawing.Point(48, 313);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowHeadersWidth = 51;
            this.dgvCourses.RowTemplate.Height = 24;
            this.dgvCourses.Size = new System.Drawing.Size(553, 49);
            this.dgvCourses.TabIndex = 3;
            // 
            // courseCodeDataGridViewTextBoxColumn
            // 
            this.courseCodeDataGridViewTextBoxColumn.DataPropertyName = "CourseCode";
            this.courseCodeDataGridViewTextBoxColumn.HeaderText = "CourseCode";
            this.courseCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseCodeDataGridViewTextBoxColumn.Name = "courseCodeDataGridViewTextBoxColumn";
            this.courseCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // creditHoursDataGridViewTextBoxColumn
            // 
            this.creditHoursDataGridViewTextBoxColumn.DataPropertyName = "CreditHours";
            this.creditHoursDataGridViewTextBoxColumn.HeaderText = "CreditHours";
            this.creditHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creditHoursDataGridViewTextBoxColumn.Name = "creditHoursDataGridViewTextBoxColumn";
            this.creditHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // courseTypeDataGridViewTextBoxColumn
            // 
            this.courseTypeDataGridViewTextBoxColumn.DataPropertyName = "CourseType";
            this.courseTypeDataGridViewTextBoxColumn.HeaderText = "CourseType";
            this.courseTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseTypeDataGridViewTextBoxColumn.Name = "courseTypeDataGridViewTextBoxColumn";
            this.courseTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.sCIAS_DBDataSet;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnApprove.ForeColor = System.Drawing.Color.Transparent;
            this.btnApprove.Location = new System.Drawing.Point(889, 101);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(161, 36);
            this.btnApprove.TabIndex = 4;
            this.btnApprove.Text = "Approve Plan ";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnReject.ForeColor = System.Drawing.Color.Transparent;
            this.btnReject.Location = new System.Drawing.Point(889, 219);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(161, 36);
            this.btnReject.TabIndex = 5;
            this.btnReject.Text = "Reject Plan ";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnModify.ForeColor = System.Drawing.Color.Transparent;
            this.btnModify.Location = new System.Drawing.Point(889, 157);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(161, 36);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "Modify Plan ";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(889, 282);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 36);
            this.button5.TabIndex = 8;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentNumberDataGridViewTextBoxColumn
            // 
            this.studentNumberDataGridViewTextBoxColumn.DataPropertyName = "StudentNumber";
            this.studentNumberDataGridViewTextBoxColumn.HeaderText = "StudentNumber";
            this.studentNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNumberDataGridViewTextBoxColumn.Name = "studentNumberDataGridViewTextBoxColumn";
            this.studentNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // intakeSemesterDataGridViewTextBoxColumn
            // 
            this.intakeSemesterDataGridViewTextBoxColumn.DataPropertyName = "IntakeSemester";
            this.intakeSemesterDataGridViewTextBoxColumn.HeaderText = "IntakeSemester";
            this.intakeSemesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.intakeSemesterDataGridViewTextBoxColumn.Name = "intakeSemesterDataGridViewTextBoxColumn";
            this.intakeSemesterDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // specializationIDDataGridViewTextBoxColumn
            // 
            this.specializationIDDataGridViewTextBoxColumn.DataPropertyName = "SpecializationID";
            this.specializationIDDataGridViewTextBoxColumn.HeaderText = "SpecializationID";
            this.specializationIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specializationIDDataGridViewTextBoxColumn.Name = "specializationIDDataGridViewTextBoxColumn";
            this.specializationIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // AdviserStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1087, 463);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.dgvCourses);
            this.Controls.Add(this.dgvPlan);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdviserStudentsForm";
            this.Text = "AdviserStudentsForm";
            this.Load += new System.EventHandler(this.AdviserStudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIAS_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adviseeAssignmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adviseeAssignmentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advisingPlansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advisingPlanCoursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SCIAS_DBDataSet sCIAS_DBDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private SCIAS_DBDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource adviseeAssignmentsBindingSource;
        private SCIAS_DBDataSetTableAdapters.Advisee_AssignmentsTableAdapter advisee_AssignmentsTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource1;
        private System.Windows.Forms.BindingSource adviseeAssignmentsBindingSource1;
        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.BindingSource studentsBindingSource2;
        private System.Windows.Forms.BindingSource advisingPlanCoursesBindingSource;
        private SCIAS_DBDataSetTableAdapters.Advising_Plan_CoursesTableAdapter advising_Plan_CoursesTableAdapter;
        private System.Windows.Forms.BindingSource advisingPlansBindingSource;
        private SCIAS_DBDataSetTableAdapters.Advising_PlansTableAdapter advising_PlansTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SemesterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private SCIAS_DBDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecializationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntakeSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intakeSemesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationIDDataGridViewTextBoxColumn;
    }
}