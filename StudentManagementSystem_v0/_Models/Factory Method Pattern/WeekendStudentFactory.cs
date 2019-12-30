﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0
{
    class WeekendStudentFactory : StudentFactory
    {
        public override IStudent CreateStudent()
        {
            return new WeekendStudent();
        }
    }
}
