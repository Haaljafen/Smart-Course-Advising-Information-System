
namespace S6G2
{
    partial class frmStudentDashboard
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnApprovedPlan = new System.Windows.Forms.Button();
            this.btnSubmitPlan = new System.Windows.Forms.Button();
            this.btnEligibleCourses = new System.Windows.Forms.Button();
            this.btnAcademicRecord = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelCard = new System.Windows.Forms.Panel();
            this.pnlAcademicRecord = new System.Windows.Forms.Panel();
            this.pnlEligibleCourses = new System.Windows.Forms.Panel();
            this.pnlSubmitPlan = new System.Windows.Forms.Panel();
            this.pnlApproved = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.dgvEligible = new System.Windows.Forms.DataGridView();
            this.dgvApproved = new System.Windows.Forms.DataGridView();
            this.pnlSubmitPlanData = new System.Windows.Forms.Panel();
            this.dgvSelect = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.pnlAcademicRecord.SuspendLayout();
            this.pnlEligibleCourses.SuspendLayout();
            this.pnlSubmitPlan.SuspendLayout();
            this.pnlApproved.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEligible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApproved)).BeginInit();
            this.pnlSubmitPlanData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelHeader.Controls.Add(this.lblSub);
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.ForeColor = System.Drawing.Color.Gray;
            this.lblSub.Location = new System.Drawing.Point(20, 45);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(113, 15);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Student Dashboard";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(156, 20);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Student";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.White;
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.lblMenu);
            this.panelSidebar.Controls.Add(this.btnApprovedPlan);
            this.panelSidebar.Controls.Add(this.btnSubmitPlan);
            this.panelSidebar.Controls.Add(this.btnEligibleCourses);
            this.panelSidebar.Controls.Add(this.btnAcademicRecord);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 70);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(210, 380);
            this.panelSidebar.TabIndex = 1;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.Gray;
            this.lblMenu.Location = new System.Drawing.Point(20, 15);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(48, 15);
            this.lblMenu.TabIndex = 4;
            this.lblMenu.Text = "MENU";
            // 
            // btnApprovedPlan
            // 
            this.btnApprovedPlan.FlatAppearance.BorderSize = 0;
            this.btnApprovedPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprovedPlan.Location = new System.Drawing.Point(20, 190);
            this.btnApprovedPlan.Name = "btnApprovedPlan";
            this.btnApprovedPlan.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnApprovedPlan.Size = new System.Drawing.Size(170, 45);
            this.btnApprovedPlan.TabIndex = 3;
            this.btnApprovedPlan.Text = "Approved / Remarks";
            this.btnApprovedPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApprovedPlan.UseVisualStyleBackColor = true;
            // 
            // btnSubmitPlan
            // 
            this.btnSubmitPlan.FlatAppearance.BorderSize = 0;
            this.btnSubmitPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitPlan.Location = new System.Drawing.Point(20, 140);
            this.btnSubmitPlan.Name = "btnSubmitPlan";
            this.btnSubmitPlan.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnSubmitPlan.Size = new System.Drawing.Size(170, 45);
            this.btnSubmitPlan.TabIndex = 2;
            this.btnSubmitPlan.Text = "Submit Plan";
            this.btnSubmitPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmitPlan.UseVisualStyleBackColor = true;
            // 
            // btnEligibleCourses
            // 
            this.btnEligibleCourses.FlatAppearance.BorderSize = 0;
            this.btnEligibleCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEligibleCourses.Location = new System.Drawing.Point(20, 90);
            this.btnEligibleCourses.Name = "btnEligibleCourses";
            this.btnEligibleCourses.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnEligibleCourses.Size = new System.Drawing.Size(170, 45);
            this.btnEligibleCourses.TabIndex = 1;
            this.btnEligibleCourses.Text = "Eligible Courses";
            this.btnEligibleCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEligibleCourses.UseVisualStyleBackColor = true;
            // 
            // btnAcademicRecord
            // 
            this.btnAcademicRecord.FlatAppearance.BorderSize = 0;
            this.btnAcademicRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcademicRecord.Location = new System.Drawing.Point(20, 40);
            this.btnAcademicRecord.Name = "btnAcademicRecord";
            this.btnAcademicRecord.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnAcademicRecord.Size = new System.Drawing.Size(170, 45);
            this.btnAcademicRecord.TabIndex = 0;
            this.btnAcademicRecord.Text = "Academic Record";
            this.btnAcademicRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcademicRecord.UseVisualStyleBackColor = true;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContent.Controls.Add(this.panelCard);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(210, 70);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(590, 380);
            this.panelContent.TabIndex = 2;
            // 
            // panelCard
            // 
            this.panelCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.pnlSubmitPlan);
            this.panelCard.Controls.Add(this.pnlApproved);
            this.panelCard.Controls.Add(this.pnlEligibleCourses);
            this.panelCard.Controls.Add(this.pnlAcademicRecord);
            this.panelCard.Location = new System.Drawing.Point(20, 20);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(550, 340);
            this.panelCard.TabIndex = 0;
            // 
            // pnlAcademicRecord
            // 
            this.pnlAcademicRecord.BackColor = System.Drawing.Color.Red;
            this.pnlAcademicRecord.Controls.Add(this.dgvRecord);
            this.pnlAcademicRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAcademicRecord.Location = new System.Drawing.Point(0, 0);
            this.pnlAcademicRecord.Name = "pnlAcademicRecord";
            this.pnlAcademicRecord.Size = new System.Drawing.Size(548, 338);
            this.pnlAcademicRecord.TabIndex = 0;
            // 
            // pnlEligibleCourses
            // 
            this.pnlEligibleCourses.BackColor = System.Drawing.Color.IndianRed;
            this.pnlEligibleCourses.Controls.Add(this.dgvEligible);
            this.pnlEligibleCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEligibleCourses.Location = new System.Drawing.Point(0, 0);
            this.pnlEligibleCourses.Name = "pnlEligibleCourses";
            this.pnlEligibleCourses.Size = new System.Drawing.Size(548, 338);
            this.pnlEligibleCourses.TabIndex = 0;
            // 
            // pnlSubmitPlan
            // 
            this.pnlSubmitPlan.BackColor = System.Drawing.Color.White;
            this.pnlSubmitPlan.Controls.Add(this.btnSubmit);
            this.pnlSubmitPlan.Controls.Add(this.pnlSubmitPlanData);
            this.pnlSubmitPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSubmitPlan.Location = new System.Drawing.Point(0, 0);
            this.pnlSubmitPlan.Name = "pnlSubmitPlan";
            this.pnlSubmitPlan.Size = new System.Drawing.Size(548, 338);
            this.pnlSubmitPlan.TabIndex = 0;
            // 
            // pnlApproved
            // 
            this.pnlApproved.BackColor = System.Drawing.Color.Black;
            this.pnlApproved.Controls.Add(this.dgvApproved);
            this.pnlApproved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlApproved.Location = new System.Drawing.Point(0, 0);
            this.pnlApproved.Name = "pnlApproved";
            this.pnlApproved.Size = new System.Drawing.Size(548, 338);
            this.pnlApproved.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(20, 282);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(156, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // dgvRecord
            // 
            this.dgvRecord.AllowUserToAddRows = false;
            this.dgvRecord.AllowUserToDeleteRows = false;
            this.dgvRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecord.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecord.Location = new System.Drawing.Point(0, 0);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.ReadOnly = true;
            this.dgvRecord.RowHeadersVisible = false;
            this.dgvRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecord.Size = new System.Drawing.Size(548, 338);
            this.dgvRecord.TabIndex = 0;
            // 
            // dgvEligible
            // 
            this.dgvEligible.BackgroundColor = System.Drawing.Color.White;
            this.dgvEligible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEligible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEligible.Location = new System.Drawing.Point(0, 0);
            this.dgvEligible.Name = "dgvEligible";
            this.dgvEligible.Size = new System.Drawing.Size(548, 338);
            this.dgvEligible.TabIndex = 1;
            // 
            // dgvApproved
            // 
            this.dgvApproved.BackgroundColor = System.Drawing.Color.White;
            this.dgvApproved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApproved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvApproved.Location = new System.Drawing.Point(0, 0);
            this.dgvApproved.Name = "dgvApproved";
            this.dgvApproved.Size = new System.Drawing.Size(548, 338);
            this.dgvApproved.TabIndex = 1;
            // 
            // pnlSubmitPlanData
            // 
            this.pnlSubmitPlanData.BackColor = System.Drawing.Color.White;
            this.pnlSubmitPlanData.Controls.Add(this.dgvSelect);
            this.pnlSubmitPlanData.Location = new System.Drawing.Point(-1, -1);
            this.pnlSubmitPlanData.Name = "pnlSubmitPlanData";
            this.pnlSubmitPlanData.Size = new System.Drawing.Size(567, 307);
            this.pnlSubmitPlanData.TabIndex = 0;
            // 
            // dgvSelect
            // 
            this.dgvSelect.BackgroundColor = System.Drawing.Color.White;
            this.dgvSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelect.Location = new System.Drawing.Point(0, 0);
            this.dgvSelect.Name = "dgvSelect";
            this.dgvSelect.Size = new System.Drawing.Size(567, 307);
            this.dgvSelect.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(470, 312);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // frmStudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmStudentDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Dashboard";
            this.Load += new System.EventHandler(this.frmStudentDashboard_Load_1);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelCard.ResumeLayout(false);
            this.pnlAcademicRecord.ResumeLayout(false);
            this.pnlEligibleCourses.ResumeLayout(false);
            this.pnlSubmitPlan.ResumeLayout(false);
            this.pnlApproved.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEligible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApproved)).EndInit();
            this.pnlSubmitPlanData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnApprovedPlan;
        private System.Windows.Forms.Button btnSubmitPlan;
        private System.Windows.Forms.Button btnEligibleCourses;
        private System.Windows.Forms.Button btnAcademicRecord;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Panel pnlAcademicRecord;
        private System.Windows.Forms.Panel pnlEligibleCourses;
        private System.Windows.Forms.Panel pnlSubmitPlan;
        private System.Windows.Forms.Panel pnlApproved;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.DataGridView dgvEligible;
        private System.Windows.Forms.DataGridView dgvApproved;
        private System.Windows.Forms.Panel pnlSubmitPlanData;
        private System.Windows.Forms.DataGridView dgvSelect;
        private System.Windows.Forms.Button btnSubmit;
    }
}