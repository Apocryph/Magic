using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Bus.Misc
{
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

    public class Counter : PowerToughnessAdjustment
    {
        public Counter(int powerAdjustment, int toughnessAdjustment) : base(powerAdjustment, toughnessAdjustment)
        {
        }
    }

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
