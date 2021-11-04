using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBattleship
{
    public partial class FormShipConfig : Form
    {
        Vehicle ship = null;
        private event Action<Vehicle> eventAddShip;
        public FormShipConfig()
        {
            InitializeComponent();
            this.panelCol_yellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelCol_red.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelCol_blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelCol_gray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelCol_green.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelCol_orange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelCol_fuchsia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelCol_black.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawShip()
        {
            if (ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBox_ship.Width, pictureBox_ship.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.SetPosition(35, 35, pictureBox_ship.Width, pictureBox_ship.Height);
                ship.DrawShip(gr);
                pictureBox_ship.Image = bmp;
            }
        }
        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddShip == null)
            {
                eventAddShip = new Action<Vehicle>(ev);

            }
            else
            {
                eventAddShip += ev;
            }
        }

        private void labelShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelShip.DoDragDrop(labelShip.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void labelBattSh_MouseDown(object sender, MouseEventArgs e)
        {
            labelBattSh.DoDragDrop(labelBattSh.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void panel_ship_DragEnter(object sender, DragEventArgs e)
        {
                if (e.Data.GetDataPresent(DataFormats.Text))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
        }

        private void panel_ship_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Корабль":
                    ship = new Ship((int)numericUpDown_mS.Value, (int)numericUpDown_W.Value, Color.Black);
                    break;
                case "Линкор":
                    ship = new Battleship((int)numericUpDown_mS.Value, (int)numericUpDown_W.Value, Color.Black, Color.DarkGreen, 
                        checkBox_cannon.Checked, checkBox_rocket.Checked);
                    break;
            }
            DrawShip();
        }

        private void labelBasicCol_DragDrop(object sender, DragEventArgs e)
        {
            ship.SetBasicColor((Color)e.Data.GetData(typeof(Color)));
            DrawShip();
        }

        private void labelBasicCol_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelDopCol_DragDrop(object sender, DragEventArgs e)
        {
            if (ship is Battleship)
            {
                (ship as Battleship).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                DrawShip();
            }
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            Color color = (sender as Panel).BackColor;
            (sender as Panel).DoDragDrop(color, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
             eventAddShip?.Invoke(ship);
             Close();
        }
    }
}
