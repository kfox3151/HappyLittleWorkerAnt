using System.Collections.Generic;
using Common;
using HappyLittleWorkerAnt.Model;
using HappyLittleWorkerAnt.Model.enums;
using HappyLittleWorkerAnt.Persistence;

namespace HappyLittleWorkerAnt.Service
{
    public class CwtDaysGenerator
    {
        public static WarehouseSync GetNumberOfDays(WarehouseSync record)
        {
            

            var twoWeekWaitStandardsList = new List<string>()
            {
                EnumHelper.GetDescription(CwtStandards.TwoWwStandard),
                EnumHelper.GetDescription(CwtStandards.BreastSymptomTwoWeekWait)
            };

            var thirtyOneDayStandardsList = new List<string>()
            {
                EnumHelper.GetDescription(CwtStandards.ThirtyOneDaysAcuteLeukaemiaStandard),
                EnumHelper.GetDescription(CwtStandards.ThirtyOneDaysTesticularStandard),
                EnumHelper.GetDescription(CwtStandards.ThirtyOneDaysChildStandard),
                EnumHelper.GetDescription(CwtStandards.ThirtyOneDaysSecondOrSubsequentDrugTreatmentsStandard),
                EnumHelper.GetDescription(CwtStandards.ThirtyOneDaysSecondOrSubsequentSurgeryStandard),
                EnumHelper.GetDescription(CwtStandards.ThirtyOneDaysSecondOrSubsequentRadiotherapyStandard)
            };

            var decisionToTreatmentList = new List<string>()
            {
                EnumHelper.GetDescription(CwtStandards.DecisionToTreatment)
            };

            var sixtyTwoDayStandardsList = new List<string>()
            {
                EnumHelper.GetDescription(CwtStandards.SixyTwoDaysGeneralStandard),
                EnumHelper.GetDescription(CwtStandards.SixtyTwoDaysFromScreeningServiceStandard),
                EnumHelper.GetDescription(CwtStandards.SixtyTwoDaysFromConsultantUpgradeStandard)
            };

            var rangeStart = 1;
            int rangeEnd;

            if (twoWeekWaitStandardsList.Contains(record.Standard))
            {
                rangeEnd = 14;
                if (record.Compliance != "1")
                {
                    rangeStart = rangeEnd + 1;
                    rangeEnd = 9999;
                }
                
                record.NumberOfDaysReferralToFirstSeen = NumberHelper.GenerateRandomNumberBetween(rangeStart, rangeEnd);
            }
            else if (thirtyOneDayStandardsList.Contains(record.Standard))
            {
                rangeEnd = 31;
                if (record.Compliance != "1")
                {
                    rangeStart = rangeEnd + 1;
                    rangeEnd = 9999;
                }

                record.NumberOfDaysReferralToFirstTreatment = NumberHelper.GenerateRandomNumberBetween(rangeStart, rangeEnd);
            }
            else if (decisionToTreatmentList.Contains(record.Standard))
            {
                rangeEnd = 14;
                if (record.Compliance != "1")
                {
                    rangeStart = rangeEnd + 1;
                    rangeEnd = 9999;
                }

                record.NumberOfDaysDecisionToTreatOrSubsequentTreatment = NumberHelper.GenerateRandomNumberBetween(rangeStart, rangeEnd);
            }
            else if (sixtyTwoDayStandardsList.Contains(record.Standard))
            {
                rangeEnd = 62;
                if (record.Compliance != "1")
                {
                    rangeStart = rangeEnd + 1;
                    rangeEnd = 9999;
                }

                record.NumberOfDaysReferralToFirstTreatment =
                    NumberHelper.GenerateRandomNumberBetween(rangeStart, rangeEnd);
            }

            return record;
        }

        

    }
}
