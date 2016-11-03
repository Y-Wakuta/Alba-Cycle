using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
using System.IO;

/*フロントギア：インナー
 * リア：外から5枚目
 * 回転数：速度 = 85 : 27
 * Hの時は、(ワット数) = 13.209 * (速度) - 60.712
 */

namespace AlbaCycle {
   public class CycleRoutine {
        public double CadenceToWatt(double cadence) {
            double speed = cadence * (27 / 85);
            double watt = 13.209 * speed - 60.712;
            return watt;
        }
        /// <summary>
        /// リストに保存したデータをcsvに出力します
        /// </summary>
        /// <param name="data">配列化していない受信データ</param>
        /// <param name="path"></param>
        public void writeDatas(List<CycleDatas> data, string path) {
            var sw = new StreamWriter(path, false);
            foreach (var dt in data) {
                sw.Write("{0},{1},{2},\n,",dt.Cadence,dt.Watt,dt.Speed);
            }
            sw.Close();
        }
    }
}
