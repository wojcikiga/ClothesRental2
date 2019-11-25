using System.Collections;

namespace ClothesRental.Data_Layer
{
    public class UsersList
    {
        private ArrayList usersList = new ArrayList();
        public void addUser(Customer cu)
        {
            usersList.Add(cu);
        }
        public int removeUser(Customer cu)
        {
            if (!usersList.Contains(cu)) return 0;
            usersList.Remove(cu);
            return 1;
        }
        public void setUsersList(ArrayList list)
        {
            usersList.Clear();
            usersList = list;
        }

        public ArrayList getUsersList()
        {
            return usersList;
        }
    }
}