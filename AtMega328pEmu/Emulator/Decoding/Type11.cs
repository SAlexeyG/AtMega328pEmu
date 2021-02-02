using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AtMega328pEmu.Emulator.Decoding
{
	public class Type11 : IOpcodeFormatType
	{
		private Dictionary<ushort, Action<ushort, ISRAM, IFlash>> decodingTable =
			new Dictionary<ushort, Action<ushort, ISRAM, IFlash>>();

		public ushort OperandMask => 0xfe0e;

		public Type11()
		{
			decodingTable.Add(0x940c, Jmp);
			decodingTable.Add(0x940e, Call);
		}

		public Action<ushort, ISRAM, IFlash> GetDecodedOperation(ushort opcodeWithoutOperands)
		{
			return decodingTable[opcodeWithoutOperands];
		}

		public bool HasDecodedOperation(ushort opcodeWithoutOperands)
		{
			return decodingTable.ContainsKey(opcodeWithoutOperands);
		}

		private void Jmp(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			uint offset = GetOffset(opcode, flashManager);
			flashManager.PC = offset;
		}

		private void Call(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			uint offset = GetOffset(opcode, flashManager);

			ushort sp = sramManager.GetWord(Registers.IO.SPL);

			byte[] pc = BitConverter.GetBytes(flashManager.PC);

			foreach (byte pcByte in pc)
			{
				sp--;
				sramManager.SetByte(sp, pcByte);
			}

			sramManager.SetWord(Registers.IO.SPL, sp);
			flashManager.PC = offset;
		}

		private static uint GetOffset(ushort opcode, IFlash flashManager)
		{
			opcode &= 0x01f1;
			ushort tmp = 0;
			tmp |= (ushort)(opcode & 0x0001);
			opcode >>= 3;
			opcode |= tmp;
			uint offset = opcode;
			offset <<= 16;
			offset |= flashManager.GetWord();
			offset <<= 1;
			return offset;
		}
	}
}
