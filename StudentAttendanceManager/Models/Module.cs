using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceManager.Models
{
    public class Module
    {
        public int Id { get; set; }
        public string Code { get; set; }    
        public string Name { get; set; }   
        public int Credits { get; set; }
        public DateTime Created { get; set; }
    }
}
