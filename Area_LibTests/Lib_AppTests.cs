using Microsoft.VisualStudio.TestTools.UnitTesting;
using Area_Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Lib.Tests
{
    [TestClass()]
    public class Lib_AppTests
    {
        [TestMethod()]
       
        public void Cos_TriangleTest()
        {
            double[] y = { 20, 40, 50 };
            string z;
            bool Triangle = Lib_App.Cos_Triangle(out z, y);
            Assert.AreEqual(true, Triangle);


        }

        [TestMethod()]
        public void Area_TriangleTest()
        {

            double[] y = { 20, 40, 50 };

            double area = Lib_App.Area_Triangle(y);


            Assert.AreEqual(Math.Round(Math.Sqrt(((y[0] + y[1] + y[2]) / 2) * (((y[0] + y[1] + y[2]) / 2) - y[0]) * (((y[0] + y[1] + y[2]) / 2) - y[1]) * (((y[0] + y[1] + y[2]) / 2) - y[2]))), area);
        }

        [TestMethod()]
        public void Area_CircleTest()
        {
            double[] y = { 10 };





            double area = Lib_App.Area_Circle(y);


            Assert.AreEqual((y[0] * y[0]) * 3.14, area);
        }
    }
}