using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Apis
{
	internal class Api
	{
		public dynamic Get(string url)
		{
			using (HttpClient client = new HttpClient())
			{
				client.DefaultRequestHeaders.Clear();
				var response = client.GetAsync(url).Result;
				var respon = response.Content.ReadAsStringAsync().Result;
				dynamic res = JObject.Parse(respon);
				return res;
			}
		}
	}
}
