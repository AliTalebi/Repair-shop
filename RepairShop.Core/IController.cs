using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Core
{
	public interface IController : IDisposable
	{
		void Run();
		void Stop();
	}
}