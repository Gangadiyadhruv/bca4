using System;
class user {
	public static void Main() {
		int sum=0;
		Console.WriteLine("enter a first raw :-");
		int raw = Convert.ToInt32(Console.ReadLine());
		
		int [][]a=new int [raw][];
		Console.WriteLine("enter a column:-");
		int clo = Convert.ToInt32(Console.ReadLine());
		
		for (int j=0;j<clo;j++){
			
			Console.WriteLine("enter a second raw :-");
			int b1 = Convert.ToInt32(Console.ReadLine());
			a[j]=new int[b1];
			
		}
		
		for (int i=0;i<raw;i++)
		{
			for(int j=0;j<a.Length;j++)
			{
				Console.Write("enter a value for rae{0} and column{1}:-",i,j);
				a[i][j] = Convert.ToInt32(Console.ReadLine());
			}				
			
		}
		//print a value
		
		for(int i=0;i<a.Length;i++)
		{
			for(int j=0;j<a[i].Length;j++)
			{
				Console.WriteLine("value raw {0} and cloumn {1}",i,j);
				Console.Write(a[i][j]);
			}
			Console.WriteLine();
		}
		
		//sum of each raw 
		for(int i=0;i<a.Length;i++)
		{
			for(int j=0;j<a[i].Length;j++)
			{
				sum = sum + a[i][j];
				Console.WriteLine(a[i][j]+ "  "+sum);
			
				//sum += a[i][j];
				
				//Console.WriteLine(sum);
				
			}
		}
	}
}