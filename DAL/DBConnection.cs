using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnection
    {
        InterviewsManagerContext InterviewsManagerEntities= new InterviewsManagerContext();
        public List<Candidate> GetCandidates()
        {
            return InterviewsManagerEntities.Candidates.ToList();
        }

        public List<Employee> GetEmployees()
        {
            return InterviewsManagerEntities.Employees.ToList();
        }

        public List<Interview> GetInterviews()
        {
            return InterviewsManagerEntities.Interviews.ToList();
        }
    }
}