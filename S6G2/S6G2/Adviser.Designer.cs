namespace S6G2
{
    partial class Adviser
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
            this.label1 = new System.Windows.Forms.Label();
            this.sCIAS_DBDataSet = new S6G2.SCIAS_DBDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new S6G2.SCIAS_DBDataSetTableAdapters.StudentsTableAdapter();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intakeSemesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAcademicRecord = new System.Windows.Forms.Button();
            this.btnRecommendCourse = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProgressReport = new System.Windows.Forms.Button();
            this.btnViewPlan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sCIAS_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(263, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Adviser";
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
            // dgvStudents
            // 
            this.dgvStudents.AutoGenerateColumns = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.studentNumberDataGridViewTextBoxColumn,
            this.intakeSemesterDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvStudents.DataSource = this.studentsBindingSource1;
            this.dgvStudents.Location = new System.Drawing.Point(63, 157);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(675, 70);
            this.dgvStudents.TabIndex = 1;
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
            // studentNumberDataGridViewTextBoxColumn
            // 
            this.studentNumberDataGridViewTextBoxColumn.DataPropertyName = "StudentNumber";
            this.studentNumberDataGridViewTextBoxColumn.HeaderText = "StudentNumber";
            this.studentNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNumberDataGridViewTextBoxColumn.Name = "studentNumberDataGridViewTextBoxColumn";
            this.studentNumberDataGridViewTextBoxColumn.Width = 125;
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
            // studentsBindingSource1
            // 
            this.studentsBindingSource1.DataMember = "Students";
            this.studentsBindingSource1.DataSource = this.sCIAS_DBDataSet;
            // 
            // btnAcademicRecord
            // 
            this.btnAcademicRecord.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAcademicRecord.ForeColor = System.Drawing.Color.Transparent;
            this.btnAcademicRecord.Location = new System.Drawing.Point(172, 268);
            this.btnAcademicRecord.Name = "btnAcademicRecord";
            this.btnAcademicRecord.Size = new System.Drawing.Size(167, 35);
            this.btnAcademicRecord.TabIndex = 2;
            this.btnAcademicRecord.Text = "View Academic Record";
            this.btnAcademicRecord.UseVisualStyleBackColor = false;
            this.btnAcademicRecord.Click += new System.EventHandler(this.btnAcademicRecord_Click);
            // 
            // btnRecommendCourse
            // 
            this.btnRecommendCourse.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRecommendCourse.ForeColor = System.Drawing.Color.Transparent;
            this.btnRecommendCourse.Location = new System.Drawing.Point(432, 319);
            this.btnRecommendCourse.Name = "btnRecommendCourse";
            this.btnRecommendCourse.Size = new System.Drawing.Size(167, 35);
            this.btnRecommendCourse.TabIndex = 3;
            this.btnRecommendCourse.Text = "Recommend Courses";
            this.btnRecommendCourse.UseVisualStyleBackColor = false;
            this.btnRecommendCourse.Click += new System.EventHandler(this.btnRecommendCourse_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogout.Location = new System.Drawing.Point(346, 379);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 36);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = " Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProgressReport
            // 
            this.btnProgressReport.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnProgressReport.ForeColor = System.Drawing.Color.Transparent;
            this.btnProgressReport.Location = new System.Drawing.Point(172, 319);
            this.btnProgressReport.Name = "btnProgressReport";
            this.btnProgressReport.Size = new System.Drawing.Size(167, 35);
            this.btnProgressReport.TabIndex = 6;
            this.btnProgressReport.Text = "Progress Report";
            this.btnProgressReport.UseVisualStyleBackColor = false;
            this.btnProgressReport.Click += new System.EventHandler(this.btnProgressReport_Click);
            // 
            // btnViewPlan
            // 
            this.btnViewPlan.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnViewPlan.ForeColor = System.Drawing.Color.Transparent;
            this.btnViewPlan.Location = new System.Drawing.Point(432, 268);
            this.btnViewPlan.Name = "btnViewPlan";
            this.btnViewPlan.Size = new System.Drawing.Size(167, 35);
            this.btnViewPlan.TabIndex = 4;
            this.btnViewPlan.Text = "View Student Plan";
            this.btnViewPlan.UseVisualStyleBackColor = false;
            this.btnViewPlan.Click += new System.EventHandler(this.btnViewPlan_Click);
            // 
            // Adviser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProgressReport);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewPlan);
            this.Controls.Add(this.btnRecommendCourse);
            this.Controls.Add(this.btnAcademicRecord);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.label1);
            this.Name = "Adviser";
            this.Text = "Adviser";
            this.Load += new System.EventHandler(this.Adviser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sCIAS_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intakeSemesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentsBindingSource1;
        private System.Windows.Forms.Button btnAcademicRecord;
        private System.Windows.Forms.Button btnRecommendCourse;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProgressReport;
        private System.Windows.Forms.Button btnViewPlan;
        private S6G2.SCIAS_DBDataSet sCIAS_DBDataSet;
        private S6G2.SCIAS_DBDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
    }
}