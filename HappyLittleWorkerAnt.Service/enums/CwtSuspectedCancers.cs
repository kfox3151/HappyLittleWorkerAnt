using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyLittleWorkerAnt.Model.enums
{
    public enum CwtSuspectedCancers
    {
        [Description("Llama")] Unknown = -2,
        [Description("")] NoData = -1,
        [Description("01")] SuspectedBreastCancer = 1,
        [Description("02")] SuspectedChildrensCancer = 2,
        [Description("03")] SuspectedLungCancer = 3,
        [Description("04")] SuspectedHaematologicalMaliganciesExclidingAcuteLeukaemia = 4,
        [Description("05")] SuspectedAcuteLeukaemia = 5,
        [Description("06")] SuspectedUpperGastrointestinalCancers = 6,
        [Description("07")] SuspectedLowerGastrointestinalCancers = 7,
        [Description("08")] SuspectedSkinCancers = 8,
        [Description("09")] SuspectedGynaecologicalCancers = 9,
        [Description("10")] SuspectedBrainOrCentralNervousSystemTumours = 10,
        [Description("11")] SuspectedUrologicalCancersExcludingTesticular = 11,
        [Description("12")] SuspectedTesticularCancer = 12,
        [Description("13")] SuspectedHeadAndNecoCancers = 13,
        [Description("14")] SuspectedSarcomas = 14,
        [Description("15")] OtherSuspectedCancer = 15,
        [Description("16")] ExhibitedNotCancerBreastSymptomsCancerNotInitiallySuspected = 16
    }
}
