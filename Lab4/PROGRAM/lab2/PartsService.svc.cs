using System;
using System.Collections.Generic;
using System.Linq;
using Contract.DTO;
using System.Data;
using System.Data.Entity;

namespace lab2
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "PartsService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы PartsService.svc или PartsService.svc.cs в обозревателе решений и начните отладку.
    public class PartsService : IPartsService
    {
        public void create(PartDTO entity)
        {
            DatabaseEntities de = new DatabaseEntities();
            de.Parts.Add(new Parts
            {
                Name = entity.Name,
                SerialNum = entity.SerialNum,
                VendorNo = entity.VendorNo
            });
            de.SaveChanges();
        }
        public void deleteById(int partNo)
        {
            DatabaseEntities de = new DatabaseEntities();
            Parts x = de.Parts.Where(l => l.PartNo == partNo).FirstOrDefault();

            de.Entry(x).State = EntityState.Deleted;
            de.SaveChanges();
        }
        public List<PartDTO> read()
        {
            DatabaseEntities de = new DatabaseEntities();
            return map(de.Parts.ToList());
        }
        public PartDTO readById(int id)
        {
            DatabaseEntities de = new DatabaseEntities();
            Parts x = de.Parts.Where(l => l.PartNo == id).FirstOrDefault();
            return new PartDTO
            {
                PartNo = x.PartNo,
                Name = x.Name,
                SerialNum = x.SerialNum,
                VendorNo = x.VendorNo
            };
        }

        public void update(PartDTO entity)
        {
            DatabaseEntities de = new DatabaseEntities();
            Parts x = de.Parts.Where(l => l.PartNo == entity.PartNo).FirstOrDefault();
            de.Entry(x).CurrentValues.SetValues(entity);
            de.SaveChanges();
        }
        private List<PartDTO> map(List<Parts> parts)
        {
            return parts.ToList().ConvertAll(x => new PartDTO
            {
                PartNo = x.PartNo,
                Name = x.Name,
                SerialNum = x.SerialNum,
                VendorNo = x.VendorNo
            });
        }
    }
}
