class java_var
{
	public static void main(String args[])
	{
		int i,j;
		
		for (i=1;i<=7;i++)
		{
			for(j=1;j<=9;j++)
			{
				if(i==1 && j==2 || i==1 && j==3 ||i==1 && j==5 ||i==1 && j==6 
				|| i==2 && j==1 || i==2 && j==4 ||i==2 && j==8 ||
				i==3 && j==1 ||i==3 && j==9||
				i==4 && j==2 || i==4 && j==8 ||
				i==5 && j==3 || i==5 && j==6 || i==6 && j==5)
				{
					System.out.print("* ");
				}
				else
				{
					System.out.print(" ");
				}
			}
			System.out.println();
		}
	}
}