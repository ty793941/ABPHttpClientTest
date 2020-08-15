using Abp.Dependency;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ABPTest.Web.Host
{
    public class TestClient 
    {
        public HttpClient _httpClient { get; }
        //public TestClient(IHttpClientFactory clientFactory)
        //{
        //    _httpClient = clientFactory.CreateClient("client");
        //    ////表头参数
        //    //_httpClient.DefaultRequestHeaders.Accept.Clear();
        //    //_httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //    //_httpClient.BaseAddress = new Uri("https://api.weixin.qq.com");
        //    //_httpClient.Timeout = new TimeSpan(0, 0, 0, 20);//若不配置，默认10s
        //}

        public TestClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetTest(string url)
        {
            return await _httpClient.GetStringAsync(url);
        }
    }

}
