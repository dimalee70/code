using System;

namespace lesson8
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Enter text");
            string tempString = Console.ReadLine();
            string [] arrString = tempString.Split(" ",StringSplitOptions.RemoveEmptyEntries);  
            string t = "";
            for(int i=0; i<arrString.Length; i++)
                t+=arrString[i][arrString[i].Length-1];

            System.Console.WriteLine(t);    


            System.Console.WriteLine("Enter text");
            string tempString2 = Console.ReadLine();
            int sum=0;
            for(int i=0; i<tempString2.Length; i++)
            {
                if((int)tempString2[i]>=65 && (int)tempString2[i]<=90){
                    if(i==0)sum++;
                    else if(tempString2[i-1]==' ')sum++;
                }
            }
            System.Console.WriteLine("Enter text");
            string tempString3=Console.ReadLine();
            tempString3 = tempString3.Trim();
            System.Console.WriteLine(tempString3);
            for(int i=0; i<tempString3.Length; i++){
                if(i!=0 && tempString3[i] == ' ' && tempString3[i-1]!=' '){
                    tempString3.Remove(i,1);
                }
            }
            System.Console.WriteLine("Enter text");
            string tempString4=Console.ReadLine();
            char c = (char)Console.Read();
            for(int i=tempString4.Length-1; i>=0;i--){
                if(char.ToLower(tempString4[i])==char.ToLower(c)) System.Console.WriteLine(i);
            }
            
            System.Console.WriteLine("Enter text");
            string tempString5=Console.ReadLine();
            char c2=(char)Console.Read();
            tempString5.Replace(c2,'*');

        }


        





        static double sum(double x, double y)
        {
            return x+y;
        }
        static double minus(double x, double y)
        {
            return x-y;
        }
        static double umn(double x, double y)
        {
            return x*y;
        }
        static double del(double x, double y)
        {
            return x/y;
        }
        static string str(params string [] str){
            for(int i=0; i<str.Length; i++){
                for(int j=0; j<str.Length-1; j++){
                    if(str[j+1].Length>str[j].Length){
                        string temp = str[j+1];
                        str[j+1]=str[j];
                        str[j]=temp;
                    }
                }
            }
            return str[0];
        }

        static int NOD (int x, int y){
            if(y==0)return x;
            return NOD(y,x%y);
        }
        static int NOK (int x, int y){
            return x*y/NOD(x,y);
        }
        

        static void bDay (int []arr, string [] name){
            for (int i=0; i<arr.Length; i++)
                System.Console.WriteLine(arr[i]+" "+name[i]);
        }
        static void inArr (int i, string [] name){
            System.Console.WriteLine(name[i]);
        }
    }
}
