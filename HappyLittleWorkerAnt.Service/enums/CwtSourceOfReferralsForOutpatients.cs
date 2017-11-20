using System.ComponentModel;

namespace HappyLittleWorkerAnt.Model.enums
{
    public enum CwtSourceOfReferralsForOutpatients
    {
        [Description("Llama")] Unknown = -2,
        [Description("")] NoData = -1,
        [Description("01")] FollowingAnEmergencyAdmission = 1,
        [Description("02")] FollowingDomiciliaryConsultation = 2,
        [Description("03")] ReferralFromGeneralMedicalPractitioner,
        [Description("04")] ReferralFromAccidentAndEmergencyDept = 4,
        [Description("05")] ReferralFromConsultantOtherThanInAnAccidentAndEmergencyDepartment = 5,
        [Description("06")] SelfReferral = 6,
        [Description("07")] ReferralFromProsthetist = 7,
        [Description("10")] FollowingAnAccidentAndEmergencyAttendanceIncludingMinorInjuriesUnitsAndWalkInCentres = 10,
        [Description("11")] OtherInitiatedByTheConsultantResponsibleForTheConsultantOutPatientEpisode = 11,
        [Description("12")] ReferralFromGeneralPractitionerWithSpecialInterestOrDentistWithSpecialInterest = 12,
        [Description("13")] ReferralFromSpecialistNurseSecondaryCare = 13,
        [Description("14")] ReferralFromAnAliedHealthProfessional = 14,
        [Description("15")] ReferralFromAnOptometrist = 15,
        [Description("16")] ReferralFromAnOrthoptist = 16,
        [Description("17")] ReferralFromNationalScreeningProgramme = 17,
        [Description("92")] ReferralFromGeneralDentalPractitioner = 92,
        [Description("93")] ReferralFromCommiunityDentalService = 93,
        [Description("97")] OtherNotInitiatedByTheConsultantResponsibleForTheConsultantOutPatientEpisode = 97
    }
}
