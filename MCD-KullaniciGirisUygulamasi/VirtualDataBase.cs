using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KullaniciGirisUygulamasi
{
    public class VirtualDataBase
    {
        public static List<User> Users = new List<User>();
        static VirtualDataBase()
        {
            Users.Add(new User()
            {
                id = 1001,
                name = "Hakan",
                lastName = "Darak",
                userName = "hakandarak",
                password = "1",
                explanation = "Hakan Darak's profile information"
            });

            Users.Add(new User()
            {
                id = 1002,
                name = "Serkan",
                lastName = "Darak",
                userName = "serkandarak",
                password = "2",
                explanation = "Serkan Darak's profile information"
            });

            Users.Add(new User()
            {
                id = 1003,
                name = "Mehmet",
                lastName = "Darak",
                userName = "mehmetdarak",
                password = "3",
                explanation = "Mehmet Darak's profile information"
            });
        }

    }
}
