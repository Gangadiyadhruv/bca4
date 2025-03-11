using System;
class slary
{
	public void fun(ref double basic,out double ta,out double da,out double hra,out double pa)
	{
		
		if(basic >=35000 && basic <=45000)
		{
			ta=(basic*5)/100;
			da=(basic*5)/100;
			hra=(basic*15)/100;
			pa=(basic*8.5)/100;
			
			basic+=(ta+da+hra);
			basic-=pa;
			
		}
		else if(basic<35000)
		{
			ta=(basic*9)/100;
			da=(basic*12)/100;
			hra=(basic*20)/100;
			pa=(basic*8.5)/100;
			
			basic+=(ta+da+hra);
			basic-=pa;
			
		}
		else
		{
			Console.WriteLine("you gross slary is more then 45000");
			 ta=0;
			 da=0;
			 hra=0;
			 pa=0;
		}
	}
}
class main_cls
{
	public static void Main()
	{
		slary obj = new slary();
	
		double ta,da,hra,pa;
	
		Console.WriteLine("Enter basic slary :-");
		double basic=Convert.ToInt32(Console.ReadLine());
	
		obj.fun(ref basic,out ta,out da,out hra,out pa);
	
		Console.WriteLine("you gross slary :-"+basic);
		Console.WriteLine("you pa :-"+pa);
		Console.WriteLine("you da:-"+da);
		Console.WriteLine("you hra :-"+hra);
		Console.WriteLine("you pa :-"+pa);
	}
}