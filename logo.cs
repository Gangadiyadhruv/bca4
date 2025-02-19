using System;
class demo{
	public static void Main()
	{
		for(int i=1;i<=17;i++){
			for(int j=1;j<=20;j++){
				if(i==1 && j==6 || i==1 && j==10 || i==1 && j==14 ||
				 i==2 && j==6 || i==2 && j==7 || i==2 && j==9 ||i==2 && j==11 ||i==2 && j==13 || i==2 && j==14 ||
				 i==3 && j==6 || i==3 && j==8 || i==3 && j==9 ||i==3 && j==11 ||i==3 && j==12 ||i==3 && j==14 ||
				 ){
						Console.WriteLine(" *");
				}
			}
			Console.WriteLine();
		}
	}
}