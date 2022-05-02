using System;

namespace FlagPFPCore.Exceptions
{
	public class NoFlagsFoundException : Exception
	{
		public NoFlagsFoundException()
		{
		}

		public NoFlagsFoundException(string message)
			: base(message)
		{
		}

		public NoFlagsFoundException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}

	public class InvalidFlagException : Exception
	{
		public InvalidFlagException()
		{
		}

		public InvalidFlagException(string message)
			: base(message)
		{
		}

		public InvalidFlagException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}
}
