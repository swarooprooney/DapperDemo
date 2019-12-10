namespace DapperDemoUI
{
	partial class DashBoard
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
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.lblLastName = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.listBoxPeopleFound = new System.Windows.Forms.ListBox();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtLastNameEntry = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPhoneNumber = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(105, 31);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(100, 26);
			this.txtLastName.TabIndex = 0;
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location = new System.Drawing.Point(13, 34);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(86, 20);
			this.lblLastName.TabIndex = 1;
			this.lblLastName.Text = "Last Name";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(67, 74);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(76, 30);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// listBoxPeopleFound
			// 
			this.listBoxPeopleFound.FormattingEnabled = true;
			this.listBoxPeopleFound.ItemHeight = 20;
			this.listBoxPeopleFound.Location = new System.Drawing.Point(23, 119);
			this.listBoxPeopleFound.Name = "listBoxPeopleFound";
			this.listBoxPeopleFound.Size = new System.Drawing.Size(670, 204);
			this.listBoxPeopleFound.TabIndex = 3;
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Location = new System.Drawing.Point(19, 397);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(86, 20);
			this.lblFirstName.TabIndex = 5;
			this.lblFirstName.Text = "First Name";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(151, 394);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(100, 26);
			this.txtFirstName.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 435);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Last Name";
			// 
			// txtLastNameEntry
			// 
			this.txtLastNameEntry.Location = new System.Drawing.Point(151, 435);
			this.txtLastNameEntry.Name = "txtLastNameEntry";
			this.txtLastNameEntry.Size = new System.Drawing.Size(100, 26);
			this.txtLastNameEntry.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 477);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Email";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(151, 477);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(100, 26);
			this.txtEmail.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 516);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 20);
			this.label4.TabIndex = 11;
			this.label4.Text = "Phone Number";
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(151, 516);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(100, 26);
			this.txtPhoneNumber.TabIndex = 10;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(151, 557);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 30);
			this.btnSave.TabIndex = 12;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(275, 557);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(100, 30);
			this.btnClear.TabIndex = 13;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// DashBoard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(987, 650);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtPhoneNumber);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtLastNameEntry);
			this.Controls.Add(this.lblFirstName);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.listBoxPeopleFound);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.txtLastName);
			this.Name = "DashBoard";
			this.Text = "Dashboard";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ListBox listBoxPeopleFound;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtLastNameEntry;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPhoneNumber;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClear;
	}
}

