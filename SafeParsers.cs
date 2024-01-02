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
			inputChannel ??= DefaultInputChannel;
			bool i;
			while (!bool.TryParse(inputChannel(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static byte Byte(InputChannel? inputChannel = null)
		{
			inputChannel ??= DefaultInputChannel;
			byte i;
			while (!byte.TryParse(inputChannel(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static sbyte SByte(InputChannel? inputChannel = null)
		{
			inputChannel ??= DefaultInputChannel;
			sbyte i;
			while (!sbyte.TryParse(inputChannel(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static short Short(InputChannel? inputChannel = null)
		{
			inputChannel ??= DefaultInputChannel;
			short i;
			while (!short.TryParse(inputChannel(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static ushort UShort(InputChannel? inputChannel = null)
		{
			inputChannel ??= DefaultInputChannel;
			ushort i;
			while (!ushort.TryParse(inputChannel(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static int Int(InputChannel? inputChannel = null)
		{
			inputChannel ??= DefaultInputChannel;
			int i;
			while (!int.TryParse(inputChannel(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static uint UInt(InputChannel? inputChannel = null)
		{
			inputChannel ??= DefaultInputChannel;
			uint i;
			while (!uint.TryParse(inputChannel(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static long Long(InputChannel? inputChannel = null)
		{
			inputChannel ??= DefaultInputChannel;
			long i;
			while (!long.TryParse(inputChannel(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static ulong ULong(InputChannel? inputChannel = null)
		{
			inputChannel ??= DefaultInputChannel;
			ulong i;
			while (!ulong.TryParse(inputChannel(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static float Double(InputChannel? inputChannel = null)
		{
			inputChannel ??= DefaultInputChannel;
			float i;
			while (!float.TryParse(inputChannel(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static double Float(InputChannel? inputChannel = null)
		{
			inputChannel ??= DefaultInputChannel;
			double i;
			while (!double.TryParse(inputChannel(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static decimal Decimal(InputChannel? inputChannel = null)
		{
			inputChannel ??= DefaultInputChannel;
			decimal i;
			while (!decimal.TryParse(inputChannel(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static char Char(InputChannel? inputChannel = null)
		{
			inputChannel ??= DefaultInputChannel;
			char i;
			while (!char.TryParse(inputChannel(), out i))
				DefaultErrorDisplayChannel();
			return i;
		}
		public static TEnum EnumType<TEnum>(bool IgnoreCase = true, InputChannel? inputChannel = null) where TEnum : struct, Enum
		{
			inputChannel ??= DefaultInputChannel;
			TEnum i;
			while (!Enum.TryParse(inputChannel(), IgnoreCase, out i))
				DefaultErrorDisplayChannel();
			return i;
		}

		public static string String(InputChannel? inputChannel = null)
		{
			inputChannel ??= DefaultInputChannel;
			string i = inputChannel();
			while (string.IsNullOrEmpty(i.Trim()))
			{
				DefaultErrorDisplayChannel();
				i = inputChannel();
			}
			return i;
		}
	}
}
