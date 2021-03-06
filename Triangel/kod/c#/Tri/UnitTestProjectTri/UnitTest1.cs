﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectTri
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void NegativeInputDoubles()
        {
            Triangle t = new Triangle(1.5, -2.5, 1.5);
        }

        [TestMethod]

        public void BadTriangle()
        {
            Triangle t = new Triangle(1.0, 2.0, 3.0);
        }

        [TestMethod]

        public void EquitateralFalseDoubles_1()
        {
            Triangle t = new Triangle(3.6, 4.0, 5.7);
            Assert.IsTrue(!t.isEquilateral());
        }
               
        [TestMethod]

        public void IsoscelesFalseDoubles_1()
        {
            Triangle t = new Triangle(5.6, 6.0, 7.7);
            Assert.IsTrue(!t.isIsosceles());
        }

        [TestMethod]

        public void ScaleneTrueDoubles_1()
        {
            Triangle t = new Triangle(5.6, 6.0, 7.7);
            Assert.IsTrue(t.isScalene());
        }

        [TestMethod]

        public void EquilateralFalseDouble_2()
        {
            Triangle t = new Triangle(1.3, 1.35, 1.3);
            Assert.IsTrue(!t.isEquilateral());
        }

        [TestMethod]

        public void IsoscelesTrueDoubles_2()
        {
            Triangle t = new Triangle(1.3, 1.35, 1.3);
            Assert.IsTrue(t.isIsosceles());
        }

        [TestMethod]

        public void ScaleneFalseDoubles_2()
        {
            Triangle t = new Triangle(1.3, 0.35, 0.3);
            Assert.IsTrue(!t.isScalene());
        }

        [TestMethod]

        public void IsoscelesTruePoints_1()
        {
            Triangle t = new Triangle(0.0, 10.0, 5.20);
            Assert.IsTrue(t.isIsosceles());
        }

        [TestMethod]

        public void ScaleneTruePoints_2()
        {
            Triangle t = new Triangle(-1.1, 5.2, -7.1);
            Assert.IsTrue(t.isScalene());
        }

        [TestMethod]

        public void EquilateralTrueDoubles_3()
        {
            Triangle t = new Triangle(534.5, 534.5, 534.5);
            Assert.IsTrue(t.isEquilateral());
        }

        [TestMethod]

        public void IsoscelesFalseDoubles_3()
        {
            Triangle t = new Triangle(534.5, 534.5, 534.5);
            Assert.IsTrue(!t.isIsosceles());
        }

        [TestMethod]

        public void ScaleneFalseDoubles_3()
        {
            Triangle t = new Triangle(534.5, 534.5, 534.5);
            Assert.IsTrue(!t.isScalene());
        }

        [TestMethod]

        public void EquilateralTruePoints()
        {
            Point[] points = { new Point(0, 0), new Point(10, 0), new Point(5, 20) };
            Triangle t = new Triangle(points);
            Assert.IsTrue(t.isEquilateral());
        }
    }
}
