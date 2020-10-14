using System;
using Calculator;
using NUnit.Framework;


namespace CalculatorTests
{
  
    public class CalculatorTests
    {
        CalculatorApp calculator = new CalculatorApp();

        [Test]
        public void AddTest()
        {
            Assert.AreEqual(2, calculator.Add(1, 1));
            Assert.AreEqual(2.2, calculator.Add(1.1, 1.1));
           
        }

        [Test]
        public void SubTest()
        {
            Assert.AreEqual(1, calculator.Sub(2, 1));
            Assert.AreEqual(0.5, calculator.Sub(1, 0.5));

        }

        [Test]
        public void MultTest()
        {
            Assert.AreEqual(1, calculator.Mult(1, 1));
            Assert.AreEqual(1.5, calculator.Mult(3, 0.5));
        }
        

        [Test]
        public void DivideByZeroTest()
        {
            try
            {
                calculator.Div(4, 0);
            }
            catch (Exception ex)
            {

                Assert.IsTrue(ex.GetType() == typeof(DivideByZeroException));
            }
        }

        [Test]
        public void DivideByDblTest()
        {
            Assert.AreEqual(6,calculator.Div(3, 0.5));

        }

        [Test]
        public void DivDblByInt()
        {
            Assert.AreEqual(0.25, calculator.Div(0.5, 2));
        }
       
    }

  
 }