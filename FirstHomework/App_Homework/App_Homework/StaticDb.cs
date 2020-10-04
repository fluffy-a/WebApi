using System.Collections.Generic;
using App_Homework.Models;

namespace App_Homework
{
    public static class StaticDb
    {
        public static  List<User> Users = new List<User>()
        {
            new User()
            {
                Id = 1,
                FirstName = "Aleksandra",
                LastName = "Todoroska",
                Address=new Address()
            
                {
                    Id=2,
                    Name="Partizanski Odredi" ,
                    Number=59

                }
            },

            new User()
        {
                Id = 2,
                FirstName = "Angela",
                LastName = "Todoroska",
                Address= new Address()
             
                {
                    Id = 3,
                    Name = "Edvard Kardelj ",
                    Number = 46

                }

        }
    };
    }
}
