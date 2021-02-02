using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtMega328pEmu.Emulator
{
	public interface IExecuter
	{
		bool ExecuteNextMicrocommand(ISRAM sramManager, IFlash flashManager);
	}
}
