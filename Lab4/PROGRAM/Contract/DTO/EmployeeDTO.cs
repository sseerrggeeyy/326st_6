using System.Runtime.Serialization;

namespace Contract.DTO
{
    [DataContract]
    public class EmployeeDTO
    {
        [DataMember]
        public int EmpNo { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public string Sex { get; set; }
        [DataMember]
        public string Phone { get; set; }
    }
}

