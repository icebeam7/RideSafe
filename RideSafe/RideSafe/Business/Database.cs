using System;
using System.Linq;
using System.Collections.ObjectModel;
using SQLite;

namespace RideSafe.Business
{
    public class Database : SQLiteConnection
    {
        public Database(string path) : base(path)
        {
            CreateTables();
        }

        private void CreateTables()
        {
            CreateTable<Contact>();
            CreateTable<UserInfo>();
        }

        #region ManageContacts

        public ObservableCollection<Contact> GetContacts()
        {
            return new ObservableCollection<Contact>(this.Table<Contact>().ToList());
        }

        public Contact GetContact(string id)
        {
            return (id == "") ? new Contact() : Table<Contact>().Where(t => t.ID == id).First();
        }

        public void SaveContact(string id, string name, string phoneNumber, string description)
        {
            Contact data = GetContact(id);
            data.Name = name;
            data.Description = description;
            data.PhoneNumber = phoneNumber;

            if (id == "")
                AddContact(data);
            else
                UpdateContact(data);
        }

        private void AddContact(Contact data)
        {
            data.ID = Guid.NewGuid().ToString(); 
            this.Insert(data);
        }

        private void UpdateContact(Contact data)
        { 
            this.Update(data);
        }

        public void DeleteContact(string id)
        {
            Contact data = Table<Contact>().Where(t => t.ID == id).First(); 
            this.Delete (data);
        }

        #endregion

        #region Manage UserInfo

        public UserInfo GetUserInfo()
        {
            return (Table<UserInfo>().Count() == 0) ? new UserInfo() { ID = "" } : Table<UserInfo>().First();
        }

        public void SaveUserInfo(string name, string phoneNumber, string sex, double weight, int age, string bloodType)
        {
            UserInfo data = GetUserInfo();
            data.Name = name;
            data.PhoneNumber = phoneNumber;
            data.Sex = sex;
            data.Weight = weight;
            data.Age = age;
            data.BloodType = bloodType;

            if (data.ID == "")
                AddUserInfo(data);
            else
                UpdateUserInfo(data);
        }

        private void AddUserInfo(UserInfo data)
        {
            data.ID = Guid.NewGuid().ToString();
            this.Insert(data);
        }

        private void UpdateUserInfo(UserInfo data)
        {
            this.Update(data);
        }

        #endregion
    }
}
