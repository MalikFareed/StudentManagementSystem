using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0._CRUD_Operations
{
    class MarksEntryCRUD
    {
        static MarksEntryCRUD marksEntryCRUD = null;
        SMSDbContext context;

        private MarksEntryCRUD()
        {
            context = SMSDbContext.getContext;
        }
        public static MarksEntryCRUD getMarksEntryCRUD
        {
            get
            {
                if (marksEntryCRUD == null)
                    marksEntryCRUD = new MarksEntryCRUD();
                return marksEntryCRUD;
            }
        }
        public bool AddMarksEntry(MarksEntry _marksEntry)
        {
            context.MarksEntries.Add(_marksEntry);
            context.SaveChanges();
            return true;
        }
        public object GetAllEnteries(int _cid)
        {
            var enteries = context.MarksEntries
                .OrderBy(e => e.ID)
                .Where(e => e.CourseID == _cid)
                .Select(e => new {
                    ID = e.ID,
                    Course = e.Course.Title,
                    StudentID = e.StudentID,                   
                    Quizes = e.Quizes,
                    Assignments = e.Assignments,
                    Project = e.Project,
                    Mid = e.Mid,
                    Final = e.Final
                });
            return enteries.ToList();
        }
        public bool RemoveEntry(int _id)
        {
            var entry = context.MarksEntries.Find(_id);
            context.MarksEntries.Remove(entry);
            context.SaveChanges();
            return true;
        }
        public bool UpdateEntry(int _id,int _quizes,int _assignments,int _project,int _mid,int _final)
        {
            var entry = context.MarksEntries.Find(_id);
            entry.Quizes = _quizes;
            entry.Assignments = _assignments;
            entry.Project = _project;
            entry.Mid = _mid;
            entry.Final = _final;

            context.SaveChanges();
            return true;
        }

        public object GetEntries(int _sid,int _cid)
        {
            context.MarksEntries.ToList();
            var entries = context.MarksEntries
                .Where(e => e.StudentID == _sid && e.CourseID == _cid)
                .Select(e => new {
                    CourseID = e.CourseID,
                    CourseName = e.Course.Title,
                    Quizes = e.Quizes,
                    Assignmnets = e.Assignments,
                    Project = e.Project,
                    Mid = e.Mid,
                    Final = e.Final
                });
            return entries.ToList();
        }
        public List<MarksEntry> GetStudentsEntries(int _sid)
        {
            return context.MarksEntries.Where(e => e.StudentID == _sid).ToList();
        }

    }
}
