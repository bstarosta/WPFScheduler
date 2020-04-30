using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPILibrary
{
    /// <summary>
    /// Klasa modelująca odpowiedź API pogodowego
    /// </summary>
    public class WeatherAPIResponse
    {
        /// <value> Przechowuje identyfikator obrazka odzwieriedlającego stan pogodowy</value>
        public List<GeneralInfo> Weather { get; set; }

        /// <value> Obiekt przechowujący szczegółowe informacje o pogodzie</value>
        public WeatherInfo Main { get; set; }

        /// <value> Nazwa miasta </value>
        public string Name { get; set; }

        /// <summary>
        /// Klasa zawierająca informacje przydatne przy wizualizacji stanu pogodowego
        /// </summary>
        public class GeneralInfo
        {
            /// <value> Identyfikator obrazka odzwierciedlającego stan pogodowy </value>
            public string Icon{ get; set; }

        }

        /// <summary>
        /// Klasa zawierająca szczegółowe informaje o pogodzie
        /// </summary>
        public class WeatherInfo
        {
            /// <value>Temperatura powietrza w stopniach Celsjusza</value>
            public double Temp { get; set; }

            /// <value>Ciśnienie atmosferyczne w hPa</value>
            public int Pressure { get; set; }

            /// <value>Wilgotność powietrza w %</value>
            public int Humidity { get; set; }

            /// <value>Minimalna temperatura w stopniach Celsjusza</value>
            public double Temp_min { get; set; }

            /// <value>Maksymalna temperatura w stopniach Celsjusza</value>
            public double Temp_max { get; set; }
        }
    }
}
