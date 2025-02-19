using System;
class demo{
	public static void Main(){
		Console.WriteLine("enter a raw and cloumn :-");
		int raw = Convert.ToInt32(Console.ReadLine());
		int clo = Convert.ToInt32(Console.ReadLine());
		
		int [,]a=new int[raw,clo];
		Console.WriteLine("enter a values :-");
		for(int i=0;i<raw;i++){
			for(int j=0;j<a.Length;j++){
				a[i,j]=Convert.ToInt32(Console.ReadLine());
			}
		}
		Console.WriteLine("Print a values :-");
		for(int i=0;i<a.GetLength(0);i++){
			for(int j=0;j<a[i].Length;j++){
				Console.WriteLine("value of raw{0} aand column {1}"+i+j+a[i][j]);
			}
		}
	}
}