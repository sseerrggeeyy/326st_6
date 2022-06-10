using System.Runtime.Serialization;

namespace Contract.DTO
{
    [DataContract]
    public class ItemDTO
    {
        [DataMember]
        public int ItemNo { get; set; }
        [DataMember]
        public int OrderNo { get; set; }
        [DataMember]
        public int PartNo { get; set; }
        [DataMember]
        public int Count { get; set; }
    }
}

