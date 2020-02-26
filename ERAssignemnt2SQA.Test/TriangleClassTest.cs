//Elias Roro
//Assignemnt 2 
// Due date : 2020-02-27
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




        //Testing the analyze method to see if it will correctly check whether three sides form a proper triangle.
        //Three integers are passed through to the method, and two of the sides added must be greater than the third.
        //This test will check the second and third integers added compared to the first length

        [Test]
        public void Analyze1()
        {
            sides = new List<int> { 1, 2, 3 };

            StringAssert.AreEqualIgnoringCase(expectedNoTriangle, TriangleClass.Analyze(ref sides));
        }

        //Testing the analyze method to see if it will return the strong confirming an equilateral triangle.  
        //All sides must be the same in length for it to return the expected string
        [Test]
        public void Analyze2()
        {
            sides = new List<int> { 2, 2, 2 };

            StringAssert.AreEqualIgnoringCase(expectedEquilateral, TriangleClass.Analyze(ref sides));
        }

        //Testing the analyze method to see if it will return the strong confirming an equilateral triangle.  
        //All sides must be the same in length for it to return the expected string

        [Test]
        public void Analyze3()
        {
            sides = new List<int> { 5, 5, 5 };

            StringAssert.AreEqualIgnoringCase(expectedEquilateral, TriangleClass.Analyze(ref sides));
        }

        //Testing the analyze method to see if it will return the string confirming a isosceles triangle.
        // This is one of the possibl based on the integers passed through. 
        //Two sides must be the same in length for the expected string to return
        [Test]
        public void Analyze4()
        {
            sides = new List<int> { 2, 3, 3 };

            StringAssert.AreEqualIgnoringCase(expectedIsosceles, TriangleClass.Analyze(ref sides));
        }

        //Testing the analyze method to see if it will return the string confirming a Scalene triangle. 
        //This is one of the possible based on the integers passed through. 
        //All sides must be different in length for the expected string to return
        [Test]
        public void Analyze5()
        {
            sides = new List<int> { 2, 3, 4 };

            StringAssert.AreEqualIgnoringCase(expectedScalene, TriangleClass.Analyze(ref sides));
        }

        //Testing the analyze method to see if it will return the string confirming a Scalene triangle. 
        //This is one of the possible based on the integers passed through. 
        //All sides must be different in length for the expected string to return
        [Test]
        public void Analyze6()
        {
            sides = new List<int> { 4, 6, 8 };

            StringAssert.AreEqualIgnoringCase(expectedScalene, TriangleClass.Analyze(ref sides));
        }
    }
}
