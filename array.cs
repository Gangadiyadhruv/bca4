using System;
class demo{
	public static void Main(){
		int i=0;
		int num = Convert.ToInt32(Console.ReadLine());
		int []a=new int[num];
		for(i=0;i<num;i++){
			a[i] =Convert.ToInt32(Console.ReadLine());
		}
		for(i=0;i<num;i++){
			Console.WriteLine(a[i]);
		}
	}
}