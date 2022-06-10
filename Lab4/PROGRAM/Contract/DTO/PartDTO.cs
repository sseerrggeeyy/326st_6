using System.Runtime.Serialization;

namespace Contract.DTO
{
    [DataContract]
    public class PartDTO
    {
        [DataMember]
        public int PartNo { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string SerialNum { get; set; }
        [DataMember]
        public int? VendorNo { get; set; }
    }
}

