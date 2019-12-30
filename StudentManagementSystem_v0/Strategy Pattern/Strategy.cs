using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0
{
    public abstract class Strategy
    {
        public int SId;
        public abstract double Calculate();
    }
}
