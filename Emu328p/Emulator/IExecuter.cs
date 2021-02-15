using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator
{
	public interface IExecuter
	{
		bool ExecuteNextMicrocommand(ISRAM sramManager, IFlash flashManager);
	}
}
