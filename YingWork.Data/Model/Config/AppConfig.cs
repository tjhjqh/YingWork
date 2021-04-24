using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YingWork.Data.Model.Config
{
	public class AppConfig
	{
		public GraphClientConfig GraphClientConfig { get; set; }
	}
	public class GraphClientConfig {
		public string TenantId { get; set; }
	}
}
