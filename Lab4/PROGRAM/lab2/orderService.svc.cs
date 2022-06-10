using System;
using System.Collections.Generic;
using System.Linq;
using Contract.DTO;
using System.Data;
using System.Data.Entity;

namespace lab2
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "OrderService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы OrderService.svc или OrderService.svc.cs в обозревателе решений и начните отладку.
    public class OrderService : IOrderService
    {
        public void create(OrderDTO entity)
        {
            DatabaseEntities de = new DatabaseEntities();
            de.Orders.Add(new Orders
            {
                EmpNo = entity.EmpNo
            });
            de.SaveChanges();
        }
        public void deleteById(int OrderNo)
        {
            DatabaseEntities de = new DatabaseEntities();
            Orders x = de.Orders.Where(l => l.OrderNo == OrderNo).FirstOrDefault();

            de.Entry(x).State = EntityState.Deleted;
            de.SaveChanges();
        }
        public List<OrderDTO> read()
        {
            DatabaseEntities de = new DatabaseEntities();
            return map(de.Orders.ToList());
        }
        public OrderDTO readById(int id)
        {
            DatabaseEntities de = new DatabaseEntities();
            Orders x = de.Orders.Where(l => l.OrderNo == id).FirstOrDefault();
            return new OrderDTO
            {
                OrderNo = x.OrderNo,
                EmpNo = x.EmpNo
            };

        }
        public void update(OrderDTO entity)
        {
            DatabaseEntities de = new DatabaseEntities();
            Orders x = de.Orders.Where(l => l.OrderNo == entity.OrderNo).FirstOrDefault();
            de.Entry(x).CurrentValues.SetValues(entity);
            de.SaveChanges();
        }
        private List<OrderDTO> map(List<Orders> orders)
        {
            return orders.ToList().ConvertAll(x => new OrderDTO
            {
                OrderNo = x.OrderNo,
                EmpNo = x.EmpNo
            });
        }
    }
}