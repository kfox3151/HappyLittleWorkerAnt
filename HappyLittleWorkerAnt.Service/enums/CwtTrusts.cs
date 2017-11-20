using System.ComponentModel;

namespace HappyLittleWorkerAnt.Model.enums
{
    public enum CwtTrusts
    {
        [Description("Llama")] Unknown = -2,
        [Description("")] NoData = -1,
        [Description("R1F01")] StMarysHospital = 1,
        [Description("R1H12")] TheRoyalLondon = 2,
        [Description("R1HNH")] NewhamGeneralHospital = 3,
        [Description("RC110")] BedfordHospitalSouthWing = 4,
        [Description("RC386")] EalingHospital = 5,
        [Description("RC971")] LutonAndDunstableHospital = 6,
        [Description("RTH02")] TheChurchillHospital = 7,
        [Description("RTH05")] TheHorntonHospital = 8,
        [Description("RTH08")] TheJohnRadcliffeHospital = 9,
        [Description("R1C34")] TheRoyalSouthHantsHospital = 10,
        [Description("R1C36")] PrincessAnneHospital = 11,
        [Description("R1C40")] SouthamptonGeneralHospital = 12,
        [Description("R1C46")] RomseyHospital = 13
    }
}
