using MultiProjectTest.Entities;
using System;
using System.Collections.Generic;

namespace MultiProjectTest.Service
{
    public class TestService
    {
        public List<TestModel> GetTestData()
        {
            return new List<TestModel>
            {
                new TestModel(1,"Viram"),
                new TestModel(2,"Diksha"),
            };
        }
    }
}
