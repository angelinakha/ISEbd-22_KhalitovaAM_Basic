using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsBattleship
{
    public class Battleship : Ship, IEquatable<Battleship>
    {
        /// Дополнительный цвет
        public Color DopColor { private set; get; }
        // Признак наличия пушек
        public bool Cannon { private set; get; }
        // Признак наличия ракет
        public bool Rocket { private set; get; }

        public Battleship(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool rocket, bool cannon) : base (maxSpeed, weight, mainColor, 120, 65)
        {
            DopColor = dopColor;
            Rocket = rocket;
            Cannon = cannon;
        }

        public Battleship(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Rocket = Convert.ToBoolean(strs[4]);
                Cannon = Convert.ToBoolean(strs[5]);
            }
        }

        public override void DrawShip(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);
            base.DrawShip(g);
            // отрисовка пушек
            if (Cannon)
            {
                g.DrawEllipse(pen, _startPosX + 70 / 6, _startPosY - 5, 15, 5);
                g.DrawEllipse(pen, _startPosX + 4 * 70 / 6, _startPosY - 5, 15, 5);
                g.DrawEllipse(pen, _startPosX + 70 / 6, _startPosY + 50, 15, 5);
                g.DrawEllipse(pen, _startPosX + 4 * 70 / 6, _startPosY + 50, 15, 5);
                g.FillEllipse(dopBrush, _startPosX + 70 / 6, _startPosY - 5, 15, 5);
                g.FillEllipse(dopBrush, _startPosX + 4 * 70 / 6, _startPosY - 5, 15, 5);
                g.FillEllipse(dopBrush, _startPosX + 70 / 6, _startPosY + 50, 15, 5);
                g.FillEllipse(dopBrush, _startPosX + 4 * 70 / 6, _startPosY + 50, 15, 5);
                g.FillRectangle(dopBrush, _startPosX + 15, _startPosY - 15, 7, 15);
                g.FillRectangle(dopBrush, _startPosX + 50, _startPosY - 15, 7, 15);
                g.FillRectangle(dopBrush, _startPosX + 15, _startPosY + 50, 7, 15);
                g.FillRectangle(dopBrush, _startPosX + 50, _startPosY + 50, 7, 15);
            }
            // отрисовка ракеты 
            if (Rocket)
            {
                g.DrawLine(pen, _startPosX + 17, _startPosY + 5, _startPosX + 40, _startPosY + 5);
                g.DrawLine(pen, _startPosX + 17, _startPosY + 10, _startPosX + 40, _startPosY + 10);
                g.DrawLine(pen, _startPosX + 17, _startPosY + 5, _startPosX + 17, _startPosY + 10);
                g.DrawLine(pen, _startPosX + 40, _startPosY + 5, _startPosX + 50, _startPosY + 7);
                g.DrawLine(pen, _startPosX + 40, _startPosY + 10, _startPosX + 50, _startPosY + 7);
                g.FillRectangle(dopBrush, _startPosX + 17, _startPosY + 5, 23, 5);

                g.DrawLine(pen, _startPosX + 17, _startPosY + 45, _startPosX + 40, _startPosY + 45);
                g.DrawLine(pen, _startPosX + 17, _startPosY + 40, _startPosX + 40, _startPosY + 40);
                g.DrawLine(pen, _startPosX + 17, _startPosY + 45, _startPosX + 17, _startPosY + 40);
                g.DrawLine(pen, _startPosX + 40, _startPosY + 45, _startPosX + 50, _startPosY + 42);
                g.DrawLine(pen, _startPosX + 40, _startPosY + 40, _startPosX + 50, _startPosY + 42);
                g.FillRectangle(dopBrush, _startPosX + 17, _startPosY + 40, 23, 5);
            }
        }
        // Смена основного цвета
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return
           $"{base.ToString()}{separator}{DopColor.Name}{separator}{Rocket}{separator}{Cannon}";
        }

        /// <summary>
        /// Метод интерфейса IEquatable для класса Battleship
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Battleship other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Rocket != other.Rocket)
            {
                return false;
            }
            if (Cannon != other.Cannon)
            {
                return false;
            }
            return true;
        }

        /// Перегрузка метода от object
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Battleship shipObj))
            {
                return false;
            }
            else
            {
                return Equals(shipObj);
            }
        }
    }
}
