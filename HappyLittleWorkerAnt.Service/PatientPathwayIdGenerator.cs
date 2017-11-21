using System.Text;
using Common;

namespace HappyLittleWorkerAnt.Service
{
    public class PatientPathwayIdGenerator
    {

        public static string GetNewPatientPathwayId()
        {
            string patientPathwayId = "TR1C";
            var builder = new StringBuilder();
            var randomNumber = NumberHelper.GenerateRandomNumber();

            while (builder.Length < 16)
            {
                builder.Append(randomNumber.Next(9).ToString());
            }

            patientPathwayId += builder;

            return patientPathwayId;

           

           
                
                
             
    }

    }
}
