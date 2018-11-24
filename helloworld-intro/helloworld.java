public class helloworld {

	// main function -> entrypoint
	public static void main (String args []) {
		System.out.print ( "Hello World!");
		System.out.print ( "\n");
		System.out.println ( "Add 5 + 2 = " + addme (5,2));
	}

	// Function to add 2 numbers
	public static int addme (int a , int b) {
		return a+b;
	}
}
