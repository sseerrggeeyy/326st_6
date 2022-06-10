using System;
using System.Collections.Generic;
using System.Linq;
using Contract.DTO;
using System.Data;
using System.Data.Entity;

namespace lab2
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "EmployeeService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы EmployeeService.svc или EmployeeService.svc.cs в обозревателе решений и начните отладку.
    public class EmployeeService : IEmployeeService
    {
        public void create(EmployeeDTO entity)
        {
            DatabaseEntities de = new DatabaseEntities();
            de.Employee.Add(new Employee
            {
               FirstName = entity.FirstName,    
               LastName = entity.LastName,
               Age = entity.Age,
               Sex = entity.Sex,
               Phone = entity.Phone
            });
            de.SaveChanges();
        }
        public void deleteById(int empNo)
        {
            DatabaseEntities de = new DatabaseEntities();
            Employee x = de.Employee.Where(l => l.EmpNo == empNo).FirstOrDefault();

            de.Entry(x).State = EntityState.Deleted;
            de.SaveChanges();
        }
        public List<EmployeeDTO> read()
        {
            DatabaseEntities de = new DatabaseEntities();
            return map(de.Employee.ToList());
        }
        public EmployeeDTO readById(int id)
        {
            DatabaseEntities de = new DatabaseEntities();
            Employee x = de.Employee.Where(l => l.EmpNo == id).FirstOrDefault();
            return new EmployeeDTO
            {
                EmpNo = id,
                FirstName = x.FirstName,
                LastName= x.LastName,
                Age= x.Age,
                Sex = x.Sex,
                Phone = x.Phone
            };

        }
        public void update(EmployeeDTO entity)
        {
            DatabaseEntities de = new DatabaseEntities();
            Employee x = de.Employee.Where(l => l.EmpNo == entity.EmpNo).FirstOrDefault();
            de.Entry(x).CurrentValues.SetValues(entity);
            de.SaveChanges();
        }
        private List<EmployeeDTO> map(List<Employee> employee)
        {
            return employee.ToList().ConvertAll(x => new EmployeeDTO
            {
                EmpNo = x.EmpNo,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Age = x.Age,
                Sex = x.Sex,
                Phone = x.Phone
            });
        }
    }
}