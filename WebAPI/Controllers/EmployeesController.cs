using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;


namespace WebAPI.Controllers
{
    public class EmployeesController : ApiController
    {
        /// <summary>
        /// Returns full list of employees.
        /// </summary>
        /// <returns></returns>
        public string Get()
        {
            return "Accessed Web API";
        }

        /// <summary>
        /// Returns specific employee of the provided id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<string> Get(int id)
        {
            return new List<string>
            {
                "value 1",
                "value 2"
            };
        }

        /// <summary>
        /// Creates employee.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="address"></param>
        /// <param name="contact"></param>
        /// <returns></returns>
        public string Post(
            string name, 
            int age, 
            string address, 
            string contact
            )
        {
            return name;
        }

    }
}
