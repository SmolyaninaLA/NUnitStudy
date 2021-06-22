using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
 

namespace NUnitStudy.Tests
{
   [TestFixture]
   public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Additional(100, 50) == 150);
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(300, 50) == 250);
        }

        [Test]
        public void MiltiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Miltiplication(50, 50) == 2500);
        }

        [Test]
        public void DivisonMustThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(10, 0));
        }


        [Test]
        public void DivisonMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(100, 2) == 50);
               
        }
    }
}
