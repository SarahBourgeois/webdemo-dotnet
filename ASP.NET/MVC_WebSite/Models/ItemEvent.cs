using MVC_WebSite.Models.EDM;
using System.Collections.Generic;
using System.Linq;


namespace MVC_WebSite.Models
{
    public class ItemEvent
    {
        static BDD access = new BDD();
        static ItemData id = new ItemData();

        // add a new Item
        public static User AddItem(string login)
        {
            var userid = (from u in access.User
                          where u.login == login
                          select u).Single();
            return userid;
        }

        // Build item list to display
        public static List<Item> InitItemList(string session)
        {
            List<Item> itemList;
            itemList = (from u in access.User
                        from i in access.Item
                        where u.Id == i.user && u.login == session
                        select i).ToList();
            return itemList;
        }

        // Display items
        public static Item displayItem(string idUrl, string session)
        {
            if (session == null) { return null; }
            return (from i in access.Item
                    where idUrl == i.Id.ToString()
                    select i).Single();

        }

        // Modifiy an item thanks to its id
        public static void ModifyItem(string idUrl, string n, string d)
        {
            var modidy = (from i in access.Item
                          where idUrl == i.Id.ToString()
                          select i).Single();
            if (modidy == null) { return; }
            else
            {
                modidy.name = n;
                modidy.description = d;
                access.SaveChanges();
            }
        }
    
        // Suppress an item
        public static void SuppressItem(string idUrl)
        {
            var delete = (from i in access.Item
                          where idUrl == i.Id.ToString()
                          select i).Single();
            access.Item.Remove(delete);
            access.SaveChanges();
        }
    }
}