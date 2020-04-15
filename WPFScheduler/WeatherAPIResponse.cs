﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFScheduler
{
    public class WeatherAPIResponse
    {

        public List<GeneralInfo> Weather { get; set; }
        public WeatherInfo Main { get; set; }

        public class GeneralInfo
        {
            public string Main { get; set; }
            public string Description { get; set; }
        }

        public class WeatherInfo
        {
            public double Temp { get; set; }
            public int Pressure { get; set; }
            public int Humidity { get; set; }
            public double Temp_min { get; set; }
            public double Temp_max { get; set; }
        }
    }
}