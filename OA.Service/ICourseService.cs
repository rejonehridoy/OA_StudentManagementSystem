using System;
using System.Collections.Generic;
using OA.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public interface ICourseService
    {
        IEnumerable<Course> GetCourses();
        IEnumerable<Course> GetAllLocalCourses(int languageId);
        Course GetLocalCourse(int id, int languageId);
        Course GetCourse(int id);
        void InsertCourse(Course course);
        void UpdateCourse(Course course);
        bool DeleteCourse(int id);
    }
}
