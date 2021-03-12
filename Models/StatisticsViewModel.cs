using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finances.Domain.Entities;

namespace Finances.Models
{
    public class StatisticsViewModel
    {
        public IQueryable<EntityBase> entityBase { get; set; }
        public float[][] cash { get; set; }
        public string[] dates { get; set; }
        public StatisticsViewModel()
        {
            cash = new float[2][];
            dates = new string[8];
        }
    }
}
