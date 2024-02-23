using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weatherApp
{
    public class WeatherData
    {
        public MainData Main { get; set; }
        public List<WeatherDescription> Weather { get; set; }
        // Add other fields as needed based on the API response

        public class MainData
        {
            public double Temp { get; set; }
            // Add other temperature-related fields
        }

        public class WeatherDescription
        {
            public string Main { get; set; }
            public string Description { get; set; }
            // Add other description-related fields
        }
    }

}
