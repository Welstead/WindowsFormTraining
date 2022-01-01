using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper;

namespace Hurricanes
{
    public class CityModel
    {
            public int LatD { get; set; }
            public int LatM { get; set; }
            public int LatS { get; set; }
            public string NS { get; set; }
            public int LonD { get; set; }
            public int LonM { get; set; }
            public int LonS { get; set; }
            public string EW { get; set; }
            public string CityName { get; set; }
            public string State { get; set; }
        

    }
}
