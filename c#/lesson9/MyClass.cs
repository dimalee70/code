using System;
namespace lesson9{
    class MyClass{
        int k;
        public char ch;
        public MyClass(int i){
            k = i;
        }
        ~MyClass(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Объект {0} уничтожен", k);
        }
        public int GetSetI{
            get{
                return k;
            }
            set{
                k = value;
            }
        }
        public void Method1(char ch)
        {
            ch = ch;
        }
        public void Method2(char ch)
        {
            this.ch = ch;
        }

    }
}