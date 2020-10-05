using System;
using Calculator;
using NUnit.Framework;


namespace CalculatorTests
{
  
    public class CalculatorTests
    {
        CalculatorApp calculator = new CalculatorApp();

        

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
        public void DivideByFloatTest()
        {
            Assert.AreEqual(6,calculator.Div(3, 0.5));

        }
       
    }

  
 }