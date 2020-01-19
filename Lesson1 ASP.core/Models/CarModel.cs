using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string MarkName { get; set; }
        public int MaxSpeed { get; set; }
        public DateTime ProductionDate { get; set; }
        public string GetDate()
        {
            return $"{ProductionDate.Day}/{ProductionDate.Month}/{ProductionDate.Year}";
        }
    }
}
