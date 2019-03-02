using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Radium_utxo_server.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        [Route("getaddressutxos/{id}")]
        public JArray getaddressutxos(string id)
        {
            var result = Vars.utxos.Where(i => i.address == id);
            JArray response = new JArray();
            foreach (utxo unspent in result)
            {
                response.Add(unspent.ToJson());
            }
                
            return response;
        }
    }
}
