using System;
using System.Collections.Generic;
using Common;
using HappyLittleWorkerAnt.Model;
using HappyLittleWorkerAnt.Model.enums;

namespace HappyLittleWorkerAnt.Service
{
    public class CwtRecordGenerator
    {
        public static List<CwtStageRecord> GenerateStageRecords(int numberOfRecords)
        {
            var recordList = new List<CwtStageRecord>();
            var i = 0;

            while (i < numberOfRecords)
            {
                var record = new CwtStageRecord
                {
                    PatientPathwayId = PatientPathwayIdGenerator.GetNewPatientPathwayId(),
                    Standard = EnumHelper.GetRandomEnumDescription<CwtStandards>(),
                    Compliance = EnumHelper.GetRandomEnumDescription<CwtCompliance>(),
                    SuspectedCancer = EnumHelper.GetRandomEnumDescription<CwtSuspectedCancers>(),
                    SourceOfReferralForOutpatients = EnumHelper.GetRandomEnumDescription<CwtSourceOfReferralsForOutpatients>(),
                    SiteCodeProviderFirstSeen = EnumHelper.GetRandomEnumDescription<CwtTrusts>(),
                    GpPracticeCodeToCcg = null,
                    DateFirstSeen = DateGenerator.GetRandomDateInLastFiveYears(),
                    PrimaryDiagnosisIcd10 = EnumHelper.GetRandomEnumDescription<CwtPrimaryDiagnosis>(),
                    SiteCodeTreatmentStartDateCancer = EnumHelper.GetRandomEnumDescription<CwtTrusts>(),
                    CancerTreatmentModality = EnumHelper.GetRandomEnumDescription<CwtCancerTreatmentModalities>(),
                    CancerTreatmentEventType = EnumHelper.GetRandomEnumDescription<CwtCancerTreatmentEventTypes>(),
                    DaysBetweenConsultantUpgradeAndTreatmentStart = 0,
                    VersionId = NumberHelper.GenerateRandomNumberBetween(1, 5),
                    SystemEffectiveStartDateTime = DateTime.Now,
                    LoadId = 2,
                    CancerCareSetting = NumberHelper.GenerateRandomNumberBetween(-2, 1)
                };

                record = CwtDaysGenerator.GetNumberOfDays(record);
                record.CancerTreatmentPeriodStartDate =
                   DateGenerator.GetRandomDateBasedOnStartDate(record.DateFirstSeen);
                record.TreatmentStartDateCancer = DateGenerator.GetRandomDateBasedOnStartDate(record.DateFirstSeen);

                recordList.Add(record);
                i++;
            }
            return recordList;
        }
    }
}
