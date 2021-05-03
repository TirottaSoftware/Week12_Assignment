
namespace Workshop_Management
{
    partial class Dashboard
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
            this.lbxPeople = new System.Windows.Forms.ListBox();
            this.cbxSortPeople = new System.Windows.Forms.ComboBox();
            this.lblSortPeople = new System.Windows.Forms.Label();
            this.lblPeopleTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSortWorkshops = new System.Windows.Forms.Label();
            this.cbxSortWorkshops = new System.Windows.Forms.ComboBox();
            this.lbxWorkshops = new System.Windows.Forms.ListBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.lblWorkshopsTitle = new System.Windows.Forms.Label();
            this.btnEditWorkshop = new System.Windows.Forms.Button();
            this.btnAddWorkshop = new System.Windows.Forms.Button();
            this.btnRemoveWorkshop = new System.Windows.Forms.Button();
            this.btnEditPerson = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnRemovePerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxPeople
            // 
            this.lbxPeople.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPeople.FormattingEnabled = true;
            this.lbxPeople.ItemHeight = 22;
            this.lbxPeople.Location = new System.Drawing.Point(12, 74);
            this.lbxPeople.Name = "lbxPeople";
            this.lbxPeople.Size = new System.Drawing.Size(241, 312);
            this.lbxPeople.TabIndex = 0;
            this.lbxPeople.DoubleClick += new System.EventHandler(this.lbxPeople_DoubleClick);
            // 
            // cbxSortPeople
            // 
            this.cbxSortPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSortPeople.FormattingEnabled = true;
            this.cbxSortPeople.Location = new System.Drawing.Point(94, 44);
            this.cbxSortPeople.Name = "cbxSortPeople";
            this.cbxSortPeople.Size = new System.Drawing.Size(159, 24);
            this.cbxSortPeople.TabIndex = 1;
            // 
            // lblSortPeople
            // 
            this.lblSortPeople.AutoSize = true;
            this.lblSortPeople.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortPeople.Location = new System.Drawing.Point(8, 44);
            this.lblSortPeople.Name = "lblSortPeople";
            this.lblSortPeople.Size = new System.Drawing.Size(76, 22);
            this.lblSortPeople.TabIndex = 2;
            this.lblSortPeople.Text = "Sort By:";
            // 
            // lblPeopleTitle
            // 
            this.lblPeopleTitle.AutoSize = true;
            this.lblPeopleTitle.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleTitle.Location = new System.Drawing.Point(89, 5);
            this.lblPeopleTitle.Name = "lblPeopleTitle";
            this.lblPeopleTitle.Size = new System.Drawing.Size(86, 26);
            this.lblPeopleTitle.TabIndex = 3;
            this.lblPeopleTitle.Text = "People";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-148, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(807, 2);
            this.label1.TabIndex = 2;
            // 
            // lblSortWorkshops
            // 
            this.lblSortWorkshops.AutoSize = true;
            this.lblSortWorkshops.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortWorkshops.Location = new System.Drawing.Point(397, 44);
            this.lblSortWorkshops.Name = "lblSortWorkshops";
            this.lblSortWorkshops.Size = new System.Drawing.Size(76, 22);
            this.lblSortWorkshops.TabIndex = 9;
            this.lblSortWorkshops.Text = "Sort By:";
            // 
            // cbxSortWorkshops
            // 
            this.cbxSortWorkshops.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSortWorkshops.FormattingEnabled = true;
            this.cbxSortWorkshops.Location = new System.Drawing.Point(483, 44);
            this.cbxSortWorkshops.Name = "cbxSortWorkshops";
            this.cbxSortWorkshops.Size = new System.Drawing.Size(159, 24);
            this.cbxSortWorkshops.TabIndex = 8;
            // 
            // lbxWorkshops
            // 
            this.lbxWorkshops.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxWorkshops.FormattingEnabled = true;
            this.lbxWorkshops.ItemHeight = 22;
            this.lbxWorkshops.Location = new System.Drawing.Point(401, 74);
            this.lbxWorkshops.Name = "lbxWorkshops";
            this.lbxWorkshops.Size = new System.Drawing.Size(241, 312);
            this.lbxWorkshops.TabIndex = 7;
            this.lbxWorkshops.DoubleClick += new System.EventHandler(this.lbxWorkshops_DoubleClick);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(8, 44);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(76, 22);
            this.lblSort.TabIndex = 2;
            this.lblSort.Text = "Sort By:";
            // 
            // lblWorkshopsTitle
            // 
            this.lblWorkshopsTitle.AutoSize = true;
            this.lblWorkshopsTitle.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkshopsTitle.Location = new System.Drawing.Point(467, 5);
            this.lblWorkshopsTitle.Name = "lblWorkshopsTitle";
            this.lblWorkshopsTitle.Size = new System.Drawing.Size(128, 26);
            this.lblWorkshopsTitle.TabIndex = 13;
            this.lblWorkshopsTitle.Text = "Workshops";
            // 
            // btnEditWorkshop
            // 
            this.btnEditWorkshop.BackColor = System.Drawing.Color.Transparent;
            this.btnEditWorkshop.BackgroundImage = global::Workshop_Management.Properties.Resources.pencil;
            this.btnEditWorkshop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditWorkshop.FlatAppearance.BorderSize = 0;
            this.btnEditWorkshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditWorkshop.Location = new System.Drawing.Point(359, 156);
            this.btnEditWorkshop.Name = "btnEditWorkshop";
            this.btnEditWorkshop.Size = new System.Drawing.Size(36, 35);
            this.btnEditWorkshop.TabIndex = 12;
            this.btnEditWorkshop.UseVisualStyleBackColor = false;
            this.btnEditWorkshop.Click += new System.EventHandler(this.btnEditWorkshop_Click);
            // 
            // btnAddWorkshop
            // 
            this.btnAddWorkshop.BackColor = System.Drawing.Color.Transparent;
            this.btnAddWorkshop.BackgroundImage = global::Workshop_Management.Properties.Resources.plus;
            this.btnAddWorkshop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddWorkshop.FlatAppearance.BorderSize = 0;
            this.btnAddWorkshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWorkshop.Location = new System.Drawing.Point(359, 74);
            this.btnAddWorkshop.Name = "btnAddWorkshop";
            this.btnAddWorkshop.Size = new System.Drawing.Size(36, 35);
            this.btnAddWorkshop.TabIndex = 11;
            this.btnAddWorkshop.UseVisualStyleBackColor = false;
            this.btnAddWorkshop.Click += new System.EventHandler(this.btnAddWorkshop_Click);
            // 
            // btnRemoveWorkshop
            // 
            this.btnRemoveWorkshop.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveWorkshop.BackgroundImage = global::Workshop_Management.Properties.Resources.remove;
            this.btnRemoveWorkshop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveWorkshop.FlatAppearance.BorderSize = 0;
            this.btnRemoveWorkshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveWorkshop.Location = new System.Drawing.Point(359, 115);
            this.btnRemoveWorkshop.Name = "btnRemoveWorkshop";
            this.btnRemoveWorkshop.Size = new System.Drawing.Size(36, 35);
            this.btnRemoveWorkshop.TabIndex = 10;
            this.btnRemoveWorkshop.UseVisualStyleBackColor = false;
            this.btnRemoveWorkshop.Click += new System.EventHandler(this.btnRemoveWorkshop_Click);
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnEditPerson.BackgroundImage = global::Workshop_Management.Properties.Resources.pencil;
            this.btnEditPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditPerson.FlatAppearance.BorderSize = 0;
            this.btnEditPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPerson.Location = new System.Drawing.Point(259, 156);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(36, 35);
            this.btnEditPerson.TabIndex = 6;
            this.btnEditPerson.UseVisualStyleBackColor = false;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPerson.BackgroundImage = global::Workshop_Management.Properties.Resources.plus;
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPerson.FlatAppearance.BorderSize = 0;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Location = new System.Drawing.Point(259, 74);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(36, 35);
            this.btnAddPerson.TabIndex = 5;
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnRemovePerson
            // 
            this.btnRemovePerson.BackColor = System.Drawing.Color.Transparent;
            this.btnRemovePerson.BackgroundImage = global::Workshop_Management.Properties.Resources.remove;
            this.btnRemovePerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemovePerson.FlatAppearance.BorderSize = 0;
            this.btnRemovePerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePerson.Location = new System.Drawing.Point(259, 115);
            this.btnRemovePerson.Name = "btnRemovePerson";
            this.btnRemovePerson.Size = new System.Drawing.Size(36, 35);
            this.btnRemovePerson.TabIndex = 4;
            this.btnRemovePerson.UseVisualStyleBackColor = false;
            this.btnRemovePerson.Click += new System.EventHandler(this.btnRemovePerson_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(654, 398);
            this.Controls.Add(this.lblWorkshopsTitle);
            this.Controls.Add(this.btnEditWorkshop);
            this.Controls.Add(this.btnAddWorkshop);
            this.Controls.Add(this.btnRemoveWorkshop);
            this.Controls.Add(this.lblSortWorkshops);
            this.Controls.Add(this.cbxSortWorkshops);
            this.Controls.Add(this.lbxWorkshops);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditPerson);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.btnRemovePerson);
            this.Controls.Add(this.lblPeopleTitle);
            this.Controls.Add(this.lblSortPeople);
            this.Controls.Add(this.cbxSortPeople);
            this.Controls.Add(this.lbxPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.Text = "Workshop Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxPeople;
        private System.Windows.Forms.ComboBox cbxSortPeople;
        private System.Windows.Forms.Label lblSortPeople;
        private System.Windows.Forms.Label lblPeopleTitle;
        private System.Windows.Forms.Button btnRemovePerson;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnEditPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditWorkshop;
        private System.Windows.Forms.Button btnAddWorkshop;
        private System.Windows.Forms.Button btnRemoveWorkshop;
        private System.Windows.Forms.Label lblSortWorkshops;
        private System.Windows.Forms.ComboBox cbxSortWorkshops;
        private System.Windows.Forms.ListBox lbxWorkshops;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Label lblWorkshopsTitle;
    }
}

