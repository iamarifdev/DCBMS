﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DCBMS.DLL.DAO;
using DCBMS.DLL.Gateway;

namespace DCBMS.Middleware
{
    public class ReportHelper
    {
        ReportGateway _reportGateway = new ReportGateway();

        public List<TestReport> GetTestWiseReport(string fromDate, string toDate)
        {
            return _reportGateway.GetTestWiseReport(fromDate, toDate);
        }

        public List<TestReport> GetTypeWiseReport(string fromDate, string toDate)
        {
            return _reportGateway.GetTypeWiseReport(fromDate, toDate);
        }

        public List<UnpaidBill> GetUnpaidBillReport(string fromDate, string toDate)
        {
            return _reportGateway.GetUnpaidBillReport(fromDate, toDate);
        }
    }
}