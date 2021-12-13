using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace WindowsFormsBattleship
{
	public partial class FormDocks : Form
	{
		private readonly DocksCollection parkingCollection;

		/// Логгер
		private readonly Logger logger;

		public FormDocks()
		{
			InitializeComponent();
			parkingCollection = new DocksCollection(pictureBox_doc.Width, pictureBox_doc.Height);
			logger = LogManager.GetCurrentClassLogger();
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
				try
				{
					if ((parkingCollection[listBox_listDoc.SelectedItem.ToString()]) + ship)
					{
						Draw();
						logger.Info($"Добавлен корабль {ship}");
					}
					else
					{
						logger.Warn("Корабль не удалось поставить");
					}
					Draw();
				}
				catch (DocksOverflowException ex)
				{
					MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
					logger.Warn($"{ex.Message} Переполнение");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Warn($"{ex.Message} Неизвестная ошибка");
				}
			}
		}
		private void button_extract_Click(object sender, EventArgs e)
		{
			if (listBox_listDoc.SelectedIndex > -1 && maskedTextBox_place.Text != "")
			{
				try
				{
					var ship = parkingCollection[listBox_listDoc.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox_place.Text);
					if (ship != null)
					{
						FormBattleship form = new FormBattleship();
						form.SetShip(ship);
						form.ShowDialog();
						logger.Info($"Изъят корабль {ship} с места {maskedTextBox_place.Text}");
				    Draw();
					}
				}
				catch (DocksNotFoundException ex)
				{
					MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
					logger.Warn($"{ex.Message} Не найдено");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Warn($"{ex.Message} Неизвестная ошибка");
				}
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
			logger.Info($"Добавили доки {textBox_parkName.Text}");
			parkingCollection.AddParking(textBox_parkName.Text);
			ReloadLevels();
		}

		private void button_del_Click(object sender, EventArgs e)
		{
			if (listBox_listDoc.SelectedIndex > -1)
			{
				if (MessageBox.Show($"Удалить парковку { listBox_listDoc.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					logger.Info($"Удалили парковку {listBox_listDoc.SelectedItem.ToString()}");
					parkingCollection.DelParking(listBox_listDoc.Text);
					ReloadLevels();
				}
			}
		}

		private void listBox_listDoc_SelectedIndexChanged(object sender, EventArgs e)
		{
			logger.Info($"Перешли на доки {listBox_listDoc.SelectedItem.ToString()}");

			Draw();
		}

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

			if (saveFileDialog_ship.ShowDialog() == DialogResult.OK)
			{
				try
				{
					parkingCollection.SaveData(saveFileDialog_ship.FileName);
					MessageBox.Show("Сохранение прошло успешно", "Результат",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
					logger.Info("Сохранено в файл " + saveFileDialog_ship.FileName);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Warn($"{ex.Message} Неизвестная ошибка при сохранении");
				}
			}
		}

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (openFileDialog_ship.ShowDialog() == DialogResult.OK)
			{
				try
				{
					parkingCollection.LoadData(openFileDialog_ship.FileName);
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
					logger.Info("Загружено из файла " + openFileDialog_ship.FileName);
					ReloadLevels();
					Draw();
				}
				catch (DocksOccupiedPlaceException ex)
				{
					MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
					logger.Warn($"{ex.Message} Занятое место");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Warn($"{ex.Message} Неизвестная ошибка при сохранении");
				}
			}

		}

        private void buttonSort_Click(object sender, EventArgs e)
        {
			if (listBox_listDoc.SelectedIndex > -1)
			{
				parkingCollection[listBox_listDoc.SelectedItem.ToString()].Sort();
				Draw();
				logger.Info("Сортировка уровней");
			}

		}
	}
}
