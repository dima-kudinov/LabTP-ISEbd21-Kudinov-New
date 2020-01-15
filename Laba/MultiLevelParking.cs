using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    public class MultiLevelParking
    {
        /// Список с уровнями парковки
        List<Parking<ITransport, IVagon>> parkingStages;
        /// Сколько мест на каждом уровне

        private const int countPlaces = 20;
        /// Конструктор
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport, IVagon>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITransport, IVagon>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }
        /// Индексатор
        public Parking<ITransport, IVagon> this[int ind]
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

        public ITransport this[int ind, int key]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind].GetTrainByKey(key);
                }
                return null;
            }
        }
    }
}
