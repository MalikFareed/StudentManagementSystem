using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0
{
    class CalculationPlanner
    {
        private Strategy strategy;

        public void SetStrategy(Strategy _strategy)
        {         
            this.strategy = _strategy;            
        }
        public double GetResult()
        {
            return strategy.Calculate();
        }
    }
}
