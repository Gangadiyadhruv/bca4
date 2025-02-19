using System;
class demo{
	public static void Main(){
		int i=0;
		Console.Write("enter a raw and cloumn :-");				
		int dim = Convert.ToInt32(Console.ReadLine());
		int raw = Convert.ToInt32(Console.ReadLine());
		int clo = Convert.ToInt32(Console.ReadLine());
		
		int [,,]a=new int[dim,raw,clo];
		Console.WriteLine("enter a values :-");
		
		for(int k=0;k<dim;k++) {	
			for(i=0;i < a.GetLength(0);i++){
				for(int j=0;j < a.GetLength(1);j++){
					a[k,i,j]=Convert.ToInt32(Console.ReadLine());
					}
			}
		}
		Console.WriteLine("Print a values :-");
		for(int k=0;k <dim;k++){
		for(i=0;i < a.GetLength(0);i++){
			for(int j=0;j < a.GetLength(1);j++){
				Console.WriteLine("a[{0},{1},{2}]{3}",k,i,j,a[k,i,j]);
			}
		}
		}
	}
}