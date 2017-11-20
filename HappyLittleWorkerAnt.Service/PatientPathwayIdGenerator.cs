using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HappyLittleWorkerAnt.Model
{
    public class PatientPathwayIdGenerator
    {

        public static string GetNewPatientPathwayId()
        {
            string patientPathwayId = "TR1C";
            var builder = new StringBuilder();
            Random randomNumber = new Random();

            while (builder.Length < 16)
            {
                builder.Append(randomNumber.Next(9).ToString());
            }

            patientPathwayId += builder;

            return patientPathwayId;

           

           
                
                
             
    }

    }
}
