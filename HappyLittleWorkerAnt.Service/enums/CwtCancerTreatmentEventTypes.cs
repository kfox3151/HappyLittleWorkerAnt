using System.ComponentModel;

namespace HappyLittleWorkerAnt.Model.enums
{
    public enum CwtCancerTreatmentEventTypes
    {
        [Description("Llama")] Unknown = -2,
        [Description("")] NoData = -1,
        [Description("01")] FirstDefinitiveTreatmentForNewPrimaryCancer = 1,
        [Description("02")] SecondOrSubsequentTreatmentForNewPrimaryCancer = 2,
        [Description("03")] TreatmentForLocalRecurrenceOfCancer = 3,
        [Description("04")] TreatmentForRegionalRecurrenceOfCancer = 4,
        [Description("05")] TreatmentForDistantRecurrenceOfCancerMetastaticDisease = 5,
        [Description("06")] TreatmentForMultipleRecurrenceOfCancerLocalAndOrregionalAndOrDistant = 6,
        [Description("07")] FirstTreatmentForMetastaticdiseaseFollowingAnUnknownPrimary = 7,
        [Description("08")] SecondOrSubsequentTreatmentForMetastaticDiseaseFollowingAnUnknownPrimary = 8,
        [Description("09")] TreatmentForRelapseOfPrimaryCancerSecondOrSubsequent = 9,
        [Description("10")] TreatmentForProgressionOfPrimaryCancerSecondOrSubsequent = 10
    }
}
