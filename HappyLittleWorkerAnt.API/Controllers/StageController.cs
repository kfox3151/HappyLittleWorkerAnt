using System.Collections.Generic;
using System.Web.Http;
using HappyLittleWorkerAnt.Model;
using HappyLittleWorkerAnt.Service;

namespace HappyLittleWorkerAnt.API.Controllers
{
    [RoutePrefix("api/stage")]
    public class StageController : ApiController
    {
        // GET api/values
        [Route("{numberOfRecords}")]
        public string Get(int numberOfRecords)
        {
            var message = "Done";
            CwtRecordGenerator.InsertStageRecords(numberOfRecords);
            return message;
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
