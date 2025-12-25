namespace S6G2
{
    partial class ProgressReportForm
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
            this.labelCompletedText = new System.Windows.Forms.Label();
            this.labelRemainingText = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCompletedText
            // 
            this.labelCompletedText.AutoSize = true;
            this.labelCompletedText.BackColor = System.Drawing.Color.Transparent;
            this.labelCompletedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompletedText.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelCompletedText.Location = new System.Drawing.Point(203, 121);
            this.labelCompletedText.Name = "labelCompletedText";
            this.labelCompletedText.Size = new System.Drawing.Size(171, 20);
            this.labelCompletedText.TabIndex = 0;
            this.labelCompletedText.Text = "Completed Credits:";
            // 
            // labelRemainingText
            // 
            this.labelRemainingText.AutoSize = true;
            this.labelRemainingText.BackColor = System.Drawing.Color.Transparent;
            this.labelRemainingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemainingText.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelRemainingText.Location = new System.Drawing.Point(204, 168);
            this.labelRemainingText.Name = "labelRemainingText";
            this.labelRemainingText.Size = new System.Drawing.Size(170, 20);
            this.labelRemainingText.TabIndex = 1;
            this.labelRemainingText.Text = "Remaining Credits:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(267, 242);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblCompleted.Location = new System.Drawing.Point(402, 124);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(14, 16);
            this.lblCompleted.TabIndex = 3;
            this.lblCompleted.Text = "0";
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblRemaining.Location = new System.Drawing.Point(405, 170);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(14, 16);
            this.lblRemaining.TabIndex = 4;
            this.lblRemaining.Text = "0";
            // 
            // ProgressReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(657, 390);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.lblCompleted);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelRemainingText);
            this.Controls.Add(this.labelCompletedText);
            this.Name = "ProgressReportForm";
            this.Text = "ProgressReportForm";
            this.Load += new System.EventHandler(this.ProgressReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCompletedText;
        private System.Windows.Forms.Label labelRemainingText;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.Label lblRemaining;
    }
}