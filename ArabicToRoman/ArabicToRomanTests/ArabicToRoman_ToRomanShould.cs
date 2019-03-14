using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArabicToRomanServices;

namespace ArabicToRomanTests
{
    [TestClass]
    public class ArabicToRoman_ToRomanShould
    {
        private readonly ArabicToRoman _arabicToRoman;

        public ArabicToRoman_ToRomanShould()
        {
            this._arabicToRoman = new ArabicToRoman();
        }

        [TestMethod]
        public void ReturnsMMCMXLIVWith2944()
        {
            var result = this._arabicToRoman.ToRoman(2944);

            Assert.AreEqual("MMCMXLIV", result, false, string.Empty);
        }

        [TestMethod]
        public void ReturnsIVWith4()
        {
            var result = this._arabicToRoman.ToRoman(4);

            Assert.AreEqual("IV", result, false, string.Empty);
        }

        [TestMethod]
        public void ReturnsIIIWith3()
        {
            var result = this._arabicToRoman.ToRoman(3);

            Assert.AreEqual("III", result, false, string.Empty);
        }

        [TestMethod]
        public void ReturnsIIWith2()
        {
            var result = this._arabicToRoman.ToRoman(2);

            Assert.AreEqual("II", result, false, string.Empty);
        }

        [TestMethod]
        public void ReturnsIWith1()
        {
            var result = this._arabicToRoman.ToRoman(1);

            Assert.AreEqual("I", result, false, string.Empty);
        }
    }
}
