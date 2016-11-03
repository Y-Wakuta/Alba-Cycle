using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*フロントギア：インナー
 * リア：外から5枚目
 * 回転数：速度 = 85 : 27
 * Hの時は、(ワット数) = 13.209 * (速度) - 60.712
 */

namespace AlbaCycle {
    class CycleRoutine {
        public double CadenceToWatt(double cadence) {
            double speed = cadence * (27 / 85);
            double watt = 13.209 * speed - 60.712;
            return watt;
        }
    }
}
