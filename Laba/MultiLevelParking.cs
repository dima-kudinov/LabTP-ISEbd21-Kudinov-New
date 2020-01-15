using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    public class MultiLevelParking
    {
        /// Список с уровнями парковки
        List<Parking<ITransport>> parkingStages;
        /// Сколько мест на каждом уровне

        private const int countPlaces = 20;
        private int pictureWidth;

        private int pictureHeight;

        /// Конструктор
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }
        /// Индексатор
        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                //Записываем количество уровней
                sw.WriteLine("CountLevels:" + parkingStages.Count);
                foreach (var level in parkingStages)
                {
                    //Начинаем уровень
                    sw.WriteLine("level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var locomotive = level[i];
                        if (locomotive != null)
                        {
                            //если место не пустое
                            //Записываем тип мшаины
                            if (locomotive.GetType().Name == "locomotive")
                            {
                                sw.Write(i + ":locomotive:");
                            }
                            if (locomotive.GetType().Name == "Teplovoz")
                            {
                                sw.Write(i + ":Teplovoz:");
                            }
                            //Записываемые параметры
                            sw.WriteLine(locomotive);
                        }
                    }
                }

            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                var strs = sr.ReadLine();
                if (strs.Contains("CountLevels"))
                {
                    int count = Convert.ToInt32(strs.Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<Parking<ITransport>>();
                }
                else
                {
                    return false;
                }

                int counter = -1;
                ITransport locomotive = null;
                while (counter < parkingStages.Count)
                {
                    strs = sr.ReadLine();
                    if (strs == "level")
                    {
                        counter++;
                        parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
                        continue;
                    }

                    if (string.IsNullOrEmpty(strs))
                    {
                        break;
                    }

                    if (strs.Split(':')[1] == "locomotive")
                    {
                        locomotive = new locomotive(strs.Split(':')[2]);
                    }
                    else if (strs.Split(':')[1] == "Teplovoz")
                    {
                        locomotive = new Teplovoz(strs.Split(':')[2]);
                    }
                    parkingStages[counter][Convert.ToInt32(strs.Split(':')[0])] = locomotive;
                }
            }
            return true;
        }
    }
}
