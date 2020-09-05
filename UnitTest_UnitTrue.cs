using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalcLib.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Divide10on5()
        {
            MyCalc myCalc = new MyCalc();
            double result = myCalc.Divide(10, 5);
            Assert.AreEqual(result,2);
        }

        [TestMethod]
        public void DivideOnZero()
        {
            MyCalc myCalc = new MyCalc();
            try
            {
                myCalc.Divide(1,0);
            }
            catch(MyException ex)
            {
                return;
            }
            catch(Exception ex)
            {
                Assert.Fail("Неверный тип исключения");
            }

            Assert.Fail("Исключение не сгенерировано");
        }
    }
}
