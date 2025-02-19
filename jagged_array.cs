using System;
class user {
	public static void Main() {
		int [][]a=new int [3][];
		a[0]=new int[3];
		a[1]=new int[1];
		a[2]=new int[4];
		
		//give the value 
		a[0][0]=11;
		a[0][1]=22;
		a[0][2]=33;
		
		//second raw
		a[1][0]=111;
		
		//threed raw
		a[2][0]=1;
		a[2][1]=2;
		a[2][2]=3;
		a[2][3]=4;
		
		Console.WriteLine("fist raw and colunm" +a[0][0]);
		Console.WriteLine("fist raw and colunm" +a[0][1]);
		Console.WriteLine("fist raw and colunm" +a[0][2]);
		
		Console.WriteLine("fist raw and colunm" +a[1][0]);
		
		Console.WriteLine("fist raw and colunm" +a[2][0]);
		Console.WriteLine("fist raw and colunm" +a[2][1]);
		Console.WriteLine("fist raw and colunm" +a[2][2]);
		Console.WriteLine("fist raw and colunm" +a[2][3]);
		
		
	}
}