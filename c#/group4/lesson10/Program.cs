using System;

namespace lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact [] contacts = new Contact[0];
            bool isTrue = true;
            while(isTrue)
            {
                System.Console.WriteLine("Enter the number");
                int temp = Convert.ToInt32(Console.ReadLine());

                switch(temp)
                {
                    case 1:
                        System.Console.WriteLine("Name");
                        string name = Console.ReadLine();
                        System.Console.WriteLine("Phone");
                        long number = Convert
                            .ToInt64(Console.ReadLine());
                        Contact contact = new Contact(name, number);
                        Contact [] arr = new Contact
                        [contacts.Length+1];
                        for (int i = 0; i < contacts.Length; i++)
                        {
                            arr[i] = contacts[i];
                        }
                        arr[arr.Length - 1] = contact;
                        contacts = arr;
                        break;

                    case 2:
                        System.Console.WriteLine("Enter the index");
                        int idx = 
                        Convert.ToInt32(Console.ReadLine());
                        Contact [] arr2 = new Contact
                        [contacts.Length-1];
                        
                        for (int i = 0, j = 0; 
                            i < contacts.Length; i++)
                        {
                            if(i == idx)
                                continue;
                            arr2[j] = contacts[i];
                            j++;
                        }

                        contacts = arr2;
                        break;
                    default:
                        System.Console.WriteLine("Error");
                        isTrue = false;
                        break;
                }
            }


            foreach(Contact c in contacts)
            {
                System.Console.WriteLine(c);
            }
        }
    }
}
