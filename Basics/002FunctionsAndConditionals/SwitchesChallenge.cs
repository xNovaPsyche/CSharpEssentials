using System;
                    
public class Program
{
	public Operations myOperator;
	
    public void Main()
    {
        myOperator = new Operations();
		
		 Console.WriteLine("Temperature Adviser");
        Console.WriteLine("Tempurature in Celcius:");
		myOperator.DoMath(10, 0);
		myOperator.DoMath(10, 10);
		myOperator.DoMath(10, 20);
		myOperator.Compare(4,3);
		myOperator.Compare(3,4);
		
       
		
    }
	
	public class Operations {
	public void DoMath (int value, int value2) {
		var number = value + value2;
		if (value < 30) 
			
			{
  Console.WriteLine("It's a nice day outside!");
}
		Console.WriteLine(number);
	} 
	
	public void Compare (int value, int value2) {
		if(value < 30) {
			Console.WriteLine("It's hot! Stay hydrated or hit the pool!");
		}
	}
    
		
	}
}