﻿using System.Data;
using DCBMS.DLL.DAO;
using DCBMS.DLL.Gateway;

namespace DCBMS.Middleware
{
    public class TestTypeHelper
    {
        TestTypeGateway newGateway = new TestTypeGateway();
        public void AddNewTestTye(TestTypeDao newTestType)
        {
            newGateway.AddNewTestTye(newTestType);
        }

        public DataTable GetAllTestType()
        {
            return newGateway.GetAllTestType();
        }
    }
}