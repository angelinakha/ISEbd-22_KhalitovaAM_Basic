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
	public partial class FormParking : Form
	{
		private readonly ParkingCollection parkingCollection;

		public FormParking()
		{
			InitializeComponent();
			parkingCollection = new ParkingCollection(pictureBox_doc.Width, pictureBox_doc.Height);
			Draw();

		}

		/// Заполнение listBoxLevels
		private void ReloadLevels()
		{
			int index = listBox_listDoc.SelectedIndex;
			listBox_listDoc.Items.Clear();
			for (int i = 0; i < parkingCollection.Keys.Count; i++)
			{
				listBox_listDoc.Items.Add(parkingCollection.Keys[i]);
			}
			if (listBox_listDoc.Items.Count > 0 && (index == -1 || index >=
		   listBox_listDoc.Items.Count))
			{
				listBox_listDoc.SelectedIndex = 0;
			}
			else if (listBox_listDoc.Items.Count > 0 && index > -1 && index <
		   listBox_listDoc.Items.Count)
			{
				listBox_listDoc.SelectedIndex = index;
			}
		}

		private void Draw()
		{
			if (listBox_listDoc.SelectedIndex > -1)
			{
				Bitmap bmp = new Bitmap(pictureBox_doc.Width, pictureBox_doc.Height);
				Graphics gr = Graphics.FromImage(bmp);
				parkingCollection[listBox_listDoc.SelectedItem.ToString()].Draw(gr);
				pictureBox_doc.Image = bmp;
			}
		}

		private void button_parkShip_Click(object sender, EventArgs e)
		{
			if (listBox_listDoc.SelectedIndex > -1)
			{
				ColorDialog dialog = new ColorDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					var ship = new Ship(100, 1000, dialog.Color);
					if (parkingCollection[listBox_listDoc.SelectedItem.ToString()] + ship)
					{
						Draw();
					}
					else
					{
						MessageBox.Show("Доки переполнены");
					}
				}
			}
		}

		private void button_parkBShip_Click(object sender, EventArgs e)
		{
			if (listBox_listDoc.SelectedIndex > -1)
			{
				ColorDialog dialog = new ColorDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					ColorDialog dialogDop = new ColorDialog();
					if (dialogDop.ShowDialog() == DialogResult.OK)
					{
						var ship = new Battleship(100, 1000, dialog.Color, dialogDop.Color,
					   true, true);
						if (parkingCollection[listBox_listDoc.SelectedItem.ToString()] + ship)
						{
							Draw();
						}
						else
						{
							MessageBox.Show("Доки переполнены");
						}
					}
				}
			}
		}

		private void button_extract_Click(object sender, EventArgs e)
		{
			if (listBox_listDoc.SelectedIndex > -1 && maskedTextBox_place.Text != "")
			{

				var ship = parkingCollection[listBox_listDoc.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox_place.Text);
				if (ship != null)
				{
					FormBattleship form = new FormBattleship();
					form.SetCar(ship);
					form.ShowDialog();
				}
				Draw();
			}
		}

		private void button_add_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox_parkName.Text))
			{
				MessageBox.Show("Введите название парковки", "Ошибка",
			   MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			parkingCollection.AddParking(textBox_parkName.Text);
			ReloadLevels();
		}

		private void button_del_Click(object sender, EventArgs e)
		{
			if (listBox_listDoc.SelectedIndex > -1)
			{
				if (MessageBox.Show($"Удалить парковку { listBox_listDoc.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					parkingCollection.DelParking(listBox_listDoc.Text);
					ReloadLevels();
				}
			}
		}

		private void listBox_listDoc_SelectedIndexChanged(object sender, EventArgs e)
		{
			Draw();
		}
	}
}
