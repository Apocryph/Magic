using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Bus.Misc
{
    /// <summary>
    /// A modifier to a creature's power and toughness.
    /// </summary>
    public abstract class PowerToughnessAdjustment
    {
        public int PowerAdjustment { get; set; }

        public int ToughnessAdjustment { get; set; }

        public PowerToughnessAdjustment(int powerAdjustment, int toughnessAdjustment)
        {
            PowerAdjustment = powerAdjustment;
            ToughnessAdjustment = toughnessAdjustment;
        }
    }

    /// <summary>
    /// A semi-permenant adjustment to a creature's power and toughness
    /// </summary>
    public class Counter : PowerToughnessAdjustment
    {
        public Counter(int powerAdjustment, int toughnessAdjustment) : base(powerAdjustment, toughnessAdjustment)
        {
        }
    }

    /// <summary>
    /// A temporary adjustment to a creature's power and toughness
    /// </summary>
    public class TemporaryPowerToughnessAdjustment : PowerToughnessAdjustment
    {
        /// <summary>
        /// Need Something to express when the adjustment expires.
        /// </summary>
        public object Expires { get; set; }

        public TemporaryPowerToughnessAdjustment(int powerAdjustment, int toughnessAdjustment, object expires)
            : base(powerAdjustment, toughnessAdjustment)
        {
            Expires = expires;
        }
    }
}
