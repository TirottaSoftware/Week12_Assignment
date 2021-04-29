
namespace Workshop_Management
{
    partial class AddWorkshopForm
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
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.rbInBuilding = new System.Windows.Forms.RadioButton();
            this.rbOnline = new System.Windows.Forms.RadioButton();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.numRoomNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.tbxURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTitle.Location = new System.Drawing.Point(52, 23);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(270, 26);
            this.lblAddTitle.TabIndex = 19;
            this.lblAddTitle.Text = "Create a new Workshop";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(59, 453);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(263, 33);
            this.btnCreate.TabIndex = 18;
            this.btnCreate.Text = "ADD";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // rbInBuilding
            // 
            this.rbInBuilding.AutoSize = true;
            this.rbInBuilding.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInBuilding.Location = new System.Drawing.Point(253, 234);
            this.rbInBuilding.Name = "rbInBuilding";
            this.rbInBuilding.Size = new System.Drawing.Size(107, 25);
            this.rbInBuilding.TabIndex = 17;
            this.rbInBuilding.TabStop = true;
            this.rbInBuilding.Text = "In Building";
            this.rbInBuilding.UseVisualStyleBackColor = true;
            this.rbInBuilding.CheckedChanged += new System.EventHandler(this.rbInBuilding_CheckedChanged);
            // 
            // rbOnline
            // 
            this.rbOnline.AutoSize = true;
            this.rbOnline.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOnline.Location = new System.Drawing.Point(169, 234);
            this.rbOnline.Name = "rbOnline";
            this.rbOnline.Size = new System.Drawing.Size(78, 25);
            this.rbOnline.TabIndex = 16;
            this.rbOnline.TabStop = true;
            this.rbOnline.Text = "Online";
            this.rbOnline.UseVisualStyleBackColor = true;
            this.rbOnline.CheckedChanged += new System.EventHandler(this.rbOnline_CheckedChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(13, 121);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(97, 21);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(15, 73);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 21);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Title";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTitle.Location = new System.Drawing.Point(112, 70);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(248, 27);
            this.tbxTitle.TabIndex = 10;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(112, 121);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(248, 97);
            this.rtbDescription.TabIndex = 20;
            this.rtbDescription.Text = "";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(13, 233);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(84, 21);
            this.lblCapacity.TabIndex = 21;
            this.lblCapacity.Text = "Capacity";
            // 
            // numCapacity
            // 
            this.numCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCapacity.Location = new System.Drawing.Point(112, 233);
            this.numCapacity.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(51, 26);
            this.numCapacity.TabIndex = 22;
            this.numCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(15, 291);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 21);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.Text = "Address";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Enabled = false;
            this.tbxAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.Location = new System.Drawing.Point(139, 288);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(221, 27);
            this.tbxAddress.TabIndex = 23;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(15, 324);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(118, 21);
            this.lblRoomNumber.TabIndex = 26;
            this.lblRoomNumber.Text = "RoomNumber";
            // 
            // numRoomNumber
            // 
            this.numRoomNumber.Enabled = false;
            this.numRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRoomNumber.Location = new System.Drawing.Point(139, 323);
            this.numRoomNumber.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numRoomNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRoomNumber.Name = "numRoomNumber";
            this.numRoomNumber.Size = new System.Drawing.Size(51, 26);
            this.numRoomNumber.TabIndex = 27;
            this.numRoomNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-7, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 2);
            this.label1.TabIndex = 28;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(15, 389);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(38, 21);
            this.lblURL.TabIndex = 30;
            this.lblURL.Text = "URL";
            // 
            // tbxURL
            // 
            this.tbxURL.Enabled = false;
            this.tbxURL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxURL.Location = new System.Drawing.Point(59, 386);
            this.tbxURL.Name = "tbxURL";
            this.tbxURL.Size = new System.Drawing.Size(301, 27);
            this.tbxURL.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-7, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 2);
            this.label2.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-7, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 2);
            this.label3.TabIndex = 32;
            // 
            // AddWorkshopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 507);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.tbxURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numRoomNumber);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.numCapacity);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblAddTitle);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.rbInBuilding);
            this.Controls.Add(this.rbOnline);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbxTitle);
            this.Name = "AddWorkshopForm";
            this.Text = "AddWorkshopForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddWorkshopForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RadioButton rbInBuilding;
        private System.Windows.Forms.RadioButton rbOnline;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.NumericUpDown numRoomNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox tbxURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}