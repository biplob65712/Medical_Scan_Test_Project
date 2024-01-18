using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalScan.MODELS.EntityModels
{
    public class Doctor
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public int? SpecialtyID { get; set; }
        public Specialty? Specialty { get; set; }    
    }
}
