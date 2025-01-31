using System;
class demo
{
	public static void Main()
	{
		int num=10;
		
		Console.WriteLine("Enter a value :");
		num= Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter a value :"+ num);
		
		while (num > 0)
		{
			System.Console.Write("\n"+num);
			num--;
		}
		System.Console.Read();
	}
}