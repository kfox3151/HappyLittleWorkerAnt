using System.ComponentModel;

namespace HappyLittleWorkerAnt.Model.enums
{
    public enum CwtPrimaryDiagnosis
    {
        [Description("Llama")] Unknown = -2,
        [Description("")] NoData = -1,
        [Description("C00.0")] ExternalUpperLip = 1,
        [Description("C00.1")] ExternalLowerLip = 2,
        [Description("C01")] MalignantNeoplasmOfBaseOfTongue = 10,
        [Description("C04.9")] FloorOfMouthUnspecified = 24,
        [Description("C47.3")] PeripheralNervesOfThorax = 210,
        [Description("C83.0")] BcellLymphoma = 393
    }
}
