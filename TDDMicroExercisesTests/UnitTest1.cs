using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Reflection;
using TDDMicroExercises.TirePressureMonitoringSystem;
using TDDMicroExercises.UnicodeFileToHtmlTextConverter;

namespace TDDMicroExercisesTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void TestAlarm()
        {
            Alarm alarm = new Alarm();
            alarm.Check();
            if (alarm.GetPsiPreasure > 17 && alarm.GetPsiPreasure < 21)
            {
                Assert.AreEqual(alarm.AlarmOn, false);
            }
            else
            {
                Assert.AreEqual(alarm.AlarmOn, true);
            }
        }

        [TestMethod]
        public void TestUnicodeFileToHtmlTextConverter()
        {
            string expectedResult = "test<br />";
            string testFilePath = "C:\\Temp\\UnicodeFileToHtmlConverterTestFile.txt";
            var htmlConvertor = new UnicodeFileToHtmlTextConverter(testFilePath);
            string result = htmlConvertor.ConvertToHtml();

            Assert.AreEqual(result, expectedResult);
        }
    }
}
