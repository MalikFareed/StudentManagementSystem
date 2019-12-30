using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0._CRUD_Operations
{
    class FindMorningStudent : IChian
    {
        SMSDbContext context = SMSDbContext.getContext;
        private IChian nextInChain;
        public bool Find(int _sid)
        {
            bool found;
            var student = context.MorningStudents.FirstOrDefault(s => s.StudentId == _sid);
            if (student != null)
                found =  true;
            else
                found = nextInChain.Find(_sid);
            return found;
        }

        public void SetNextChain(IChian _nextChain)
        {
            this.nextInChain = _nextChain;
        }
    }
}
