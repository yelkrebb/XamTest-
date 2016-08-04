using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Motion.Core.WSHandler
{
	public interface IWebServicesWrapper
	{
		Task<Dictionary<string, object>> GetData(string URL);
		Task<Dictionary<string, object>> GetData(string URL, Dictionary<string, object> data);
		Task<Dictionary<string, object>> PostData(string URL, Dictionary<string, object> data);
		Task<Dictionary<string, object>> PostMultiPartData(string URL, byte file);
	}
}

