namespace lemure.DropCode
{
	public class Lambda
	{
		public delegate int delegado(int a);

		public static int GetDelegate(int y)
		{
			delegado myDelegate = x => x * 2;
			return myDelegate(y);
		}
	}
}