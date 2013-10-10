using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Magic.Bus.Cards;
using Magic.Bus.Misc;

namespace Magic.Bus.Tests
{
    [TestClass]
    public class CardTests
    {
        public Card LlanowarElves
        {
            get
            {
                Card value = new Card();
                value.Name = "Llanowar Elves";
                value.ManaCost = new Mana.ManaValue() { Green = 1 };
                value.CardTypes.Add(CardType.Creature);
                value.CreatureTypes.Add(CreatureType.Elf);
                value.CreatureTypes.Add(CreatureType.Druid);
                value.BasePower = 1;
                value.BaseToughness = 1;
                return value;
            }
        }

        public Card GiantGrowth
        {
            get
            {
                Card value = new Card();
                value.Name = "Giant Growth";
                value.ManaCost = new Mana.ManaValue() { Green = 1 };
                value.CardTypes.Add(CardType.Instant);
                return value;
            }
        }

        public Card Purphoros
        {
            get
            {
                Card value = new Card();
                value.Name = "Purphoros";
                value.ManaCost = new Mana.ManaValue() { Colorless = 2, Red = 3 };
                value.CardTypes.Add(CardType.Creature);
                value.CardTypes.Add(CardType.Enchantment);
                value.BasePower = 5;
                value.BaseToughness = 5;
                return value;
            }
        }

        [TestMethod]
        public void IsPermenant_LlanowarElves()
        {
            Assert.IsTrue(LlanowarElves.IsPermenant);
        }

        [TestMethod]
        public void IsPermenant_GiantGrowth()
        {
            Assert.IsFalse(GiantGrowth.IsPermenant);
        }

        [TestMethod]
        public void IsPermenant_Purphoros()
        {
            Assert.IsTrue(Purphoros.IsPermenant);
        }

        [TestMethod]
        public void CountersAdjustPower_LlanowarElves()
        {
            Card elves = LlanowarElves;
            elves.PowerToughnessAdjustments.Add(new Counter(4, 0));
            elves.PowerToughnessAdjustments.Add(new Counter(-1, 0));
            Assert.AreEqual(4, elves.Power);
        }

        [TestMethod]
        public void CountersAdjustToughness_LlanowarElves()
        {
            Card elves = LlanowarElves;
            elves.PowerToughnessAdjustments.Add(new Counter(0, 4));
            elves.PowerToughnessAdjustments.Add(new Counter(0, -1));
            Assert.AreEqual(4, elves.Toughness);
        }
        
    }
}
