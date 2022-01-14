using EFDemo.DBContext;
using EFDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            findUser(1);
            editUser(1);
            findUser(1);
            deleteUser(1);
            findUser(1);

            Console.WriteLine("Press any key to close ...");
            Console.ReadKey();
        }

        private static void addUser()
        {
            Console.WriteLine("addUser()");

            User newUser = new User()
            {
                Name = "Andi Arbeit",
                Email = "andi@arbeit.at"
            };

            try
            {
                using(var context = new UserContext())
                {
                    context.Users.Add(newUser);
                    context.SaveChanges();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void findUser(int id)
        {
            Console.WriteLine($"findUser({id})");

            try
            {
                using (var context = new UserContext())
                {
                    var user = context.Users.Find(id);

                    if (user != null)
                        Console.WriteLine($"Found: {user.UserID}\t{user.Name}\t{user.Email}");
                    else
                        Console.WriteLine($"User (id={id}) not found");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private static void editUser(int id)
        {
            Console.WriteLine($"editUser({id})");

            try
            {
                using(var context = new UserContext())
                {
                    var user = context.Users.Find(id);
                    
                    if(user != null)
                    {
                        user.Name = "Bela Stung";
                        context.SaveChanges();
                    }
                    else
                        Console.WriteLine($"User (id={id}) not found");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void deleteUser(int id)
        {
            Console.WriteLine($"deleteUser({id})");

            try
            {
                using (var context = new UserContext())
                {
                    var user = context.Users.Find(id);

                    if (user != null)
                    {
                        context.Users.Remove(user);
                        context.SaveChanges();
                    }
                    else
                        Console.WriteLine($"User (id={id}) not found");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
