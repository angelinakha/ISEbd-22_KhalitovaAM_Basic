namespace WindowsFormsBattleship
{
    partial class FormShipConfig
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
            this.groupBox_ = new System.Windows.Forms.GroupBox();
            this.labelBattSh = new System.Windows.Forms.Label();
            this.labelShip = new System.Windows.Forms.Label();
            this.groupB_setting = new System.Windows.Forms.GroupBox();
            this.checkBox_rocket = new System.Windows.Forms.CheckBox();
            this.checkBox_cannon = new System.Windows.Forms.CheckBox();
            this.numericUpDown_W = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_mS = new System.Windows.Forms.NumericUpDown();
            this.label_weight = new System.Windows.Forms.Label();
            this.label_maxSpeed = new System.Windows.Forms.Label();
            this.pictureBox_ship = new System.Windows.Forms.PictureBox();
            this.panel_ship = new System.Windows.Forms.Panel();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelCol_fuchsia = new System.Windows.Forms.Panel();
            this.panelCol_red = new System.Windows.Forms.Panel();
            this.panelCol_orange = new System.Windows.Forms.Panel();
            this.panelCol_yellow = new System.Windows.Forms.Panel();
            this.panelCol_gray = new System.Windows.Forms.Panel();
            this.panelCol_green = new System.Windows.Forms.Panel();
            this.panelCol_blue = new System.Windows.Forms.Panel();
            this.panelCol_black = new System.Windows.Forms.Panel();
            this.labelDopCol = new System.Windows.Forms.Label();
            this.labelBasicCol = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox_.SuspendLayout();
            this.groupB_setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_W)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ship)).BeginInit();
            this.panel_ship.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_
            // 
            this.groupBox_.Controls.Add(this.labelBattSh);
            this.groupBox_.Controls.Add(this.labelShip);
            this.groupBox_.Location = new System.Drawing.Point(31, 45);
            this.groupBox_.Name = "groupBox_";
            this.groupBox_.Size = new System.Drawing.Size(175, 124);
            this.groupBox_.TabIndex = 0;
            this.groupBox_.TabStop = false;
            this.groupBox_.Text = "Выбор корпуса";
            // 
            // labelBattSh
            // 
            this.labelBattSh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBattSh.Location = new System.Drawing.Point(33, 71);
            this.labelBattSh.Name = "labelBattSh";
            this.labelBattSh.Size = new System.Drawing.Size(103, 30);
            this.labelBattSh.TabIndex = 1;
            this.labelBattSh.Text = "Линкор";
            this.labelBattSh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBattSh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBattSh_MouseDown);
            // 
            // labelShip
            // 
            this.labelShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShip.Location = new System.Drawing.Point(33, 28);
            this.labelShip.Name = "labelShip";
            this.labelShip.Size = new System.Drawing.Size(103, 30);
            this.labelShip.TabIndex = 0;
            this.labelShip.Text = "Корабль";
            this.labelShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelShip_MouseDown);
            // 
            // groupB_setting
            // 
            this.groupB_setting.Controls.Add(this.checkBox_rocket);
            this.groupB_setting.Controls.Add(this.checkBox_cannon);
            this.groupB_setting.Controls.Add(this.numericUpDown_W);
            this.groupB_setting.Controls.Add(this.numericUpDown_mS);
            this.groupB_setting.Controls.Add(this.label_weight);
            this.groupB_setting.Controls.Add(this.label_maxSpeed);
            this.groupB_setting.Location = new System.Drawing.Point(31, 199);
            this.groupB_setting.Name = "groupB_setting";
            this.groupB_setting.Size = new System.Drawing.Size(271, 156);
            this.groupB_setting.TabIndex = 1;
            this.groupB_setting.TabStop = false;
            this.groupB_setting.Text = "Параметры";
            // 
            // checkBox_rocket
            // 
            this.checkBox_rocket.AutoSize = true;
            this.checkBox_rocket.Location = new System.Drawing.Point(166, 84);
            this.checkBox_rocket.Name = "checkBox_rocket";
            this.checkBox_rocket.Size = new System.Drawing.Size(59, 17);
            this.checkBox_rocket.TabIndex = 5;
            this.checkBox_rocket.Text = "Пушки";
            this.checkBox_rocket.UseVisualStyleBackColor = true;
            // 
            // checkBox_cannon
            // 
            this.checkBox_cannon.AutoSize = true;
            this.checkBox_cannon.Location = new System.Drawing.Point(166, 46);
            this.checkBox_cannon.Name = "checkBox_cannon";
            this.checkBox_cannon.Size = new System.Drawing.Size(64, 17);
            this.checkBox_cannon.TabIndex = 4;
            this.checkBox_cannon.Text = "Ракеты";
            this.checkBox_cannon.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_W
            // 
            this.numericUpDown_W.Location = new System.Drawing.Point(86, 100);
            this.numericUpDown_W.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_W.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_W.Name = "numericUpDown_W";
            this.numericUpDown_W.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown_W.TabIndex = 3;
            this.numericUpDown_W.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown_mS
            // 
            this.numericUpDown_mS.Location = new System.Drawing.Point(86, 46);
            this.numericUpDown_mS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_mS.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_mS.Name = "numericUpDown_mS";
            this.numericUpDown_mS.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown_mS.TabIndex = 2;
            this.numericUpDown_mS.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.Location = new System.Drawing.Point(16, 84);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(77, 13);
            this.label_weight.TabIndex = 1;
            this.label_weight.Text = "Вес корабля: ";
            // 
            // label_maxSpeed
            // 
            this.label_maxSpeed.AutoSize = true;
            this.label_maxSpeed.Location = new System.Drawing.Point(16, 30);
            this.label_maxSpeed.Name = "label_maxSpeed";
            this.label_maxSpeed.Size = new System.Drawing.Size(90, 13);
            this.label_maxSpeed.TabIndex = 0;
            this.label_maxSpeed.Text = "Макс. скорость:";
            // 
            // pictureBox_ship
            // 
            this.pictureBox_ship.Location = new System.Drawing.Point(22, 11);
            this.pictureBox_ship.Name = "pictureBox_ship";
            this.pictureBox_ship.Size = new System.Drawing.Size(224, 158);
            this.pictureBox_ship.TabIndex = 2;
            this.pictureBox_ship.TabStop = false;
            // 
            // panel_ship
            // 
            this.panel_ship.AllowDrop = true;
            this.panel_ship.Controls.Add(this.pictureBox_ship);
            this.panel_ship.Location = new System.Drawing.Point(255, 12);
            this.panel_ship.Name = "panel_ship";
            this.panel_ship.Size = new System.Drawing.Size(270, 181);
            this.panel_ship.TabIndex = 3;
            this.panel_ship.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_ship_DragDrop);
            this.panel_ship.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_ship_DragEnter);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelCol_fuchsia);
            this.groupBoxColor.Controls.Add(this.panelCol_red);
            this.groupBoxColor.Controls.Add(this.panelCol_orange);
            this.groupBoxColor.Controls.Add(this.panelCol_yellow);
            this.groupBoxColor.Controls.Add(this.panelCol_gray);
            this.groupBoxColor.Controls.Add(this.panelCol_green);
            this.groupBoxColor.Controls.Add(this.panelCol_blue);
            this.groupBoxColor.Controls.Add(this.panelCol_black);
            this.groupBoxColor.Controls.Add(this.labelDopCol);
            this.groupBoxColor.Controls.Add(this.labelBasicCol);
            this.groupBoxColor.Location = new System.Drawing.Point(329, 215);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(293, 160);
            this.groupBoxColor.TabIndex = 4;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // panelCol_fuchsia
            // 
            this.panelCol_fuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.panelCol_fuchsia.Location = new System.Drawing.Point(220, 68);
            this.panelCol_fuchsia.Name = "panelCol_fuchsia";
            this.panelCol_fuchsia.Size = new System.Drawing.Size(39, 32);
            this.panelCol_fuchsia.TabIndex = 5;
            // 
            // panelCol_red
            // 
            this.panelCol_red.BackColor = System.Drawing.Color.Red;
            this.panelCol_red.Location = new System.Drawing.Point(157, 68);
            this.panelCol_red.Name = "panelCol_red";
            this.panelCol_red.Size = new System.Drawing.Size(39, 32);
            this.panelCol_red.TabIndex = 8;
            // 
            // panelCol_orange
            // 
            this.panelCol_orange.BackColor = System.Drawing.Color.Orange;
            this.panelCol_orange.Location = new System.Drawing.Point(94, 68);
            this.panelCol_orange.Name = "panelCol_orange";
            this.panelCol_orange.Size = new System.Drawing.Size(39, 32);
            this.panelCol_orange.TabIndex = 7;
            // 
            // panelCol_yellow
            // 
            this.panelCol_yellow.BackColor = System.Drawing.Color.Yellow;
            this.panelCol_yellow.Location = new System.Drawing.Point(30, 68);
            this.panelCol_yellow.Name = "panelCol_yellow";
            this.panelCol_yellow.Size = new System.Drawing.Size(39, 32);
            this.panelCol_yellow.TabIndex = 6;
            // 
            // panelCol_gray
            // 
            this.panelCol_gray.BackColor = System.Drawing.Color.Gray;
            this.panelCol_gray.Location = new System.Drawing.Point(30, 108);
            this.panelCol_gray.Name = "panelCol_gray";
            this.panelCol_gray.Size = new System.Drawing.Size(39, 32);
            this.panelCol_gray.TabIndex = 5;
            // 
            // panelCol_green
            // 
            this.panelCol_green.BackColor = System.Drawing.Color.Green;
            this.panelCol_green.Location = new System.Drawing.Point(94, 108);
            this.panelCol_green.Name = "panelCol_green";
            this.panelCol_green.Size = new System.Drawing.Size(39, 32);
            this.panelCol_green.TabIndex = 4;
            // 
            // panelCol_blue
            // 
            this.panelCol_blue.BackColor = System.Drawing.Color.Blue;
            this.panelCol_blue.Location = new System.Drawing.Point(157, 108);
            this.panelCol_blue.Name = "panelCol_blue";
            this.panelCol_blue.Size = new System.Drawing.Size(39, 32);
            this.panelCol_blue.TabIndex = 3;
            // 
            // panelCol_black
            // 
            this.panelCol_black.BackColor = System.Drawing.Color.Black;
            this.panelCol_black.Location = new System.Drawing.Point(220, 108);
            this.panelCol_black.Name = "panelCol_black";
            this.panelCol_black.Size = new System.Drawing.Size(39, 32);
            this.panelCol_black.TabIndex = 2;
            // 
            // labelDopCol
            // 
            this.labelDopCol.AllowDrop = true;
            this.labelDopCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopCol.Location = new System.Drawing.Point(157, 20);
            this.labelDopCol.Name = "labelDopCol";
            this.labelDopCol.Size = new System.Drawing.Size(91, 30);
            this.labelDopCol.TabIndex = 1;
            this.labelDopCol.Text = "Дополн. цвет";
            this.labelDopCol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopCol.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopCol_DragDrop);
            this.labelDopCol.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBasicCol_DragEnter);
            // 
            // labelBasicCol
            // 
            this.labelBasicCol.AllowDrop = true;
            this.labelBasicCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBasicCol.Location = new System.Drawing.Point(42, 20);
            this.labelBasicCol.Name = "labelBasicCol";
            this.labelBasicCol.Size = new System.Drawing.Size(91, 30);
            this.labelBasicCol.TabIndex = 0;
            this.labelBasicCol.Text = "Основной цвет";
            this.labelBasicCol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBasicCol.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBasicCol_DragDrop);
            this.labelBasicCol.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBasicCol_DragEnter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(549, 73);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(93, 33);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(549, 116);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 33);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormShipConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panel_ship);
            this.Controls.Add(this.groupB_setting);
            this.Controls.Add(this.groupBox_);
            this.Name = "FormShipConfig";
            this.Text = "Выбор корабля";
            this.groupBox_.ResumeLayout(false);
            this.groupB_setting.ResumeLayout(false);
            this.groupB_setting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_W)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ship)).EndInit();
            this.panel_ship.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_;
        private System.Windows.Forms.Label labelBattSh;
        private System.Windows.Forms.Label labelShip;
        private System.Windows.Forms.GroupBox groupB_setting;
        private System.Windows.Forms.Label label_maxSpeed;
        private System.Windows.Forms.Label label_weight;
        private System.Windows.Forms.CheckBox checkBox_rocket;
        private System.Windows.Forms.CheckBox checkBox_cannon;
        private System.Windows.Forms.NumericUpDown numericUpDown_W;
        private System.Windows.Forms.NumericUpDown numericUpDown_mS;
        private System.Windows.Forms.PictureBox pictureBox_ship;
        private System.Windows.Forms.Panel panel_ship;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel panelCol_green;
        private System.Windows.Forms.Panel panelCol_blue;
        private System.Windows.Forms.Panel panelCol_black;
        private System.Windows.Forms.Label labelDopCol;
        private System.Windows.Forms.Label labelBasicCol;
        private System.Windows.Forms.Panel panelCol_fuchsia;
        private System.Windows.Forms.Panel panelCol_red;
        private System.Windows.Forms.Panel panelCol_orange;
        private System.Windows.Forms.Panel panelCol_yellow;
        private System.Windows.Forms.Panel panelCol_gray;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}