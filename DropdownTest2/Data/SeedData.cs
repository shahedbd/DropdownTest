namespace DropdownTest2.Models;

public class SeedData
{
    public IEnumerable<Department> GetDepartmentList()
    {
        return new List<Department>
        {
            new Department { Name = "IT", Description = "IT Department"},
            new Department { Name = "HR", Description = "HR Department"},
            new Department { Name = "Finance", Description = "Finance Department"},
            new Department { Name = "Procurement", Description = "Procurement Department"},
            new Department { Name = "Legal", Description = "Procurement Department"},
        };
    }
    public IEnumerable<SubDepartment> GetSubDepartmentList()
    {
        return new List<SubDepartment>
        {
            new SubDepartment { DepartmentId = 1, Name = "QA", Description = "QA Department"},
            new SubDepartment { DepartmentId = 1, Name = "Software Development", Description = "Software Development Department"},
            new SubDepartment { DepartmentId = 1, Name = "Operation", Description = "Operation Department"},
            new SubDepartment { DepartmentId = 1, Name = "PM", Description = "Project Management Department"},
            new SubDepartment { DepartmentId = 2, Name = "Recruitment", Description = "Recruitment Department"},
        };
    }
}
