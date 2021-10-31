using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsBattleship
{
	public class Parking<T> where T : class, IShip
	{
		/// Список объектов, которые храним
		private readonly List<T> _places;
		/// Максимальное количество мест на парковке
		private readonly int _maxCount;
		/// Ширина окна отрисовки
		private readonly int pictureWidth;
		/// Высота окна отрисовки
		private readonly int pictureHeight;
		/// Размер парковочного места (ширина)
		private readonly int _placeSizeWidth = 210;
		/// Размер парковочного места (высота)
		private readonly int _placeSizeHeight = 90;

		public Parking(int picWidth, int picHeight)
		{
			int width = picWidth / _placeSizeWidth;
			int height = picHeight / _placeSizeHeight;
			_maxCount = width * height;
			_places = new List<T>();
			pictureWidth = picWidth;
			pictureHeight = picHeight;
		}

		public static bool operator +(Parking<T> p, T ship)
		{
			if (p._places.Count >= p._maxCount)
			{
				return false;
			}
			p._places.Add(ship);
			return true;
		}

		public static T operator -(Parking<T> p, int index)
		{
			if ((index < -1) || (index >= p._places.Count))
			{
				return null;
			}
			T ship = p._places[index];
			p._places.RemoveAt(index);
			return ship;
		}

		//Метод отрисовки доков
		public void Draw(Graphics g)
		{
			DrawMarking(g);
			for (int i = 0; i < _places.Count; i++)
			{
				_places[i].SetPosition(5 + i % 5 * _placeSizeWidth + 5, i / 5 * _placeSizeHeight + 15, pictureWidth, pictureHeight);
				_places[i].DrawShip(g);
			}
		}

		/// Метод отрисовки разметки парковочных мест
		private void DrawMarking(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 3);
			for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
			{
				for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
				{//линия разметки места
					g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
				   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
				}
				g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
			   (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
			}
		}
	}
}
