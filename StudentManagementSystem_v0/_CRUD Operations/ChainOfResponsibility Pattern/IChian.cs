using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0._CRUD_Operations
{
    public interface IChian
    {
        void SetNextChain(IChian _nextChain);
        bool Find(int _sid);
    }
}
