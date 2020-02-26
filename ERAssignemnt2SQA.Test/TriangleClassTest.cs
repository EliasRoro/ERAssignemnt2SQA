using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAssignemnt2SQA.Test
{
    [TestFixture]
    public class TriangleClassTest
    {
        List<int> sides;
        readonly string expectedNoTriangle = "The sides do not form a triangle!";
        readonly string expectedEquilateral = "This is an equilateral triangle!";
        readonly string expectedIsosceles = "This is an isosceles triangle!";
        readonly string expectedScalene = "This is an scalene triangle!";


        [Test]
        public void Analyze1()
        {
            sides = new List<int> { 1, 2, 3 };

            StringAssert.AreEqualIgnoringCase(expectedNoTriangle, TriangleClass.Analyze(ref sides));
        }

        [Test]
        public void Analyze2()
        {
            sides = new List<int> { 2, 2, 2 };

            StringAssert.AreEqualIgnoringCase(expectedEquilateral, TriangleClass.Analyze(ref sides));
        }

        [Test]
        public void Analyze3()
        {
            sides = new List<int> { 5, 5, 5 };

            StringAssert.AreEqualIgnoringCase(expectedEquilateral, TriangleClass.Analyze(ref sides));
        }

        [Test]
        public void Analyze4()
        {
            sides = new List<int> { 2, 3, 3 };

            StringAssert.AreEqualIgnoringCase(expectedIsosceles, TriangleClass.Analyze(ref sides));
        }

        [Test]
        public void Analyze5()
        {
            sides = new List<int> { 2, 3, 4 };

            StringAssert.AreEqualIgnoringCase(expectedScalene, TriangleClass.Analyze(ref sides));
        }

        [Test]
        public void Analyze6()
        {
            sides = new List<int> { 4, 6, 8 };

            StringAssert.AreEqualIgnoringCase(expectedScalene, TriangleClass.Analyze(ref sides));
        }
    }
}
