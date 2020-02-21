using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Assignment02.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        [Test]
        public void Put222_Get_Equilateral_Triangle()
        {
            Assert.AreEqual("Equilateral Triangle", TriangleSolver.Analyze(2, 2, 2));
        }

        [Test]
        public void Put000_Get_Not_Valid_Triangle()
        {
            Assert.AreEqual("Not valid triangle", TriangleSolver.Analyze(0, 0, 0));
        }

        [Test]
        public void Put220_Get_Not_Valid_Triangle()
        {
            Assert.AreEqual("Not valid triangle", TriangleSolver.Analyze(2, 2, 0));
        }

        [Test]
        public void Put224_Get_Not_valid_Triangle()
        {
            Assert.AreEqual("Not valid triangle", TriangleSolver.Analyze(2, 2, 4));
        }
        [Test]
        public void Put123_Get_Not_valid_Triangle()
        {
            Assert.AreEqual("Not valid triangle", TriangleSolver.Analyze(1, 2, 3));
        }

        [Test]
        public void Put2_minus23_Get_Not_Valid_Triangle()
        {
            Assert.AreEqual("Not valid triangle", TriangleSolver.Analyze(2, -2, 3));
        }

        [Test]
        public void Put467_Get_Scalene_Triangle()
        {
            Assert.AreEqual("Scalene Triangle", TriangleSolver.Analyze(4, 6, 7));
        }

        [Test]
        public void Put_minus2_minus2_minus2_Get_Not_Valid_Triangle()
        {
            Assert.AreEqual("Not valid triangle", TriangleSolver.Analyze(-2, -2, -2));
        }
    }
}
