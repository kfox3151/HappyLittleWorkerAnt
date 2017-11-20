using System.ComponentModel;

namespace HappyLittleWorkerAnt.Model.enums
{
    public enum CwtCompliance
    {
        [Description("Llama")] Unknown = -2,
        [Description("")] NoData = -1,
        [Description("0")] NotComplied = 0,
        [Description("1")] Complied = 1,
    }
}
