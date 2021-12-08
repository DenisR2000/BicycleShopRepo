using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiicycleShopDb.Models
{
    public class Cart
    {
        private List<BicycleLine> lineCollection = new List<BicycleLine>();
        public void AddItem(Bicycle bicycle, int quatity) // добавление товара 
        {
            BicycleLine line = lineCollection.Where(x => x.Bicycle.BicycleId == bicycle.BicycleId).FirstOrDefault(); // поиск существующего автомобиля
            if (line == null) // если такого авто нет 
            {
                lineCollection.Add(new BicycleLine
                {
                    Bicycle = bicycle,
                    Quantity = quatity
                });
            }
            else
            {
                line.Quantity += quatity;
            }
        }
        public void RemoveLine(Bicycle bicycle)
        {
            BicycleLine line = lineCollection.Find(x => x.Bicycle.BicycleId == bicycle.BicycleId);
            if(line.Quantity > 1)
            {
                line.Quantity -= 1;
            }
            else if(line.Quantity == 1)
            {
                lineCollection.RemoveAll(x => x.Bicycle.BicycleId == bicycle.BicycleId);
            }
        }
        public void Clear()
        {
            lineCollection.Clear();
        }
        public decimal CoomputTotralValue()
        {
            return lineCollection.Sum(x => x.Bicycle.Prise * x.Quantity);
        }
       
        public IEnumerable<BicycleLine> Lines => lineCollection;

    }
    public class BicycleLine
    {
        public Bicycle Bicycle { get; set; } 
        public int Quantity { get; set; }
    }
}
