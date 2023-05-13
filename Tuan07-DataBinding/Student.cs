using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan07_DataBinding
{
    // Chứa dữ liệu - Entity / DTO - Data Transfer Object
    public class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public string Avatar { get; set; }
        public int Amount { get; set; }
    }
}
