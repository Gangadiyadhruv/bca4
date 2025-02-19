using System;
class demo{
	public static void Main(){
		int i=0;
		Console.WriteLine("enter a raw and cloumn :-");
		int raw = Convert.ToInt32(Console.ReadLine());
		int clo = Convert.ToInt32(Console.ReadLine());
		
		int [,]a=new int[clo,raw];
		Console.WriteLine("enter a values :-");
		for(i=0;i < a.GetLength(0);i++){
			for(int j=0;j < a.GetLength(1);j++){
				a[i,j]=Convert.ToInt32(Console.ReadLine());
			}
		}
		Console.WriteLine("Print a values :-");
		for(i=0;i < a.GetLength(0);i++){
			for(int j=0;j < a.GetLength(1);j++){
				Console.WriteLine("a[{0},{1}]{2}",i,j,a[i,j]);
			}
		}
	}
}