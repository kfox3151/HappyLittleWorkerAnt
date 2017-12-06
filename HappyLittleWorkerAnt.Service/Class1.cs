using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyLittleWorkerAnt.Model;
using HappyLittleWorkerAnt.Persistence;

namespace HappyLittleWorkerAnt.Service
{
    public class Updater
    {

        public Updater()
        {
            var dbContext = new StageCWTEntities();

            var stuffToInsert = new List<WarehouseSync>();


            dbContext.WarehouseSyncs.AddRange(stuffToInsert);

            dbContext.SaveChanges();
        }
    }
}
