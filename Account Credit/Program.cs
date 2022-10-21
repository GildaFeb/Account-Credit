using System;

namespace Account_Credit
{
    internal class Program
    {
        struct Person
        {
            public string lastname, firstname, middlename, address;
            public int age;
            public double cashbalance;
            public String setInfo
            {
                set;
                get;

            }

            public void display()
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("   ACCOUNT CREDIT INFORMATION\n");
                Console.WriteLine("  Name: {0}, {1} {2}", lastname, firstname, middlename);
                Console.WriteLine("  Age: {0} year/s old", age);
                Console.WriteLine("  Address: {0}", address);
                Console.WriteLine("  Cash Balance: PHP {0} ", cashbalance);
            }


        }
        public static String choose;
        static void Main(string[] args)
        {
            Console.WriteLine("\n   ACCOUNT CREDIT INFORMATION");
            Person p = new Person();

            for (; ; )
            {
                Console.WriteLine("================================\n");

                Console.Write(" Enter\n   <1> Start\n   <2> Exit\n   :");
                choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":

                        for (; ; )
                        {


                            Console.WriteLine("================================\n");
                            Console.Write(" Enter\n  ] Last name: ");
                            p.lastname = Console.ReadLine();
                            Console.Write("  ] First name: ");
                            p.firstname = Console.ReadLine();
                            Console.Write("  ] Middle name: ");
                            p.middlename = Console.ReadLine();
                            for (; ; )
                            {
                                try
                                {

                                    Console.Write("  ] Age: ");
                                    p.age = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("  ] Address: ");
                                    p.address = Console.ReadLine();


                                    break;
                                }
                                catch (Exception e)
                                {
                                    // ========================= !  EXCEPTION HANDLING   ! ====================================
                                    Console.WriteLine("------------------------------");
                                    Console.WriteLine(" ! NUMBER ONLY. Try again  !");
                                    Console.WriteLine("------------------------------");
                                }

                            }
                            break;

                        }
                        for (; ; )
                        {

                            try
                            {

                                Console.Write("  ] Cash Balance: ");
                                p.cashbalance = Convert.ToDouble(Console.ReadLine());



                                break;
                            }
                            catch (Exception e)
                            {
                                // ========================= !  EXCEPTION HANDLING   ! ====================================
                                Console.WriteLine("------------------------------");
                                Console.WriteLine(" ! NUMBER ONLY. Try again  !");
                                Console.WriteLine("------------------------------");
                            }

                        }
                        p.display();
                        break;
                    case "2":
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("------------------------------");
                        Console.WriteLine(" ! NUMBER ONLY. Try again  !");
                        Console.WriteLine("------------------------------");
                        break;
                }




            }
        }
    }
}
