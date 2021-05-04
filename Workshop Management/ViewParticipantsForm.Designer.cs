
namespace Workshop_Management
{
    partial class ViewParticipantsForm
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
            this.lbxParticipants = new System.Windows.Forms.ListBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.cbxPeople = new System.Windows.Forms.ComboBox();
            this.btnStartWorkshop = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxParticipants
            // 
            this.lbxParticipants.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxParticipants.FormattingEnabled = true;
            this.lbxParticipants.ItemHeight = 22;
            this.lbxParticipants.Location = new System.Drawing.Point(12, 48);
            this.lbxParticipants.Name = "lbxParticipants";
            this.lbxParticipants.Size = new System.Drawing.Size(259, 334);
            this.lbxParticipants.TabIndex = 0;
            this.lbxParticipants.DoubleClick += new System.EventHandler(this.lbxParticipants_DoubleClick);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPerson.BackgroundImage = global::Workshop_Management.Properties.Resources.plus;
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPerson.FlatAppearance.BorderSize = 0;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Location = new System.Drawing.Point(235, 12);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(36, 30);
            this.btnAddPerson.TabIndex = 6;
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // cbxPeople
            // 
            this.cbxPeople.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPeople.FormattingEnabled = true;
            this.cbxPeople.Location = new System.Drawing.Point(12, 12);
            this.cbxPeople.Name = "cbxPeople";
            this.cbxPeople.Size = new System.Drawing.Size(217, 30);
            this.cbxPeople.TabIndex = 7;
            // 
            // btnStartWorkshop
            // 
            this.btnStartWorkshop.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStartWorkshop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStartWorkshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartWorkshop.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartWorkshop.Location = new System.Drawing.Point(102, 393);
            this.btnStartWorkshop.Name = "btnStartWorkshop";
            this.btnStartWorkshop.Size = new System.Drawing.Size(169, 33);
            this.btnStartWorkshop.TabIndex = 59;
            this.btnStartWorkshop.Text = "Start Workshop";
            this.btnStartWorkshop.UseVisualStyleBackColor = false;
            this.btnStartWorkshop.Click += new System.EventHandler(this.btnStartWorkshop_Click);
            // 
            // btnBack
            // 
            this.btnBack.AllowDrop = true;
            this.btnBack.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 393);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 33);
            this.btnBack.TabIndex = 60;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewParticipantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 440);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStartWorkshop);
            this.Controls.Add(this.cbxPeople);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.lbxParticipants);
            this.Name = "ViewParticipantsForm";
            this.Text = "ViewParticipantsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewParticipantsForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxParticipants;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.ComboBox cbxPeople;
        private System.Windows.Forms.Button btnStartWorkshop;
        private System.Windows.Forms.Button btnBack;
    }
}