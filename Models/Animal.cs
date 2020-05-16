using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldJNodz.Models
{
    public class Animal
    {
        public int ID { get; set; }

        public String Name { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get ; set;  }

        
        public Species AnimalSpecies { get; set; }
    }
}
