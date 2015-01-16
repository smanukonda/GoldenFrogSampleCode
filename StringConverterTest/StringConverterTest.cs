using GoldenFrogStringConverter;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ArrayHelperUnitTest
{
    /// <summary>
    /// Test class for the array helper
    /// </summary>
    [TestClass]
    public class StringConverterTest
    {
        [TestMethod]
        public void ConvertStringInputTest()
        {
            string output = StringConverter.ConvertInput("aeiou");
            Assert.AreEqual(output, "UOIEA");     //true
            output = StringConverter.ConvertInput("AbCio");
            Assert.AreEqual(output, "OIcbA");     //true
            output = StringConverter.ConvertInput("AbCio2");
            Assert.AreEqual(output, "2OIcbA");     //true
        }
        /*
        [TestMethod]
        public void ConvertCharArrayTest()
        {
            //Empty array test
            var convertedArray = StringConverter.ReverseElementsAndConvert(new char[] { });
            Assert.AreEqual(convertedArray.Length, 0);     //true

            //All vowels test
            convertedArray = StringConverter.ReverseElementsAndConvert(new char[] {'a','E','i','o','u' });
            Assert.AreEqual(convertedArray[0], 'U');     //true
            Assert.AreEqual(convertedArray[1], 'O');     //true
            Assert.AreEqual(convertedArray[2], 'I');     //true
            Assert.AreEqual(convertedArray[3], 'E');     //true
            Assert.AreEqual(convertedArray[4], 'A');     //true
            //Negative Test
            Assert.AreNotEqual(convertedArray[4], 'a');     //true

            //Mix of vowels and consonants test
            convertedArray = StringConverter.ReverseElementsAndConvert(new char[] { 'F', 'a', 'b','C', 'i','O' });
            Assert.AreEqual(convertedArray[0], 'O');     //true
            Assert.AreEqual(convertedArray[1], 'I');     //true
            Assert.AreEqual(convertedArray[2], 'c');     //true
            Assert.AreEqual(convertedArray[3], 'b');     //true
            Assert.AreEqual(convertedArray[4], 'A');     //true            
            Assert.AreEqual(convertedArray[5], 'f');     //true
            //Negative test
            Assert.AreNotEqual(convertedArray[5], 'F');     //true       
        }
        */
    }
}
