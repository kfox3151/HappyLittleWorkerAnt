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

        public static void StageRecordUpdater(List<WarehouseSync> recordList)
        {
            var dbContext = new StageCWTEntities();

            var records = recordList;

            dbContext.WarehouseSyncs.AddRange(records);

            dbContext.SaveChanges();
        }
    }
}
