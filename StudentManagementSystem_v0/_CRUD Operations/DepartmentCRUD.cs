using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0._CRUD_Operations
{
    class DepartmentCRUD
    {
        static DepartmentCRUD departmentCRUD = null;
        SMSDbContext context;

        private DepartmentCRUD()
        {
            context = SMSDbContext.getContext;
        }
        public static DepartmentCRUD getDepartmentCRUD
        {
            get
            {
                if (departmentCRUD == null)
                    departmentCRUD = new DepartmentCRUD();
                return departmentCRUD;
            }
        }
        public bool AddDepartment(Department _department)
        {
            context.Departments.Add(_department);
            context.SaveChanges();
            return true;
        }
        public bool FindDepartmnet(string _name)
        {
            var departments = context.Departments.ToList();
            foreach (var department in departments)
            {
                if (department.Name == _name)
                    return true;             
            }
            return false;
        }
        public List<Department> GetAllDepartments()
        {
            return context.Departments.ToList();
        }
        public bool UpdateDepartment(Department _department)
        {
            var department = context.Departments.Find(_department.DepartmentId);
            department.Name = _department.Name;
            context.SaveChanges();
            return true;
        }
        public bool DeleteDepartment(int _did)
        {
            var department = context.Departments.Find(_did);
            context.Departments.Remove(department);
            context.SaveChanges();
            return true;
        }


    }
}
