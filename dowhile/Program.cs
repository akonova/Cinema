using System;

namespace dowhile
{
    class Program
    {


        static void Main(string[] args)
        {


            {
              
                int price =5;
                string UsersChoice;
                Console.WriteLine("Do you want to see a movieslist? Type Yes or No");
                UsersChoice = Console.ReadLine().ToUpper();

                if (UsersChoice == "YES")
                {
                    Start:
                    Console.WriteLine("Which Film do you want to see? Type A , B or C");
                    UsersChoice = Console.ReadLine().ToUpper();

                    switch (UsersChoice)
                    {
                        case "A":
                        case "B":
                        case "C":
                          
                            Console.WriteLine(" Your choice is movie {0}. How many tickets do you want to buy?", UsersChoice);
                            int ticketsnumber = int.Parse(Console.ReadLine());
                            Films.CountTicketsRest(ticketsnumber);

                            int c = ticketsnumber * price;
                            Console.WriteLine(" Your buy cost is: {0}.   Do you want to continue shoping?", Convert.ToString(c));
                            UsersChoice =  Console.ReadLine().ToUpper(); ;
                            if (UsersChoice == "YES")
                                goto Start;
                            else Console.WriteLine("We see you late");
                                                                         

                            break;
                          
                           
                        default:
                            Console.WriteLine("We don't show movie {0} . Do you want to see movie list again ? Type Yes or No", UsersChoice);
                            UsersChoice = Console.ReadLine().ToUpper();
                            if (UsersChoice == "YES")
                                goto Start;
                            else if (UsersChoice == "NO")
                                Console.WriteLine("We see you late");
                            
                            break;

                            }
                           
                    }
              
                else if (UsersChoice == "NO")
                    Console.WriteLine("We see you late");
                Console.ReadLine();

                {

                    




                }
               /* else
                    Console.WriteLine("Invalid value. Type again YES or NO");*/
               
                
                          
                



       
            }




        }

    }
}
    




