
namespace Health_Tracker
{
	partial class formLanding
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblBuildTitle = new System.Windows.Forms.Label();
			this.lblVersionTitle = new System.Windows.Forms.Label();
			this.btnNewEntry = new System.Windows.Forms.Button();
			this.btnSaveData = new System.Windows.Forms.Button();
			this.lblBuildData = new System.Windows.Forms.Label();
			this.lblVersionData = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Arial Black", 26F, System.Drawing.FontStyle.Bold);
			this.lblTitle.Location = new System.Drawing.Point(12, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(306, 50);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Health Tracker";
			// 
			// lblBuildTitle
			// 
			this.lblBuildTitle.AutoSize = true;
			this.lblBuildTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBuildTitle.Location = new System.Drawing.Point(393, 14);
			this.lblBuildTitle.Name = "lblBuildTitle";
			this.lblBuildTitle.Size = new System.Drawing.Size(74, 16);
			this.lblBuildTitle.TabIndex = 1;
			this.lblBuildTitle.Text = "Build Date";
			// 
			// lblVersionTitle
			// 
			this.lblVersionTitle.AutoSize = true;
			this.lblVersionTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVersionTitle.Location = new System.Drawing.Point(393, 61);
			this.lblVersionTitle.Name = "lblVersionTitle";
			this.lblVersionTitle.Size = new System.Drawing.Size(69, 16);
			this.lblVersionTitle.TabIndex = 2;
			this.lblVersionTitle.Text = "Build Ver.";
			// 
			// btnNewEntry
			// 
			this.btnNewEntry.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewEntry.Location = new System.Drawing.Point(11, 74);
			this.btnNewEntry.Name = "btnNewEntry";
			this.btnNewEntry.Size = new System.Drawing.Size(172, 50);
			this.btnNewEntry.TabIndex = 3;
			this.btnNewEntry.Tag = "0";
			this.btnNewEntry.Text = "Add New Event";
			this.btnNewEntry.UseVisualStyleBackColor = true;
			this.btnNewEntry.Click += new System.EventHandler(this.btnNewEntry_Click);
			// 
			// btnSaveData
			// 
			this.btnSaveData.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveData.Location = new System.Drawing.Point(189, 74);
			this.btnSaveData.Name = "btnSaveData";
			this.btnSaveData.Size = new System.Drawing.Size(172, 50);
			this.btnSaveData.TabIndex = 4;
			this.btnSaveData.Tag = "1";
			this.btnSaveData.Text = "Save Event Data";
			this.btnSaveData.UseVisualStyleBackColor = true;
			this.btnSaveData.Click += new System.EventHandler(this.btnViewData_Click);
			// 
			// lblBuildData
			// 
			this.lblBuildData.AutoSize = true;
			this.lblBuildData.Font = new System.Drawing.Font("Arial", 8F);
			this.lblBuildData.Location = new System.Drawing.Point(393, 37);
			this.lblBuildData.Name = "lblBuildData";
			this.lblBuildData.Size = new System.Drawing.Size(55, 14);
			this.lblBuildData.TabIndex = 5;
			this.lblBuildData.Text = "Build Date";
			// 
			// lblVersionData
			// 
			this.lblVersionData.AutoSize = true;
			this.lblVersionData.Font = new System.Drawing.Font("Arial", 8F);
			this.lblVersionData.Location = new System.Drawing.Point(393, 86);
			this.lblVersionData.Name = "lblVersionData";
			this.lblVersionData.Size = new System.Drawing.Size(55, 14);
			this.lblVersionData.TabIndex = 6;
			this.lblVersionData.Text = "Build Date";
			// 
			// formLanding
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(486, 136);
			this.Controls.Add(this.lblVersionData);
			this.Controls.Add(this.lblBuildData);
			this.Controls.Add(this.btnSaveData);
			this.Controls.Add(this.btnNewEntry);
			this.Controls.Add(this.lblVersionTitle);
			this.Controls.Add(this.lblBuildTitle);
			this.Controls.Add(this.lblTitle);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximizeBox = false;
			this.Name = "formLanding";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Landing Page";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblBuildTitle;
		private System.Windows.Forms.Label lblVersionTitle;
		private System.Windows.Forms.Button btnNewEntry;
		private System.Windows.Forms.Button btnSaveData;
		private System.Windows.Forms.Label lblBuildData;
		private System.Windows.Forms.Label lblVersionData;
	}
}

