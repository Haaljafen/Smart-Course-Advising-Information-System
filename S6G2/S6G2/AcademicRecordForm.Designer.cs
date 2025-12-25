namespace S6G2
{
    partial class AcademicRecordForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.dgvAcademicHistory = new System.Windows.Forms.DataGridView();
            this.studentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sCIAS_DBDataSet = new S6G2.SCIAS_DBDataSet();
            this.advisingPlanCoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advising_Plan_CoursesTableAdapter = new S6G2.SCIAS_DBDataSetTableAdapters.Advising_Plan_CoursesTableAdapter();
            this.courseOfferingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.course_OfferingsTableAdapter = new S6G2.SCIAS_DBDataSetTableAdapters.Course_OfferingsTableAdapter();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new S6G2.SCIAS_DBDataSetTableAdapters.CoursesTableAdapter();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new S6G2.SCIAS_DBDataSetTableAdapters.StudentsTableAdapter();
            this.adviseeAssignmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advisee_AssignmentsTableAdapter = new S6G2.SCIAS_DBDataSetTableAdapters.Advisee_AssignmentsTableAdapter();
            this.semestersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.semestersTableAdapter = new S6G2.SCIAS_DBDataSetTableAdapters.SemestersTableAdapter();
            this.enrollmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrollmentsTableAdapter = new S6G2.SCIAS_DBDataSetTableAdapters.EnrollmentsTableAdapter();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfferingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademicHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIAS_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advisingPlanCoursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseOfferingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adviseeAssignmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semestersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(245, 60);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Academic Record ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(212, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Name:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblStudentName.Location = new System.Drawing.Point(446, 132);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(48, 16);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "(value)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(212, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Number:";
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblStudentNumber.Location = new System.Drawing.Point(446, 168);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(48, 16);
            this.lblStudentNumber.TabIndex = 4;
            this.lblStudentNumber.Text = "(value)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(213, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Specialization:";
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblSpecialization.Location = new System.Drawing.Point(446, 205);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(48, 16);
            this.lblSpecialization.TabIndex = 6;
            this.lblSpecialization.Text = "(value)";
            // 
            // dgvAcademicHistory
            // 
            this.dgvAcademicHistory.AutoGenerateColumns = false;
            this.dgvAcademicHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcademicHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.studentIDDataGridViewTextBoxColumn,
            this.OfferingID,
            this.statusDataGridViewTextBoxColumn,
            this.Grade});
            this.dgvAcademicHistory.DataSource = this.enrollmentsBindingSource;
            this.dgvAcademicHistory.Location = new System.Drawing.Point(55, 292);
            this.dgvAcademicHistory.Name = "dgvAcademicHistory";
            this.dgvAcademicHistory.RowHeadersWidth = 51;
            this.dgvAcademicHistory.RowTemplate.Height = 24;
            this.dgvAcademicHistory.Size = new System.Drawing.Size(679, 50);
            this.dgvAcademicHistory.TabIndex = 7;
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
            // advisingPlanCoursesBindingSource
            // 
            this.advisingPlanCoursesBindingSource.DataMember = "Advising_Plan_Courses";
            this.advisingPlanCoursesBindingSource.DataSource = this.sCIAS_DBDataSet;
            // 
            // advising_Plan_CoursesTableAdapter
            // 
            this.advising_Plan_CoursesTableAdapter.ClearBeforeFill = true;
            // 
            // courseOfferingsBindingSource
            // 
            this.courseOfferingsBindingSource.DataMember = "Course_Offerings";
            this.courseOfferingsBindingSource.DataSource = this.sCIAS_DBDataSet;
            // 
            // course_OfferingsTableAdapter
            // 
            this.course_OfferingsTableAdapter.ClearBeforeFill = true;
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
            // semestersBindingSource
            // 
            this.semestersBindingSource.DataMember = "Semesters";
            this.semestersBindingSource.DataSource = this.sCIAS_DBDataSet;
            // 
            // semestersTableAdapter
            // 
            this.semestersTableAdapter.ClearBeforeFill = true;
            // 
            // enrollmentsBindingSource
            // 
            this.enrollmentsBindingSource.DataMember = "Enrollments";
            this.enrollmentsBindingSource.DataSource = this.sCIAS_DBDataSet;
            // 
            // enrollmentsTableAdapter
            // 
            this.enrollmentsTableAdapter.ClearBeforeFill = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "EnrollmenTID";
            this.Column2.HeaderText = "EnrollmentID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // OfferingID
            // 
            this.OfferingID.DataPropertyName = "OfferingID";
            this.OfferingID.HeaderText = "OfferingID";
            this.OfferingID.MinimumWidth = 6;
            this.OfferingID.Name = "OfferingID";
            this.OfferingID.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "Grade";
            this.Grade.HeaderText = "Grade";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.Width = 125;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(334, 402);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 39);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // AcademicRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvAcademicHistory);
            this.Controls.Add(this.lblSpecialization);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStudentNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "AcademicRecordForm";
            this.Text = "AcademicRecordForm";
            this.Load += new System.EventHandler(this.AcademicRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademicHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIAS_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advisingPlanCoursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseOfferingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adviseeAssignmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semestersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.DataGridView dgvAcademicHistory;
        private System.Windows.Forms.BindingSource advisingPlanCoursesBindingSource;
        private System.Windows.Forms.BindingSource courseOfferingsBindingSource;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.BindingSource adviseeAssignmentsBindingSource;
        private System.Windows.Forms.BindingSource semestersBindingSource;
        private S6G2.SCIAS_DBDataSet sCIAS_DBDataSet;
        private S6G2.SCIAS_DBDataSetTableAdapters.Advising_Plan_CoursesTableAdapter advising_Plan_CoursesTableAdapter;
        private S6G2.SCIAS_DBDataSetTableAdapters.Course_OfferingsTableAdapter course_OfferingsTableAdapter;
        private S6G2.SCIAS_DBDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private S6G2.SCIAS_DBDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private S6G2.SCIAS_DBDataSetTableAdapters.Advisee_AssignmentsTableAdapter advisee_AssignmentsTableAdapter;
        private S6G2.SCIAS_DBDataSetTableAdapters.SemestersTableAdapter semestersTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource1;
        private System.Windows.Forms.BindingSource enrollmentsBindingSource;
        private SCIAS_DBDataSetTableAdapters.EnrollmentsTableAdapter enrollmentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfferingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.Button btnBack;
    }
}