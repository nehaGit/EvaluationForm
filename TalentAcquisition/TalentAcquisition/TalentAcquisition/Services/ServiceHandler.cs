//using System;
//using System.Threading.Tasks;
//using System.Collections.Generic;
//using Newtonsoft.Json;
//using System.Net.Http;
//using System.Text;

//namespace TalentAcquisition
//{
//	public class ServiceHandler
//	{
//		HttpClient client; 

//		public ServiceHandler()
//		{
//			client = new HttpClient ();
//		}
//		public async Task<List<Interviewee>> GetinterVieweeDataAsync ()
//		{
//				var uri = new Uri (string.Format (Constants.RestUrl, string.Empty));
//				var response = await client.GetAsync (uri);
//			if (response.IsSuccessStatusCode) {
//				var content = await response.Content.ReadAsStringAsync ();
//				var Items = JsonConvert.DeserializeObject <List<Interviewee>> (content);
//			}
//		}

//		public async Task SaveTodoItemAsync (IntervieweeResponse item, bool isNewItem = false)
//		{
//			// RestUrl = http://developer.xamarin.com:8081/api/todoitems{0}
//			var uri = new Uri (string.Format (Constants.RestUrl, string.Empty));
//				var json = JsonConvert.SerializeObject (item);
//			var content = new StringContent (json, Encoding.UTF8, "application/json");

//			HttpResponseMessage response = null;
//			if (isNewItem) {
//				response = await client.PostAsync (uri, content);
//			}

//				if (response.IsSuccessStatusCode) {

//				}
//			}
//	}
//}