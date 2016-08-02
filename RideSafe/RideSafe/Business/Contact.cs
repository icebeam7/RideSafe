using System;
using SQLite;

namespace RideSafe.Business
{
    [Table("Contact")]
    public class Contact
    {
        [PrimaryKey]
        public string ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
    }
}
