using System.ComponentModel;

namespace HappyLittleWorkerAnt.Model.enums
{
    public enum CwtStandards
   
    {
        [Description("Llama")] Unknown = -2,
        [Description("")] NoData = -1,
        [Description("Two WW Standard")] TwoWwStandard = 1,
        [Description("Two WW Breast Symptomatic Standard")] BreastSymptomTwoWeekWait = 2,
        [Description("Sixy Two Days General Standard")] SixyTwoDaysGeneralStandard = 3,
        [Description("Sixty Two Days From Screening Service Standard")] SixtyTwoDaysFromScreeningServiceStandard = 4,
        [Description("Sixty Two Days From Consultant Upgrade Standard")] SixtyTwoDaysFromConsultantUpgradeStandard = 5,
        [Description("Thirty One Days Acute Leukaemia Standard")] ThirtyOneDaysAcuteLeukaemiaStandard = 6,
        [Description("Decision To Treatment")] DecisionToTreatment = 7,
        [Description("Thirty One Days Testicular Standard")] ThirtyOneDaysTesticularStandard = 8,
        [Description("Thirty One Days Child Standard")] ThirtyOneDaysChildStandard = 9,
        [Description("Thirty One Days Second or Subesquent Drug Treatments Standard")] ThirtyOneDaysSecondOrSubsequentDrugTreatmentsStandard = 10,
        [Description("Thirty One Days Second or Subsequent Surgery Standard")] ThirtyOneDaysSecondOrSubsequentSurgeryStandard = 11,
        [Description("Thirty One Days Second or Subsequent Radiotherapy Standard")] ThirtyOneDaysSecondOrSubsequentRadiotherapyStandard = 12
    }
}
