﻿using System;

namespace DCBMS.Model
{
    [Serializable]
    public class TestReport
    {
        public string Serial { get; set; }
        public string TestName { get; private set; }
        public string TestType { get; set; }
        public int TotalTest { get; set; }
        public decimal TotalAmount { get; set; }

        public TestReport(string serial, string testName, int totalTest, decimal totalAmount)
        {
            Serial = serial;
            TestName = testName;
            TotalTest = totalTest;
            TotalAmount = totalAmount;
        }

        public TestReport()
        {

        }
    }
}