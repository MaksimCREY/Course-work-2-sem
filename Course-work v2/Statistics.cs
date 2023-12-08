// Statistics.cs
using System;
using System.Collections.Generic;
using System.Linq;

public class Statistics
{
    private List<Employee> employees;

    public Statistics(List<Employee> employees)
    {
        this.employees = employees ?? throw new ArgumentNullException(nameof(employees), "Employees list cannot be null.");
    }

    public double CalculateTotalSalary()
    {
        return employees.Sum(e => e.CalculateSalary());
    }

    public Employee GetOldestEmployee()
    {
        if (employees.Count == 0)
            return null;

        return employees.OrderByDescending(e => e.Age).FirstOrDefault();
    }

    public Employee GetYoungestEmployee()
    {
        if (employees.Count == 0)
            return null;

        return employees.OrderBy(e => e.Age).FirstOrDefault();
    }

    // Дополнительные методы для статистических вычислений
}
