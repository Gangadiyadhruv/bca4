using System;
class demo{
	public static void Main()
	{
		int i;
		Console.WriteLine("Enter a value :");
		int num= Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter a value :"+ num);
		
		for (i=1;i<=num;i++)
		{
			Console.Write("\n"+i);
		}
		Console.Read();
	}
}