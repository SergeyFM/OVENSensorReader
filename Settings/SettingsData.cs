﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvenSensorReader.Settings {
    internal class SettingsData {

        public string ComPort { get; set; }
        public int Timeout { get; set; }
        public List<bool> CheckBoxesList { get; set; }
        public bool LoopCheckBox { get; set; }
        public List<OvenSettings> OvenSettingsList { get; set; }
    }
}