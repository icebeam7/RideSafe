using System;
using SQLite;

namespace RideSafe.Business
{
    [Table("UserInfo")]
    public class UserInfo
    {
        [PrimaryKey]
        public string ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Sex { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public string BloodType { get; set; }
    }
}
