using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0._CRUD_Operations
{
    public class  ProgramCRUD
    {
        static ProgramCRUD programCRUD = null;
        SMSDbContext context;
        private ProgramCRUD()
        {
            context = SMSDbContext.getContext;
        }
        public static ProgramCRUD getProgramCRUD
        {
            get
            {
                if (programCRUD == null)
                    programCRUD = new ProgramCRUD();
                return programCRUD;
            }
                
        }
        public bool AddProgram(string _title)
        {
            var program = new Programs
            {
                Title = _title
            };
            context.Programs.Add(program);
            context.SaveChanges();
            return true;
        }
        public bool FindProgram(string _title)
        {
            var programs = context.Programs.ToList();
            foreach (var program in programs)
            {
                if (program.Title == _title)
                    return true;
            }
            return false;
        }
        public List<Programs> getAllPrograms()
        {
            var programs = context.Programs.ToList();
            return programs;
        }
        public bool UpdateProgram(Programs _program)
        {
            var program = context.Programs.Find(_program.ProgramsId);
            program.Title = _program.Title;
            context.SaveChanges();
            return true;
        }
        public bool DeleteProgram(int _pid)
        {
            var program = context.Programs.Find(_pid);
            context.Programs.Remove(program);
            context.SaveChanges();
            return true;
        }
    }
}
