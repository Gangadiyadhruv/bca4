import java.util.Arras;
class student
{
	protected String name;
	protected int id;
	protected int marks;
	
	public student(String name,int id,int marks)
	{
		this.name=name;
		this.id=id;
		this.marks=marks;
	}
	public void dis()
	{
		System.out.println("student name:-"+name+" student id :-"+id+" student marks:-"+marks);
	}
}
class Main
{
	public static void main(String []args)
	{
		student[] student = {
								new student("dhruv",18,97),
								new student("narendra",18,99),
								new student("viral",18,98),
							};
			Arras.sort(student,(a.b) -> a.marks -b.marks);
			for(student student:students)
			{
				student.dis();
				System.out.println();
			}
	}
}