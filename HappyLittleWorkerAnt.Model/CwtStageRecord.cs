using System;

namespace HappyLittleWorkerAnt.Model
{
    public class CwtStageRecord
    {
        public string PatientPathwayId { get; set; }
        public string Standard { get; set; }
        public string Compliance { get; set; }
        public string SuspectedCancer  { get; set; }
        public string SourceOfReferralForOutpatients { get; set; }
        public string SiteCodeProviderFirstSeen { get; set; }
        public string GpPracticeCodeToCcg { get; set; }
        public DateTime DateFirstSeen { get; set; }
        public string PrimaryDiagnosisIcd10 { get; set; }
        public string SiteCodeTreatmentStartDateCancer { get; set; }
        public string CancerTreatmentModality { get; set; }
        public string CancerTreatmentEventType { get; set; }
        public DateTime CancerTreatmentPeriodStartDate { get; set; }
        public DateTime TreatmentStartDateCancer { get; set; }
        public int DaysBetweenConsultantUpgradeAndTreatmentStart { get; set; }
        public int NumberOfDaysReferralToFirstSeen { get; set; }    
        public int NumberOfDaysReferralToFirstTreatment { get; set; }
        public int NumberOfDayDecisionToTreatToTreatment { get; set; }
        public int VersionId { get; set; }
        public DateTime SystemEffectiveStartDateTime { get; set; }
        public DateTime SystemEffectiveEndDateTime { get; set; }
        public int LoadId { get; set; }
        public int CancerCareSetting { get; set; }
    }
}
