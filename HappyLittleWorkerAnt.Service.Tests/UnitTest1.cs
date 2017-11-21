﻿using System;
using System.Collections.Generic;
using HappyLittleWorkerAnt.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HappyLittleWorkerAnt.Service.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GenerateStageRecords_ReturnsCorrectNumberOfRecords()
        {
            var records = CwtRecordGenerator.GenerateStageRecords(10);

            const int expected = 10;

            var actual = records.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnNewPatientPathwayId_IdIsCorrectLength()
        {
            var record = new CwtStageRecord
            {
                PatientPathwayId = PatientPathwayIdGenerator.GetNewPatientPathwayId(),
            };

            const int expected = 20;

            var actual = record.PatientPathwayId;

            Assert.AreEqual(actual.Length, expected);

        }
    }
}
