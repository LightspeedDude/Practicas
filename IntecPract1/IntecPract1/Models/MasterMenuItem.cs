using System;
using System.Collections.Generic;
using System.Text;

namespace IntecPract1.Models
{
    public class MasterMenuItem
    {
        public MasterMenuItem()
        {
            TargetType = typeof(MasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}
