using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsBattleship
{
    public class Battleship : Ship
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
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
    }
}
