using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCRUD.Logic.Model
{
    public class GameModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool isAvailable { get; set; }
    }
}
