namespace WindowsFormsBattleship
{
	partial class FormParking
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
			this.pictureBox_doc = new System.Windows.Forms.PictureBox();
			this.button_parkShip = new System.Windows.Forms.Button();
			this.button_parkBShip = new System.Windows.Forms.Button();
			this.groupBox_extract = new System.Windows.Forms.GroupBox();
			this.label_здфсу = new System.Windows.Forms.Label();
			this.maskedTextBox_place = new System.Windows.Forms.MaskedTextBox();
			this.button_extract = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_doc)).BeginInit();
			this.groupBox_extract.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox_doc
			// 
			this.pictureBox_doc.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.pictureBox_doc.Location = new System.Drawing.Point(0, 0);
			this.pictureBox_doc.Name = "pictureBox_doc";
			this.pictureBox_doc.Size = new System.Drawing.Size(642, 450);
			this.pictureBox_doc.TabIndex = 0;
			this.pictureBox_doc.TabStop = false;
			// 
			// button_parkShip
			// 
			this.button_parkShip.Location = new System.Drawing.Point(648, 22);
			this.button_parkShip.Name = "button_parkShip";
			this.button_parkShip.Size = new System.Drawing.Size(140, 48);
			this.button_parkShip.TabIndex = 1;
			this.button_parkShip.Text = "Припарковать корабль";
			this.button_parkShip.UseVisualStyleBackColor = true;
			this.button_parkShip.Click += new System.EventHandler(this.button_parkShip_Click);
			// 
			// button_parkBShip
			// 
			this.button_parkBShip.Location = new System.Drawing.Point(648, 85);
			this.button_parkBShip.Name = "button_parkBShip";
			this.button_parkBShip.Size = new System.Drawing.Size(140, 48);
			this.button_parkBShip.TabIndex = 2;
			this.button_parkBShip.Text = "Припарковать линкор";
			this.button_parkBShip.UseVisualStyleBackColor = true;
			this.button_parkBShip.Click += new System.EventHandler(this.button_parkBShip_Click);
			// 
			// groupBox_extract
			// 
			this.groupBox_extract.Controls.Add(this.button_extract);
			this.groupBox_extract.Controls.Add(this.maskedTextBox_place);
			this.groupBox_extract.Controls.Add(this.label_здфсу);
			this.groupBox_extract.Location = new System.Drawing.Point(648, 152);
			this.groupBox_extract.Name = "groupBox_extract";
			this.groupBox_extract.Size = new System.Drawing.Size(139, 173);
			this.groupBox_extract.TabIndex = 3;
			this.groupBox_extract.TabStop = false;
			this.groupBox_extract.Text = "Забрать корабль";
			// 
			// label_здфсу
			// 
			this.label_здфсу.AutoSize = true;
			this.label_здфсу.Location = new System.Drawing.Point(19, 33);
			this.label_здфсу.Name = "label_здфсу";
			this.label_здфсу.Size = new System.Drawing.Size(42, 13);
			this.label_здфсу.TabIndex = 0;
			this.label_здфсу.Text = "Место:";
			// 
			// maskedTextBox_place
			// 
			this.maskedTextBox_place.Location = new System.Drawing.Point(67, 30);
			this.maskedTextBox_place.Name = "maskedTextBox_place";
			this.maskedTextBox_place.Size = new System.Drawing.Size(33, 20);
			this.maskedTextBox_place.TabIndex = 4;
			// 
			// button_extract
			// 
			this.button_extract.Location = new System.Drawing.Point(22, 73);
			this.button_extract.Name = "button_extract";
			this.button_extract.Size = new System.Drawing.Size(104, 23);
			this.button_extract.TabIndex = 5;
			this.button_extract.Text = "Забрать";
			this.button_extract.UseVisualStyleBackColor = true;
			this.button_extract.Click += new System.EventHandler(this.button_extract_Click);
			// 
			// FormParking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox_extract);
			this.Controls.Add(this.button_parkBShip);
			this.Controls.Add(this.button_parkShip);
			this.Controls.Add(this.pictureBox_doc);
			this.Name = "FormParking";
			this.Text = "Доки";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_doc)).EndInit();
			this.groupBox_extract.ResumeLayout(false);
			this.groupBox_extract.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox_doc;
		private System.Windows.Forms.Button button_parkShip;
		private System.Windows.Forms.Button button_parkBShip;
		private System.Windows.Forms.GroupBox groupBox_extract;
		private System.Windows.Forms.Button button_extract;
		private System.Windows.Forms.MaskedTextBox maskedTextBox_place;
		private System.Windows.Forms.Label label_здфсу;
	}
}