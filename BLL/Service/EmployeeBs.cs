﻿using BOL;
using DAL;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Service
{
    public class EmployeeBs
    {
        private EmployeeDb ObjDb;

 
        public List<string> Errors = new List<string>();

        public EmployeeBs()
        {
            ObjDb = new EmployeeDb();
        }
        public IEnumerable<Employee> GetALL()
        {
            return ObjDb.GetALL();
        }
        public Employee GetByID(string Id)
        {
            return ObjDb.GetByID(Id);
        }     

        public bool Insert(Employee emp)
        {
            if (IsValidOnInsert(emp))
            {
                ObjDb.Insert(emp);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Delete(string Id)
        {
            ObjDb.Delete(Id);
        }
        public bool Update(Employee emp)
        {
            if (IsValidOnUpdate(emp))
            {
                ObjDb.Update(emp);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Employee GetByEmail(string email)
        {
            return ObjDb.GetByEmail(email);
        }
        public Employee RecoverPasswordByEmail(string email)
        {
            var emp=ObjDb.GetByEmail(email);
            return emp;
        }

        public bool IsValidOnInsert(Employee emp)
        {
            EmployeeBs employeeObjBs = new EmployeeBs();

            //Unique Employee Id Validation
            string EmployeeIdValue = emp.EmployeeId.ToString();
            int count = employeeObjBs.GetALL().Where(x => x.EmployeeId == EmployeeIdValue).ToList().Count();
            if (count != 0)
            {
                Errors.Add("EmployeeId Already Exist");
            }

            //Unique Email Validation
            string EmailValue = emp.Email.ToString();
            count = employeeObjBs.GetALL().Where(x => x.Email == EmailValue).ToList().Count();
            if (count != 0)
            {
                Errors.Add("Email Already Exist");
            }

            if (Errors.Count() == 0)
                return true;
            else
                return false;
        }

        public bool IsValidOnUpdate(Employee emp)
        {

            //Total Exp should be greater than Relevant Exp
            var TotalExpValue = emp.TotalExp;
            var RelevantExpValue = emp.RelevantExp;

            if (RelevantExpValue > TotalExpValue)
            {
                Errors.Add("Total Exp should be greater than Relevant Exp");
            }

            if (Errors.Count() == 0)
                return true;
            else
                return false;
        }
    }
}