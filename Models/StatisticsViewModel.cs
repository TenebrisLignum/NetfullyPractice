using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finances.Domain.Entities;

namespace Finances.Models
{
    public class StatisticsViewModel
    {
        public float earned { get; set; }
        public float spent { get; set; }
        public int arraylength { get; set; }
        public IQueryable<EntityBase> entityBase { get; set; }
        public float[][] cash { get; set; }
        public string[] dates { get; set; }
        public string FamilySearch { get; set; }
        public string DateSearch { get; set; }
        public DateTime DateSearchDate { get; set; }
        public StatisticsViewModel()
        {
            cash = new float[2][];
            dates = new string[arraylength];         
        }
    }
}
