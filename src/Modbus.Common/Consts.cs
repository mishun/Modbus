﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Modbus.Common
{
	/// <summary>
	/// Contains all constants used in Modbus.
	/// </summary>
	public static class Consts
	{
		#region Error/Exception

		private static Dictionary<byte, string> exceptions = new Dictionary<byte, string>
		{
			{  0, "No Error" },
			{  1, "Illegal Function" },
			{  2, "Illegal Data Address" },
			{  3, "Illegal Data Value" },
			{  4, "Slave Device Failure" },
			{  5, "Acknowledge" },
			{  6, "Slave Device Busy" },
			{  7, "Negative Acknowledge" },
			{  8, "Memory Parity Error" },
			{ 10, "Gateway Path Unavailable" },
			{ 11, "Gateway Target Device Failed to Respond" }
		};

		/// <summary>
		/// Known Modbus exception codes returned by the server.
		/// </summary>
		public static ReadOnlyDictionary<byte, string> ErrorMessages => new ReadOnlyDictionary<byte, string>(exceptions);

		/// <summary>
		/// The Bit-Mask to filter the error-state of a Modbus response.
		/// </summary>
		public const byte ErrorMask = 0x80;

		#endregion Error/Exception

		#region Protocol limitations

		/// <summary>
		/// The lowest accepted device id.
		/// </summary>
		public const byte MinDeviceId = 0x00;

		/// <summary>
		/// The highest accepted device id.
		/// </summary>
		public const byte MaxDeviceId = 0xFF; // 255

		/// <summary>
		/// The lowest address.
		/// </summary>
		public const ushort MinAddress = 0x0000;

		/// <summary>
		/// The highest address.
		/// </summary>
		public const ushort MaxAddress = 0xFFFF; // 65535

		/// <summary>
		/// The lowest number of requested data sets.
		/// </summary>
		public const ushort MinCount = 0x01;

		/// <summary>
		/// The highest number of requested coils to read.
		/// </summary>
		public const ushort MaxCoilCountRead = 0x7D0; // 2000

		/// <summary>
		/// The highest number of requested coils to write.
		/// </summary>
		public const ushort MaxCoilCountWrite = 0x7B0; // 1968

		/// <summary>
		/// The highest number of requested registers to read.
		/// </summary>
		public const ushort MaxRegisterCountRead = 0x7D; // 125

		/// <summary>
		/// The highest number of requested registers to write.
		/// </summary>
		public const ushort MaxRegisterCountWrite = 0x7B; // 123

		#endregion Protocol limitations
	}
}
