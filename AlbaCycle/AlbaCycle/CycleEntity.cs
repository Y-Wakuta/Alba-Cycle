﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AlbaCycle {
    class CycleEntity {
    }
    /// <summary>
    /// マクロを定義
    /// </summary>
    static public class Constants {
       static public int minDataPoolAmount = 400;
       static public int maxDataPoolAmount = 5000;
    }

    /// <summary>
    /// コンボボックスでアイテムとして使用するためのメンバを作成
    /// </summary>
    public class bauditems {
        public string NAME { get; set; }

        public int RATE { get; set; }
    }
    public class portNames {
        public string portName { get; set; }
    }
    /// <summary>
    /// データを保存したパスを保持
    /// </summary>
    public class filePath {
        public string pathName { get; set; }
    }

    public class CycleDatas {
        public string Cadence { get; set; }
        public string Speed { get; set; }
        public string Watt { get; set; }
        public Stopwatch Timer { get; set; }
        public string Voltage { get; set; }

    }
}
