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
 * Hの時は、(ワット数) = 0.0081 * (速度) * (速度) + 12.682 * (速度) - 54.568
 * 5の時は、(ワット数) = 0.0327 * (速度) * (速度) + 11.26 *(速度) - 47.977
 * 4の時は、(ワット数) = 0.0379 * (速度) * (速度) + 10.691 * (速度) - 45.341
 * 3の時は、(ワット数) = 0.0526 * (速度) * (速度) + 9.8239 * (速度) - 40.682
 * 2の時は、(ワット数) = 0.067 * (速度) * (速度) - 7.0775 * (速度) - 31.545
 * 1の時は、(ワット数) = 0.0668 * (速度) * (速度) - 5.3226 * (速度) -25.045
 */

namespace AlbaCycle {
    static public class CycleRoutine {
        static public double CadenceToWatt(double cadence, int loadFlag) {
            double speed = cadence * (27.0 / 85.0);
            double watt = 0.0;
            switch (loadFlag) {
                case 6:
                    watt = 0.0081 * speed * speed + 12.682 * speed - 54.568;
                    break;
                case 5:
                    watt = 0.0327 * speed * speed + 11.26 * speed - 47.977;
                    break;
                case 4:
                    watt = 0.0379 * speed * speed + 10.691 * speed - 45.341;
                    break;
                case 3:
                    watt = 0.0526 * speed * speed + 9.8239 * speed - 40.682;
                    break;
                case 2:
                    watt = 0.067 * speed * speed + 7.0775 * speed - 31.545;
                    break;
                case 1:
                    watt = 0.0668 * speed * speed + 5.3226 * speed - 25.045;
                    break;
            }
            return watt;
        }
        /// <summary>
        /// リストに保存したデータをcsvに出力します
        /// </summary>
        /// <param name="data">配列化していない受信データ</param>
        /// <param name="path"></param>
        static public void writeDatas(List<CycleDatas> data, string path) {
            var sw = new StreamWriter(path, false);
            foreach (var dt in data) {
                sw.Write("{0},{1},{2},\n,", dt.Cadence, dt.Watt, dt.Speed);
            }
            sw.Close();
        }
        //指定した精度の桁に切り下げ
        public static double ToRoundDown(double dValue, int iDigits) {
            double dCoef = System.Math.Pow(10, iDigits);

            return dValue > 0 ? System.Math.Floor(dValue * dCoef) / dCoef :
                                System.Math.Ceiling(dValue * dCoef) / dCoef;
        }
    }
}
