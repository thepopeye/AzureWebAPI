using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
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

        [HttpPost]
        public object PostIsPalindrome([FromBody]object[] value)
        {
            var retarray = new bool[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                retarray[i] = Methods.Methods.IsPalindrome(value[i].ToString());
            }
            return retarray;
        }

        [HttpPost]
        public object PostFizzBuzz([FromBody]object[] value)
        {
            var retarray = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                var srb = new StringBuilder();
                int val = Convert.ToInt16(value[i]);
                if (val % 2 == 0)
                    srb.Append("Fizz");
                if (val % 3 == 0)
                    srb.Append("Buzz");
                if (srb.Length == 0)
                    srb.Append(val);
                retarray[i] = srb.ToString();
            }
            return retarray;
        }

        [HttpPost]
        public object PostSumSquares([FromBody]object[] value)
        {
            var retarray = new int[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                var result = Methods.Methods.SumSquares(Convert.ToInt16(value[i]));
                retarray[i] = result;
            }
            return retarray;
        }

        [HttpPost]
        public object PostIsPrime([FromBody]object[] value)
        {
            var retarray = new bool[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                var result = Methods.Methods.IsPrime(Convert.ToInt16(value[i]));
                retarray[i] = result;
            }
            return retarray;
        }

        [HttpPost]
        public object PostGetFib([FromBody]object[] value)
        {
            var retarray = new int[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                var result = Methods.Methods.GetFib(Convert.ToInt16(value[i]));
                retarray[i] = result;
            }
            return retarray;
        }

        [HttpPost]
        public object PostSexyPrimes([FromBody]object[] value)
        {
            int max = Convert.ToInt16(value[0]);
            var lst = Methods.Methods.SexyPrimes(max);
            var retlst = new List<List<int>>();
            foreach (var i in lst)
            {
                retlst.Add(new List<int>() { i, i + 6 });
            }
            return retlst;
        }

        [HttpPost]
        public object PostPyTriplets([FromBody]object[] value)
        {
            int max = Convert.ToInt16(value[0]);
            var lst = Methods.Methods.PyTriplets(max);
            return lst;
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
