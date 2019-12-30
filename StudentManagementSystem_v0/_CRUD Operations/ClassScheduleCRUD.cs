using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0._CRUD_Operations
{
    public class ClassScheduleCRUD
    {
        static ClassScheduleCRUD classScheduleCRUD = null;
        SMSDbContext context;
        private ClassScheduleCRUD()
        {
            context = SMSDbContext.getContext;
        }
        public static ClassScheduleCRUD getClassScheduleCRUD
        {
            get
            {
                if (classScheduleCRUD == null)
                    classScheduleCRUD =  new ClassScheduleCRUD();                
                return classScheduleCRUD;
            }
        }
        public List<ClassSchedule> getAllClassSchedules()
        {
            var classSchedules = context.ClassSchedules.ToList();
            return classSchedules;
        }
    }
}
