﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TCCS.DataAccess.Models;

namespace TCCS.DataAccess.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployee();
        Task<Employee> GetEmployeeById(int id);
        Task<IEnumerable<Employee>> GetEmployeeById(Expression<Func<Employee, bool>> predicate);
        Task<Employee> AddEmployeeAsync(Employee entity);
        Employee UpdateEmployee(Employee entity);
        void RemoveEmployee(Employee entity);
        Task RemoveEmployeeById(int id);

        //int SaveChanges();
        //Task<int> SaveChangesAsync();

        Task<Employee> SingleOrDefaultEmployeeAsync(Expression<Func<Employee, bool>> predicate);
        Task<Employee> FirstOrDefaultEmployeeAsync(Expression<Func<Employee, bool>> predicate);
        void AddEmployeeRange(IEnumerable<Employee> entities);
        Task AddEmployeeRangeAsync(IEnumerable<Employee> entities);
        void UpdateEmployeeRange(IEnumerable<Employee> entities);
        void RemoveEmployeeRange(IEnumerable<Employee> entities);
    }
}
