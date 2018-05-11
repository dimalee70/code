using System;
namespace lesson3{
    class Fraction{
        private int numerator;
        private int denumerator;

        public Fraction(int n,int d){
            this.numerator = n;
            this.denumerator = d;
        }
        public string Nurtilek()
        {
            return  numerator+"/"+denumerator;
        }
        public void Aruzhan(){
            System.Console.WriteLine(numerator + "/"+denumerator);
        }
        public void simplify(){
            double r = (double)numerator/denumerator; 
            while ((r*denumerator)%1 != 0){
                denumerator++;
            }
            numerator = (int)Math.Round(denumerator*r);
            System.Console.WriteLine(numerator + "/" + denumerator);
        }
    }
}