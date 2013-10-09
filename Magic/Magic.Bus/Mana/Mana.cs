using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Bus.Mana
{
    [Serializable]
    public class Mana
    {
        [NonSerialized]
        private Dictionary<ManaColor, int> _dict;

        #region ConvertedManaCost
        public int ConvertedManaCost
        {
            get
            {
                var doubleCostColors = _dict.Where(IsDoubleCostColor);
                var singleCostColors = _dict.Except(doubleCostColors);
                return singleCostColors.Select(mana => mana.Value).Sum() + doubleCostColors.Select(mana => mana.Value * 2).Sum();
            }
        }

        private bool IsDoubleCostColor(KeyValuePair<ManaColor, int> mana)
        {
            return mana.Key == ManaColor.DoubleColorlessGreen ||
                    mana.Key == ManaColor.DoubleColorlessWhite ||
                    mana.Key == ManaColor.DoubleColorlessBlue ||
                    mana.Key == ManaColor.DoubleColorlessBlack ||
                    mana.Key == ManaColor.DoubleColorlessRed;
        }
        #endregion ConvertedManaCost

        #region ManaCostString
        public string ManaCostString
        {
            get
            {
                StringBuilder manaBuilder = new StringBuilder();
                _dict.OrderBy(mana => mana.Key).ToList().ForEach(mana => AppendIndividualManaCost(manaBuilder, mana));
                return manaBuilder.ToString();
            }
        }

        private void AppendIndividualManaCost(StringBuilder manaBuilder, KeyValuePair<ManaColor, int> mana)
        {
            for (int i = 0; i < mana.Value; i++)
            {
                manaBuilder.AppendFormat("{{0}}", GetColorShortName(mana.Key));
            }
        }

        private string GetColorShortName(ManaColor mc)
        {
            var attrs = mc.GetType().GetCustomAttributes(typeof(ManaColorAttribute), false);
            if (!attrs.Any())
                throw new NotImplementedException();
            return (attrs.First() as ManaColorAttribute).ColorShortName;
        }
        #endregion ManaCostString

        #region ExplicitAccessors

        public int Colorless { get { return this[ManaColor.Colorless]; } set { this[ManaColor.Colorless] = value; } }
        public int Green { get { return this[ManaColor.Green]; } set { this[ManaColor.Green] = value; } }
        public int White { get { return this[ManaColor.White]; } set { this[ManaColor.White] = value; } }
        public int Blue { get { return this[ManaColor.Blue]; } set { this[ManaColor.Blue] = value; } }
        public int Black { get { return this[ManaColor.Black]; } set { this[ManaColor.Black] = value; } }
        public int Red { get { return this[ManaColor.Red]; } set { this[ManaColor.Red] = value; } }
        public int GreenWhite { get { return this[ManaColor.GreenWhite]; } set { this[ManaColor.GreenWhite] = value; } }
        public int GreenBlue { get { return this[ManaColor.GreenBlue]; } set { this[ManaColor.GreenBlue] = value; } }
        public int GreenBlack { get { return this[ManaColor.GreenBlack]; } set { this[ManaColor.GreenBlack] = value; } }
        public int GreenRed { get { return this[ManaColor.GreenRed]; } set { this[ManaColor.GreenRed] = value; } }
        public int WhiteBlue { get { return this[ManaColor.WhiteBlue]; } set { this[ManaColor.WhiteBlue] = value; } }
        public int WhiteBlack { get { return this[ManaColor.WhiteBlack]; } set { this[ManaColor.WhiteBlack] = value; } }
        public int WhiteRed { get { return this[ManaColor.WhiteRed]; } set { this[ManaColor.WhiteRed] = value; } }
        public int BlueBlack { get { return this[ManaColor.BlueBlack]; } set { this[ManaColor.BlueBlack] = value; } }
        public int BlueRed { get { return this[ManaColor.BlueRed]; } set { this[ManaColor.BlueRed] = value; } }
        public int BlackRed { get { return this[ManaColor.BlackRed]; } set { this[ManaColor.BlackRed] = value; } }
        public int DoubleColorlessGreen { get { return this[ManaColor.DoubleColorlessGreen]; } set { this[ManaColor.DoubleColorlessGreen] = value; } }
        public int DoubleColorlessWhite { get { return this[ManaColor.DoubleColorlessWhite]; } set { this[ManaColor.DoubleColorlessWhite] = value; } }
        public int DoubleColorlessBlue { get { return this[ManaColor.DoubleColorlessBlue]; } set { this[ManaColor.DoubleColorlessBlue] = value; } }
        public int DoubleColorlessBlack { get { return this[ManaColor.DoubleColorlessBlack]; } set { this[ManaColor.DoubleColorlessBlack] = value; } }
        public int DoubleColorlessRed { get { return this[ManaColor.DoubleColorlessRed]; } set { this[ManaColor.DoubleColorlessRed] = value; } }

        #endregion ExplicitAccessors

        #region Accessors
        public int this[ManaColor color]
        {
            get { return GetCostForColor(color); }
            set { SetCostForColor(color, value); }
        }

        private int GetCostForColor(ManaColor color)
        {
            if (_dict.ContainsKey(color))
                return _dict[color];
            return 0;
        }

        private void SetCostForColor(ManaColor color, int cost)
        {
            if (_dict.ContainsKey(color))
                _dict[color] = cost;
            else
                _dict.Add(color, cost);
        }
        #endregion Accessors

        public Mana()
        {
            _dict = new Dictionary<ManaColor, int>();
        }
    }
}
