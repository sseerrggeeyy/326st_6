using System.Runtime.Serialization;
using System;

namespace Contract.DTO
{
    [DataContract]
    public class OrderDTO
    {
        [DataMember]
        public int OrderNo { get; set; }
        [DataMember]
        public int EmpNo { get; set; }
    }
}
