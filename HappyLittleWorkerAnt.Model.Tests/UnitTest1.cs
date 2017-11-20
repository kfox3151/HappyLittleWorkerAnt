using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HappyLittleWorkerAnt.Model.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GenerateStageRecords_ReturnsCorrectNumberOfRecords()
        {
            List<CwtStageRecord> records = RecordGenerator.GenerateStageRecords(10);

            var expected = 10;

            var actual = records.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnNewPatientPathwayId_IdIsCorrectLength()
        {
            CwtStageRecord record = new CwtStageRecord
            {
                PatientPathwayId = PatientPathwayIdGenerator.GetNewPatientPathwayId(),
            };

            var expected = 20;

            var actual = record.PatientPathwayId;

            Assert.AreEqual(actual.Length, expected);
            
        }

    }
}
