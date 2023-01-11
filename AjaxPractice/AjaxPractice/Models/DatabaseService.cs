using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxPractice.Models
{
    public class DatabaseService
    {
        private List<UserData> userData = new List<UserData>();

        public void Add(UserData data) {
            userData.Add(data);
        }

        public List<UserData> Get() {
            return userData;
        }

        public UserData GetById(int id) {
            foreach (UserData item in userData) {
                if (item.Id == id) {
                    return item;
                }
            }
            return null;
        }

        public bool Search(int id) {
            foreach (UserData item in userData)
            {
                if (item.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public void Update(UserData data) {
            foreach (UserData item in userData)
            {
                if (item.Id == data.Id)
                {
                    item.Name = data.Name;
                    break;
                }
            }
        }

        public void Delete(UserData data) {
            foreach (UserData item in userData)
            {
                if (item.Id == data.Id)
                {
                    userData.Remove(item);
                    break;
                }
            }

        }


    }
}
