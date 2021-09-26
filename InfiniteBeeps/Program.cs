using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfiniteBeeps
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] processesToKill = new string[]
			{
				"vlc"
			};

			foreach (var p in Process.GetProcesses())
				if (processesToKill.Contains(p.ProcessName.Trim().ToLower()))
					p.Kill();

			Application.SetSuspendState(PowerState.Suspend, true, false);
		}
	}
}
