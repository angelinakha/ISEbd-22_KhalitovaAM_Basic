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
	public partial class FormDocks : Form
	{
		private readonly DocksCollection parkingCollection;

		public FormDocks()
		{
			InitializeComponent();
			parkingCollection = new DocksCollection(pictureBox_doc.Width, pictureBox_doc.Height);
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

		private void button_AddShip_Click(object sender, EventArgs e)
		{
			var formShipConfig = new FormShipConfig();
			formShipConfig.AddEvent(AddShip);
			formShipConfig.Show();
		}
		private void AddShip(Vehicle ship)
		{
			if (ship != null && listBox_listDoc.SelectedIndex > -1)
			{
				if ((parkingCollection[listBox_listDoc.SelectedItem.ToString()]) + ship)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Не получилось припарковать корабль");
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

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

			if (saveFileDialog_ship.ShowDialog() == DialogResult.OK)
			{
				if (parkingCollection.SaveData(saveFileDialog_ship.FileName))
				{
					MessageBox.Show("Сохранение прошло успешно", "Результат",
				   MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Не сохранилось", "Результат",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (openFileDialog_ship.ShowDialog() == DialogResult.OK)
			{
				if (parkingCollection.LoadData(openFileDialog_ship.FileName))
				{
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
				   MessageBoxIcon.Information);
					ReloadLevels();
					Draw();
				}
				else
				{
					MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
				   MessageBoxIcon.Error);
				}
			}

		}
	}
}
