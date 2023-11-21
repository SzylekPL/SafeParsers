namespace SafeParsers
{
	public static class SafeParse
	{
		public delegate string InputChannel();
		public delegate void ErrorDisplayChannel();
		public static InputChannel DefaultInputChannel { get; set; } = () => Console.ReadLine();
		public static ErrorDisplayChannel DefaultErrorDisplayChannel { get; set; } = () => Console.WriteLine(ErrorMessage);
		public static string ErrorMessage { get; set; } = "Incorrect value, type again:";

		public static bool Bool(InputChannel? inputChannel = null)
		{
			bool i;
			while (!bool.TryParse(Console.ReadLine(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static byte Byte(InputChannel? inputChannel = null)
		{
			byte i;
			while (!byte.TryParse(Console.ReadLine(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static sbyte SByte(InputChannel? inputChannel = null)
		{
			sbyte i;
			while (!sbyte.TryParse(Console.ReadLine(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static short Short(InputChannel? inputChannel = null)
		{
			short i;
			while (!short.TryParse(Console.ReadLine(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static ushort UShort(InputChannel? inputChannel = null)
		{
			ushort i;
			while (!ushort.TryParse(Console.ReadLine(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static int Int(InputChannel? inputChannel = null)
		{
			int i;
			while (!int.TryParse(Console.ReadLine(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static uint UInt(InputChannel? inputChannel = null)
		{
			uint i;
			while (!uint.TryParse(Console.ReadLine(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static long Long(InputChannel? inputChannel = null)
		{
			long i;
			while (!long.TryParse(Console.ReadLine(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static ulong ULong(InputChannel? inputChannel = null)
		{
			ulong i;
			while (!ulong.TryParse(Console.ReadLine(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static float Double(InputChannel? inputChannel = null)
		{
			float i;
			while (!float.TryParse(Console.ReadLine(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static double Float(InputChannel? inputChannel = null)
		{
			double i;
			while (!double.TryParse(Console.ReadLine(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static decimal Decimal(InputChannel? inputChannel = null)
		{
			decimal i;
			while (!decimal.TryParse(Console.ReadLine(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static char Char(InputChannel? inputChannel = null)
		{
			char i;
			while (!char.TryParse(Console.ReadLine(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static string String(InputChannel? inputChannel = null)
		{
			string i = Console.ReadLine();
			while (string.IsNullOrEmpty(i.Trim()))
			{
				DefaultErrorDisplayChannel();
				i = Console.ReadLine();
			}
			return i;
		}
	}
}
