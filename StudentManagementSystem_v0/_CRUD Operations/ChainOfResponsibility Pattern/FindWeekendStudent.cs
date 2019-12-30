using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0._CRUD_Operations
{
    class FindWeekendStudent : IChian
    {
        SMSDbContext context = SMSDbContext.getContext;
        private IChian nextInChain;
        public bool Find(int _sid)
        {
            var student = context.WeekendStudents.FirstOrDefault(s => s.StudentId == _sid);
            if (student != null)
                return true;
            else
                return false;
        }

        public void SetNextChain(IChian _nextChain)
        {
            this.nextInChain = _nextChain;
        }
    }
}
