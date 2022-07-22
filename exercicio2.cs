using System;
//exercicio soma S
public  class Program{
        public static void Main(string[] args)
{
    float S=0;
    for(float i=1;i<=100;i++){
        S=S+(1/i);

    }
    Console.WriteLine("S = "+ S.ToString("0.00"));
}
}
