﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        // Разделитель для записи информации в файл
        private readonly char separator = ':';

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

        // Сохранение информации по автомобилям на парковках в файл
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine($"DocksCollection");
                foreach (var level in parkingStages)
                {
                    //Начинаем парковку
                    sw.WriteLine($"Docks{separator}{level.Key}");
                    foreach (IShip ship in level.Value)
                    {
                        if (ship != null)
                        {
                            //если место не пустое
                            //Записываем тип машины
                            if (ship.GetType().Name == "Ship")
                            {
                                sw.Write($"Ship{separator}");
                            }
                            if (ship.GetType().Name == "Battleship")
                            {
                                sw.Write($"Battleship{separator}");
                            }
                            //Записываемые параметры
                            sw.WriteLine(ship);
                        }
                    }
                }
            }
            return true;
        }

        // Загрузка информации по автомобилям на парковках из файла
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                string key = string.Empty;
                Vehicle ship = null;
                if (line.Contains("DocksCollection"))
                {
                    //очищаем записи
                    parkingStages.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    throw new FormatException("Неверный формат файла");
                }
                line = sr.ReadLine();
                while (line != null)
                {
                 //идем по считанным записям
                    if (line.Contains("Docks"))
                     {
                         //начинаем новую парковку
                         key = line.Split(separator)[1];
                         parkingStages.Add(key, new Docks<Vehicle>(pictureWidth, pictureHeight));
                         line = sr.ReadLine();
                         continue;
                     }
                    if (string.IsNullOrEmpty(line))
                     {
                         line = sr.ReadLine();
                         continue;
                     }
                    if (line.Split(separator)[0] == "Ship")
                    {
                        ship = new Ship(line.Split(separator)[1]);
                    }
                    else if (line.Split(separator)[0] == "Battleship")
                    {
                        ship = new Battleship(line.Split(separator)[1]);
                    }
                    var result = parkingStages[key] + ship;
                    if (!result)
                    {
                        throw new InvalidDataException("Не удалось загрузить корабль в доки");
                    }
                    line = sr.ReadLine();
                    }
                }
            }
        }
    }
