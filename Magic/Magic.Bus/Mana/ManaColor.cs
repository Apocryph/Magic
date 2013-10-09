using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Bus.Mana
{
    public enum ManaColor
    {
        [ManaColorAttribute("X")]
        Colorless,
        [ManaColorAttribute("G")]
        Green,
        [ManaColorAttribute("W")]
        White,
        [ManaColorAttribute("U")]
        Blue,
        [ManaColorAttribute("B")]
        Black,
        [ManaColorAttribute("R")]
        Red,
        [ManaColorAttribute("GW")]
        GreenWhite,
        [ManaColorAttribute("GU")]
        GreenBlue,
        [ManaColorAttribute("GB")]
        GreenBlack,
        [ManaColorAttribute("GR")]
        GreenRed,
        [ManaColorAttribute("WU")]
        WhiteBlue,
        [ManaColorAttribute("WB")]
        WhiteBlack,
        [ManaColorAttribute("WR")]
        WhiteRed,
        [ManaColorAttribute("UB")]
        BlueBlack,
        [ManaColorAttribute("UR")]
        BlueRed,
        [ManaColorAttribute("BR")]
        BlackRed,
        [ManaColorAttribute("2G")]
        DoubleColorlessGreen,
        [ManaColorAttribute("2W")]
        DoubleColorlessWhite,
        [ManaColorAttribute("2U")]
        DoubleColorlessBlue,
        [ManaColorAttribute("2B")]
        DoubleColorlessBlack,
        [ManaColorAttribute("2R")]
        DoubleColorlessRed,
    }
}
