using System;
using System.Collections;
using System.Collections.Generic;

namespace lesson2_8
{
    public class UserRepository : IEnumerable<User>
    {
        public List<User> userList{get;set;}

        public object Current => throw new NotImplementedException();

        public UserRepository(List<User> userList)
        {
            this.userList = userList;
        }

        public void sortList()
        {
            userList.Sort();
            printAll();
        }

        public void printAll()
        {
            foreach(User u in userList)
            {
                System.Console.WriteLine(u);
            }
        }

        public IEnumerator<User> GetEnumerator()
        {
            foreach(User u in userList)
            {
                if(u.id == 5)
                    yield break;
                yield return u;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return userList.GetEnumerator();
        }
    }
}