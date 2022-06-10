using System;
using System.Collections.Generic;
using System.Linq;
using Contract.DTO;
using System.Data;
using System.Data.Entity;
namespace lab2
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "ItemService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы ItemService.svc или ItemService.svc.cs в обозревателе решений и начните отладку.
    public class ItemService : IItemService
    {
        public void create(ItemDTO entity)
        {
            DatabaseEntities de = new DatabaseEntities();
            de.Items.Add(new Items
            {
               OrderNo = entity.OrderNo,
               PartNo = entity.PartNo,
               Count = entity.Count
            });
            de.SaveChanges();
        }
        public void deleteById(int ItemNo)
        {
            DatabaseEntities de = new DatabaseEntities();
            Items x = de.Items.Where(l => l.ItemNo == ItemNo).FirstOrDefault();

            de.Entry(x).State = EntityState.Deleted;
            de.SaveChanges();
        }
        public List<ItemDTO> read()
        {
            DatabaseEntities de = new DatabaseEntities();
            return map(de.Items.ToList());
        }
        public ItemDTO readById(int id)
        {
            DatabaseEntities de = new DatabaseEntities();
            Items x = de.Items.Where(l => l.ItemNo == id).FirstOrDefault();
            return new ItemDTO
            {
                ItemNo = x.ItemNo,
                OrderNo = x.OrderNo,
                PartNo = x.PartNo,
                Count = x.Count
            };

        }
        public void update(ItemDTO entity)
        {
            DatabaseEntities de = new DatabaseEntities();
            Items x = de.Items.Where(l => l.ItemNo == entity.ItemNo).FirstOrDefault();
            de.Entry(x).CurrentValues.SetValues(entity);
            de.SaveChanges();
        }
        private List<ItemDTO> map(List<Items> items)
        {
            return items.ToList().ConvertAll(x => new ItemDTO
            {
                ItemNo = x.ItemNo,
                OrderNo = x.OrderNo, 
                PartNo = x.PartNo,
                Count = x.Count
            });
        }
        
    }
}