using System.ComponentModel;

namespace HappyLittleWorkerAnt.Model.enums
{
    public enum CwtCancerTreatmentModalities
    {
        [Description("Llama")] Unknown = -2,
        [Description("")] NoData = -1,
        [Description("01")] Surgery = 1,
        [Description("02")] AntiCancerDrugRegimenCytotoxicChemotherapy = 2,
        [Description("03")] AntiCancerDrugRegimenHormoneTherapy = 3,
        [Description("04")] Chemoradiotherapy = 4,
        [Description("05")] TeletherapyBeamRadiationExcludingProtonTherapy = 5,
        [Description("06")] Brachytherapy = 6,
        [Description("07")] SpecialistPalliativeCare = 7,
        [Description("08")] ActiveMonitoringexcludingNonSpecialistPalliativeCare = 8,
        [Description("09")] NonSpecialistPalliativeCareExcludingActiveMonitoring = 9,
        [Description("10")] RadiofrequencyAblation = 10,
        [Description("11")] HighIntensityFocusedUltrasound = 11,
        [Description("12")] Cryotherapy = 12,
        [Description("13")] ProtonTherapy = 13,
        [Description("14")] AntiCancerDrugRegimenOther = 14,
        [Description("15")] AntiCancerDrugRegimenImmunotherapy = 15,
        [Description("16")] LightTherapyIncludingPhotodynamicTherapyAndPsoralenAndUltravioletTherapy = 16,
        [Description("17")] HyperbaricOxygenTherapy = 17,
        [Description("19")] RadioisotopeTherapyIncludingRadioiodine = 19,
        [Description("20")] LaserTreatmentIncludingArgonBeamTherapy = 20,
        [Description("21")] BiologicalTherapiesExcludingImmunotherapy = 21,
        [Description("22")] Radiosurgery = 22,
        [Description("97")] OtherTreatment = 97,
        [Description("98")] AllTreatmentDeclined
    }
}
