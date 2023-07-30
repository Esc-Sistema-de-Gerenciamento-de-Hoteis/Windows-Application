using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esc_v1
{
    internal class API
    {
        public async Task<string> SendDataToApiAsync(string apiUrl, string jsonData)
        {



            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    // Set the base address of the API
                    httpClient.BaseAddress = new Uri(apiUrl);

                    // Set the content type of the request to be JSON
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    // Create the HTTP request content with the JSON data
                    StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    // Send the POST request and get the response
                    HttpResponseMessage response = await httpClient.PostAsync(apiUrl, content);

                    // Check if the response is successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content as a string and return it
                        string responseContent = await response.Content.ReadAsStringAsync();
                        return responseContent;
                    }
                    else
                    {
                        // Handle the case when the API returns an error
                        return "Error: " + response.StatusCode.ToString();
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during the request
                    return "Error: " + ex.Message;
                }
            }
        }
    }
}
