using System.Collections.Generic;
using System.Web.Http;
using HappyLittleWorkerAnt.Service;

namespace HappyLittleWorkerAnt.API.Controllers
{
    public class StageController : ApiController
    {
        // GET api/values
        public List<CwtStageRecord> Get(int id)
        {
            return CwtRecordGenerator.GenerateStageRecords(id);   
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
