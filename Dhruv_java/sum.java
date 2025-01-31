class sum
{
	public static void main(String []args)
	{
		int dec1 = 200;
		int bin1 = 0b110100;
		int oct1 = 0122;
		int hex1 = 0x32;
		
		int dec2 = 100;
		int bin2 = 0b110010;
		int oct2 = 0144;
		int hex2 = 0x128;
		
		/*
		int dec3 = dec1 * dec2;
		int bin3 = bin1 * bin2;
		int oct3 = oct1 * oct2;
		int hex3 = hex1 * hex2;
		*/
		
		
		int dec3 = dec1 + dec2;
		int bin3 = bin1 + bin2;
		int oct3 = oct1 + oct2;
		int hex3 = hex1 + hex2;
		
		
		System.out.println("sum of decimal :="+dec3);
		System.out.println("sum of binary :="+bin3);
		System.out.println("sum of octal :="+oct3);
		System.out.println("sum of hexdecimal :="+hex3);
	}
}