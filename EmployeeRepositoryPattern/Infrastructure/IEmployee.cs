﻿using EmployeeRepositoryPattern.Models;

namespace EmployeeRepositoryPattern.Infrastructure
{
    public interface IEmployee
    {
        List<Employee> GetAll();
        Employee GetById(int Id);
        void Insert(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee);
        void Save();
    }
}
