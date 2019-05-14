using System;

namespace workProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            
            registary user = new registary();
            user.Username = "Hello world";
            //registary pass = new registary();
            user.Password = "Abcd1234";

            do
            {
                Console.WriteLine("enter password above 8 charaters with 1 big letter & 1 small & l number");
                user.Password = Console.ReadLine();
            } while (user.Password == "");
            
            Console.WriteLine(user.Password);
        }
    }
    class registary
    {
        string username;
        string password;

        
        public string Username
        {
            set { if (value.Length < 8) username = value; }
            get { return username; }
        }
        public string Password
        {
            set
            {
                int counterbchar = 0, counterschar = 0, counterint = 0, i = 0;
                for (i = 0; i < (value.Length); i++)
                {
                    if ((value[i]) >= 'A' && (value[i]) <= 'Z')
                        counterschar++;
                    else if ((value[i]) >= 'a' && (value[i]) <= 'z')
                        counterbchar++;
                    else if ((value[i]) >= '0' && (value[i]) <= '9')
                        counterint++;
                    else if (counterbchar + counterschar >= 8 && counterschar >= 1 && counterbchar >= 1 && counterint >= 1)
                    {
                        password = value;
                        return;
                    }
                    password = "";
                }

            }


            get
            {
                return password;
            }









        }


    }
}






