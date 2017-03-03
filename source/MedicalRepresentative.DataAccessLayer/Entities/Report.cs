using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalRepresentative.DataAccessLayer.Entities
{
    public class Report
    {
        public int Id { get; set; }
        public int WorkerId { get; set; }
        public virtual Worker Worker { get; set; }
        public DateTime Date { get; set; }
    }
}
