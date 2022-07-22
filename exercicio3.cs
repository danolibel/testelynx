using System;
public   class Program
    {
       public  static void Main(string[] args)
        {
           double r=0;
		   double s=0, t=0, f=0;
            string input;

           Console.WriteLine("Digite as informações");
           input = Console.ReadLine();
           string[] split = input.Split(' ');
           //verificação 
		   if(Convert.ToDouble(split[0])>=0 && Convert.ToDouble(split[0])<=23){ 
		   s=Convert.ToDouble(split[0]); } else{Console.WriteLine("Horario de Partida Inválido"); }
		   if(Convert.ToDouble(split[1])>=1 && Convert.ToDouble(split[1])<= 12){
		   t=Convert.ToDouble(split[1]);}else{Console.WriteLine("Tempo de Viagem Inválido"); }
		   if(Convert.ToDouble(split[2])>=-5 && Convert.ToDouble(split[2]) <=5 ){
		   f=Convert.ToDouble(split[2]);}else{Console.WriteLine("Fuso Horario Inválido"); }
           
            r = s+t+f;
           
                if (r>=24 ){
                    r=r-24;
                }
		   		if (r<0 ){
                    r=r+24;
                }
                
		   Console.WriteLine(r.ToString("0"));
                
           Console.ReadLine();

    }
    }