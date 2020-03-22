using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //////////////////N-1
            double a=16.80,b=12.40;
            Console.WriteLine(Math.Sqrt(a*b));

            /// /////////////////N-2
            Console.WriteLine("Задания 2");
            double A=1.40,B=-5.50,C=0.60,AC,BC;
            AC=Math.Abs(A-C);
            BC=Math.Abs(B-C);
            Console.WriteLine(AC);
            Console.WriteLine(BC);
            Console.WriteLine(AC+BC);
            
            ////////////////////N-3
            Console.WriteLine("Задания 3");
            double x1=-6.20,x2=2.10,y1=5.20,y2=9.80,AB;
            AB=Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
            Console.WriteLine(AB);

            ////////////////////////N-4
            Console.WriteLine("Задания 4");
            int a1=41,b1,c;
            b1=a1%10;
            c=a1/10;
            a=b1*10+c;
            Console.WriteLine(a);
            
            ///////////////////N-5
            Console.WriteLine("Задания 5");
            int N=10985,n;
            n=N/3600;///так как 1час=3600сек;
            Console.WriteLine(n);

            //////////////////////N-6
            Console.WriteLine("Задания 6");
            int k=202,Nomernedeli;
            Nomernedeli=k%7;
            Console.WriteLine(Nomernedeli);
             
        }
    }
}
