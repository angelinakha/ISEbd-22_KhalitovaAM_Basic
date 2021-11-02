using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBattleship
{
    public class DocksCollection
    {
        // Словарь (хранилище) с парковками
        readonly Dictionary<string, Docks<Vehicle>> parkingStages;
        // Возвращение списка названий праковок
        public List<string> Keys => parkingStages.Keys.ToList();
        // Ширина окна отрисовки
        private readonly int pictureWidth;
        // Высота окна отрисовки
        private readonly int pictureHeight;
        // Конструктор
        public DocksCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Docks<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        /// Добавление парковки
        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Docks<Vehicle>(pictureWidth, pictureHeight));
        }

        /// Удаление парковки
        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }

        /// Доступ к парковке
        public Docks<Vehicle> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
