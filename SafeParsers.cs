namespace SafeParsers
{
	public static class SafeParse
	{
		private static string errorMessage = "Incorrect value, type again:";

		public static string ErrorMessage { get => errorMessage; set => errorMessage = value; }
		private static void WriteErrorMessage() => Console.WriteLine(ErrorMessage);

		public static bool Bool()
		{
			bool i;
			while (!bool.TryParse(Console.ReadLine(), out i))
				WriteErrorMessage();
			return i;
		}
		public static byte Byte()
		{
			byte i;
			while (!byte.TryParse(Console.ReadLine(), out i))
				WriteErrorMessage() ;
			return i;
		}
		public static sbyte SByte()
		{
			sbyte i;
			while (!sbyte.TryParse(Console.ReadLine(), out i))
				WriteErrorMessage();
			return i;
		}
		public static short Short()
		{
			short i;
			while (!short.TryParse(Console.ReadLine(), out i))
				WriteErrorMessage();
			return i;
		}
		public static ushort UShort()
		{
			ushort i;
			while (!ushort.TryParse(Console.ReadLine(), out i))
				WriteErrorMessage();
			return i;
		}
		public static int Int()
		{
			int i;
			while (!int.TryParse(Console.ReadLine(), out i))
				WriteErrorMessage();
			return i;
		}
		public static uint UInt()
		{
			uint i;
			while (!uint.TryParse(Console.ReadLine(), out i))
				WriteErrorMessage();
			return i;
		}
		public static long Long()
		{
			long i;
			while (!long.TryParse(Console.ReadLine(), out i))
				WriteErrorMessage();
			return i;
		}
		public static ulong ULong()
		{
			ulong i;
			while (!ulong.TryParse(Console.ReadLine(), out i))
				WriteErrorMessage();
			return i;
		}
		public static float Double()
		{
			float i;
			while (!float.TryParse(Console.ReadLine(), out i))
				WriteErrorMessage();
			return i;
		}
		public static double Float()
		{
			double i;
			while (!double.TryParse(Console.ReadLine(), out i))
				WriteErrorMessage();
			return i;
		}
		public static decimal Decimal()
		{
			decimal i;
			while (!decimal.TryParse(Console.ReadLine(), out i))
				WriteErrorMessage();
			return i;
		}
		public static char Char()
		{
			char i;
			while (!char.TryParse(Console.ReadLine(), out i))
				WriteErrorMessage();
			return i;
		}
		public static string String()
		{
			string i = Console.ReadLine();
			while (string.IsNullOrEmpty(i.Trim()))
			{
				WriteErrorMessage();
				i = Console.ReadLine();
			}
			return i;
		}
	}
}
