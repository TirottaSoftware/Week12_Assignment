
namespace Workshop_Management
{
    partial class PersonInfoForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPCN = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lbxEnrolments = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(89, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 26);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Name Name";
            // 
            // lblPCN
            // 
            this.lblPCN.AutoSize = true;
            this.lblPCN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCN.Location = new System.Drawing.Point(278, 14);
            this.lblPCN.Name = "lblPCN";
            this.lblPCN.Size = new System.Drawing.Size(44, 21);
            this.lblPCN.TabIndex = 15;
            this.lblPCN.Text = "PCN";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(12, 12);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(43, 21);
            this.lblRole.TabIndex = 20;
            this.lblRole.Text = "Role";
            // 
            // lbxEnrolments
            // 
            this.lbxEnrolments.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxEnrolments.FormattingEnabled = true;
            this.lbxEnrolments.ItemHeight = 22;
            this.lbxEnrolments.Location = new System.Drawing.Point(16, 56);
            this.lbxEnrolments.Name = "lbxEnrolments";
            this.lbxEnrolments.Size = new System.Drawing.Size(306, 356);
            this.lbxEnrolments.TabIndex = 21;
            // 
            // PersonInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 424);
            this.Controls.Add(this.lbxEnrolments);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPCN);
            this.Name = "PersonInfoForm";
            this.Text = "PersonInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPCN;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ListBox lbxEnrolments;
    }
}