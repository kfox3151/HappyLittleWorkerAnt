using System;
using System.Collections.Generic;
using Common;
using HappyLittleWorkerAnt.Model.enums;
using HappyLittleWorkerAnt.Persistence;

namespace HappyLittleWorkerAnt.Service
{
    public class CwtRecordGenerator
    {

        public static void InsertStageRecords(int numberOfRecords)
        {
            var records = GenerateStageRecords(numberOfRecords);
            Updater.StageRecordUpdater(records);
        }

        public static List<WarehouseSync> GenerateStageRecords(int numberOfRecords)
        {
            var recordList = new List<WarehouseSync>();
            var i = 0;

            while (i < numberOfRecords)
            {
                var record = new WarehouseSync()
                {
                    PatientPathwayIdentifier = PatientPathwayIdGenerator.GetNewPatientPathwayId(),
                    Standard = EnumHelper.GetRandomEnumDescription<CwtStandards>(),
                    Compliance = EnumHelper.GetRandomEnumDescription<CwtCompliance>(),
                    SuspectedCancer = EnumHelper.GetRandomEnumDescription<CwtSuspectedCancers>(),
                    SourceofreferralForOutpatients = EnumHelper.GetRandomEnumDescription<CwtSourceOfReferralsForOutpatients>(),
                    FirstSeenProvider = EnumHelper.GetRandomEnumDescription<CwtTrusts>(),
                    ReferringGPCCG = null,
                    DateFirstSeen = DateGenerator.GetRandomDateInLastFiveYears(),
                    PrimaryDiagnosis = EnumHelper.GetRandomEnumDescription<CwtPrimaryDiagnosis>(),
                    FirstTreatmentProvider = EnumHelper.GetRandomEnumDescription<CwtTrusts>(),
                    TreatmentModality = EnumHelper.GetRandomEnumDescription<CwtCancerTreatmentModalities>(),
                    TreatmentEventType = EnumHelper.GetRandomEnumDescription<CwtCancerTreatmentEventTypes>(),
                    Version = NumberHelper.GenerateRandomNumberBetween(1, 5),
                    AuditTimeStamp = DateTime.Now,
                    LoadID = 2,
                    CancerCareSetting = NumberHelper.GenerateRandomNumberBetween(-2, 1)
                };

                record = CwtDaysGenerator.GetNumberOfDays(record);
                record.DateFirstTreatment =
                        DateGenerator.GetRandomDateBasedOnStartDate(record.DateFirstSeen);
                record.TreatmentStartDateCancer = DateGenerator.GetRandomDateBasedOnStartDate(record.DateFirstSeen);
                

                recordList.Add(record);
                i++;
            }
            return recordList;
        }
    }
}
