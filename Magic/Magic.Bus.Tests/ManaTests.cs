using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Magic.Bus.Mana;
using Magic.Bus.Misc;

namespace Magic.Bus.Tests
{
    /// <summary>
    /// Summary description for ManaTests
    /// </summary>
    [TestClass]
    public class ManaTests
    {

        #region ManaValues

        public ManaValue PrimaryColors
        {
            get
            {
                ManaValue value = new ManaValue();
                value.Red = 1;
                value[ManaColor.Green] = 1;
                value.Black = 1;
                value.White = 1;
                value[ManaColor.Blue] = 1;
                return value;
            }
        }

        public ManaValue Overrun
        {
            get
            {
                ManaValue value = new ManaValue();
                value.Green = 2;
                value.Colorless = 3;
                return value;
            }
        }

        public ManaValue BorosReckoner
        {
            get
            {
                ManaValue value = new ManaValue();
                value.WhiteRed = 3;
                return value;
            }
        }

        public ManaValue AdviceFromFae
        {
            get
            {
                ManaValue value = new ManaValue();
                value[ManaColor.DoubleColorlessBlue] = 3;
                return value;
            }
        }

        public ManaValue FireBall
        {
            get
            {
                ManaValue value = new ManaValue();
                value.Red = 1;
                value.Variable = 1;
                return value;
            }
        }

        public ManaValue EntreatTheAngels
        {
            get
            {
                ManaValue value = new ManaValue();
                value.Variable = 2;
                value.White = 3;
                return value;
            }
        }

        public ManaValue ActOfAgression
        {
            get
            {
                ManaValue value = new ManaValue();
                value.Colorless = 3;
                value.PhyrexianRed = 2;
                return value;
            }
        }

        public ManaValue OneOfEachColor
        {
            get
            {
                ManaValue value = new ManaValue();
                EnumHelper.GetValueList<ManaColor>().ForEach(manaColor => value[manaColor] = 1);
                return value;
            }
        }

        #endregion ManaValues

        #region ManaCostString Tests

        [TestMethod]
        public void EnumHelper_GetColorString()
        {
            string expected = "G";
            string actual = ManaColor.Green.GetAttributeOfType<ManaColorAttribute>().ColorShortName;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ManaCostString_Basic_PrimaryColors()
        {
            Assert.AreEqual("{G}{W}{U}{B}{R}", PrimaryColors.ManaCostString);
        }

        [TestMethod]
        public void ManaCostString_Overrun()
        {
            Assert.AreEqual("{3}{G}{G}", Overrun.ManaCostString);
        }

        [TestMethod]
        public void ManaCostString_BorosReckoner()
        {
            Assert.AreEqual("{WR}{WR}{WR}", BorosReckoner.ManaCostString);
        }

        [TestMethod]
        public void ManaCostString_AdviceFromFae()
        {
            Assert.AreEqual("{2U}{2U}{2U}", AdviceFromFae.ManaCostString);
        }

        [TestMethod]
        public void ManaCostString_Fireball()
        {
            Assert.AreEqual("{X}{R}", FireBall.ManaCostString);
        }

        [TestMethod]
        public void ManaCostString_EntreatTheAngels()
        {
            Assert.AreEqual("{X}{X}{W}{W}{W}", EntreatTheAngels.ManaCostString);
        }

        [TestMethod]
        public void ManaCostString_ActOfAgression()
        {
            Assert.AreEqual("{3}{PR}{PR}", ActOfAgression.ManaCostString);
        }

        [TestMethod]
        public void ManaCostString_OneOfEachColor()
        {
            Assert.AreEqual("{X}{1}{G}{W}{U}{B}{R}{GW}{GU}{GB}{GR}{WU}{WB}{WR}{UB}{UR}{BR}{2G}{2W}{2U}{2B}{2R}{PG}{PW}{PU}{PB}{PR}", OneOfEachColor.ManaCostString);
        }

        #endregion ManaCostStringTests

        #region ConvertedManaCost Tests

        [TestMethod]
        public void ConvertedManaCost_PrimaryColors()
        {
            Assert.AreEqual(5, PrimaryColors.ConvertedManaCost);
        }

        [TestMethod]
        public void ConvertedManaCost_Overrun()
        {
            Assert.AreEqual(5, Overrun.ConvertedManaCost);
        }

        [TestMethod]
        public void ConvertedManaCost_BorosReckoner()
        {
            Assert.AreEqual(3, BorosReckoner.ConvertedManaCost);
        }

        [TestMethod]
        public void ConvertedManaCost_AdviceFromFae()
        {
            Assert.AreEqual(6, AdviceFromFae.ConvertedManaCost);
        }

        [TestMethod]
        public void ConvertedManaCost_Fireball()
        {
            Assert.AreEqual(1, FireBall.ConvertedManaCost);
        }

        [TestMethod]
        public void ConvertedManaCost_EntreatTheAngels()
        {
            Assert.AreEqual(3, EntreatTheAngels.ConvertedManaCost);
        }

        [TestMethod]
        public void ConvertedManaCost_ActOfAgression()
        {
            Assert.AreEqual(5, ActOfAgression.ConvertedManaCost);
        }

        [TestMethod]
        public void ConvertedManaCost_OneOfEachColor()
        {
            Assert.AreEqual(31, OneOfEachColor.ConvertedManaCost);
        }

        #endregion ConvertedManaCost Tests

    }
}
