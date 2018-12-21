using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebAPI_app_POKEMON.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

            public async Task<JObject> Get()
        {
            var Urlapi = "https://pokeapi.co/api/v2/ability/";

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(Urlapi);

            JObject results = await response.Content.ReadAsAsync<JObject>();

            
            
            return results;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
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
}
