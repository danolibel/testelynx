using System;

public  class Program{
        public static void Main(string[] args)
{
    int N,S;
    Console.WriteLine("Digite o valor N de circulos:");
			N=int.Parse(Console.ReadLine());
			if (N>=0){
				if(N<=10000){
			S=((N+1)*(N+2))/2;
				Console.WriteLine(S);
							}
					}else{
			Console.WriteLine("Digite um numero entre o e 10.000");
						}
				
		}
}
