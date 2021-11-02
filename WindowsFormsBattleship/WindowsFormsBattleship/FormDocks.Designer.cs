namespace WindowsFormsBattleship
{
    partial class FormDocks
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
            this.button_extract = new System.Windows.Forms.Button();
            this.maskedTextBox_place = new System.Windows.Forms.MaskedTextBox();
            this.label_place = new System.Windows.Forms.Label();
            this.listBox_listDoc = new System.Windows.Forms.ListBox();
            this.textBox_parkName = new System.Windows.Forms.TextBox();
            this.label_parks = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
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
            this.button_parkShip.Location = new System.Drawing.Point(648, 203);
            this.button_parkShip.Name = "button_parkShip";
            this.button_parkShip.Size = new System.Drawing.Size(140, 48);
            this.button_parkShip.TabIndex = 1;
            this.button_parkShip.Text = "Припарковать корабль";
            this.button_parkShip.UseVisualStyleBackColor = true;
            this.button_parkShip.Click += new System.EventHandler(this.button_parkShip_Click);
            // 
            // button_parkBShip
            // 
            this.button_parkBShip.Location = new System.Drawing.Point(648, 266);
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
            this.groupBox_extract.Controls.Add(this.label_place);
            this.groupBox_extract.Location = new System.Drawing.Point(648, 333);
            this.groupBox_extract.Name = "groupBox_extract";
            this.groupBox_extract.Size = new System.Drawing.Size(139, 110);
            this.groupBox_extract.TabIndex = 3;
            this.groupBox_extract.TabStop = false;
            this.groupBox_extract.Text = "Забрать корабль";
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
            // maskedTextBox_place
            // 
            this.maskedTextBox_place.Location = new System.Drawing.Point(67, 30);
            this.maskedTextBox_place.Name = "maskedTextBox_place";
            this.maskedTextBox_place.Size = new System.Drawing.Size(33, 20);
            this.maskedTextBox_place.TabIndex = 4;
            // 
            // label_place
            // 
            this.label_place.AutoSize = true;
            this.label_place.Location = new System.Drawing.Point(19, 33);
            this.label_place.Name = "label_place";
            this.label_place.Size = new System.Drawing.Size(42, 13);
            this.label_place.TabIndex = 0;
            this.label_place.Text = "Место:";
            // 
            // listBox_listDoc
            // 
            this.listBox_listDoc.FormattingEnabled = true;
            this.listBox_listDoc.Location = new System.Drawing.Point(647, 83);
            this.listBox_listDoc.Name = "listBox_listDoc";
            this.listBox_listDoc.Size = new System.Drawing.Size(140, 69);
            this.listBox_listDoc.TabIndex = 4;
            this.listBox_listDoc.SelectedIndexChanged += new System.EventHandler(this.listBox_listDoc_SelectedIndexChanged);
            // 
            // textBox_parkName
            // 
            this.textBox_parkName.Location = new System.Drawing.Point(647, 25);
            this.textBox_parkName.Name = "textBox_parkName";
            this.textBox_parkName.Size = new System.Drawing.Size(140, 20);
            this.textBox_parkName.TabIndex = 5;
            // 
            // label_parks
            // 
            this.label_parks.AutoSize = true;
            this.label_parks.Location = new System.Drawing.Point(688, 9);
            this.label_parks.Name = "label_parks";
            this.label_parks.Size = new System.Drawing.Size(60, 13);
            this.label_parks.TabIndex = 6;
            this.label_parks.Text = "Парковки:";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(647, 51);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(140, 26);
            this.button_add.TabIndex = 7;
            this.button_add.Text = "Добавить парковку";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(648, 154);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(140, 28);
            this.button_del.TabIndex = 8;
            this.button_del.Text = "Удалить парковку";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_parks);
            this.Controls.Add(this.textBox_parkName);
            this.Controls.Add(this.listBox_listDoc);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_doc;
        private System.Windows.Forms.Button button_parkShip;
        private System.Windows.Forms.Button button_parkBShip;
        private System.Windows.Forms.GroupBox groupBox_extract;
        private System.Windows.Forms.Button button_extract;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_place;
        private System.Windows.Forms.Label label_place;
        private System.Windows.Forms.ListBox listBox_listDoc;
        private System.Windows.Forms.TextBox textBox_parkName;
        private System.Windows.Forms.Label label_parks;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_del;
    }
}