using EmployeeWeb.Models;
using EmployeeWeb.Service.Interface;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeWeb.Service.Implementation
{
    public class EmployeeService : IEmployeeService
    {

        private readonly IOptions<Services> _serviceSettings;


        public EmployeeService(IOptions<Services> serviceSettings)
        {
            _serviceSettings = serviceSettings;
        }

        public List<EmployeeViewModel> GetEmployees()
        {
            var builder = new HttpRequestBuilder()
                             .AddMethod(HttpMethod.Get)
                             .AddRequestUri(_serviceSettings.Value.EmployeeServiceUrl + "Employee");

            var res = builder.SendAsync().Result.Content.ReadAsStringAsync().Result;


            return JsonConvert.DeserializeObject<List<EmployeeViewModel>>(res);

        }

        public List<EmployeeViewModel> SaveEmployee(EmployeeViewModel emp)
        {
            var builder = new HttpRequestBuilder()
                             .AddMethod(HttpMethod.Post)
                             .AddRequestUri(_serviceSettings.Value.EmployeeServiceUrl + "Employee")
                             .AddContent(new StringContent(JsonConvert.SerializeObject(emp)));

            var res = builder.SendAsync().Result.Content.ReadAsStringAsync().Result;


            return JsonConvert.DeserializeObject<List<EmployeeViewModel>>(res);
        }
    }
}
