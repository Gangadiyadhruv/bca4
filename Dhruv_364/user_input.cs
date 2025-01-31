using System;
class demo
{
	public static void Main()
	{
		int num;
		double dnum;
		float f;
		string name;
		
		Console.WriteLine("Enter a name :");
		name = Console.ReadLine();
		Console.WriteLine("name is:"+ name);
		
		Console.WriteLine("Enter a value :");
		num= Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("value is  :"+ num);
		
		Console.WriteLine("Enter a double :");
		dnum= Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("double is :"+dnum);
		
		Console.WriteLine("Enter a float :");
		f = float.Parse(Console.ReadLine());
		Console.WriteLine(f);
		
		
		
	}
}