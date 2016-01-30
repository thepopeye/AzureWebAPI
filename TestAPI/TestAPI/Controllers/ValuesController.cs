using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestAPI.Methods;

namespace TestAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post([FromBody]object[] value)
        {
            return value[0].ToString();
        }

        [HttpPost]
        public string PostTest([FromBody]object[] value)
        {
            return value[0].ToString();
        }

        [HttpPost]
        public object PostIsAnagram([FromBody]object[] value)
        {
            var retarray = new bool[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                var arr = value[i] as IEnumerable<object>;
                retarray[i] = Methods.Methods.IsAnagram(arr.ElementAt(0).ToString(), arr.ElementAt(1).ToString());
            }
            return retarray;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

    public class ParamWrapper
    {

    }
}
