using System;
class pattern
{
	public static void Main()
	{
		int n;
		int i,j;
		Console.Write("enter a raw:");
		int num = Convert.ToInt32(Console.ReadLine());
		if(num%2==0)
		{
			n=num/2;
		}
		else
		{
			num--;
			n=num/2;
		}
		for(i=0;i<=num;i++)
		{
			for(j=0;j<=num;j++)
			{
				if(i==n || j==n || i<=n && j==0 || i==0 && j>n || i>n &&  j==num && j<=num || i==num && j<=n)
				{
					Console.Write(" *");
				}
				else
				{
					Console.Write("  ");
				}
			}
			Console.WriteLine();
		}
	}
}