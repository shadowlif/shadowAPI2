﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shadowAPI2
{
    internal class ZoneManager
    {
        private static ZoneManager instance;

        private List<string> cityName;
        private List<float[]> cityPosition;

        private List<string> zoneName;
        private List<float[]> zonePosition;

        private ZoneManager()
        {
            cityName = new List<string>();
            cityPosition = new List<float[]>();

            zoneName = new List<string>();
            zonePosition = new List<float[]>();

            AddCity("Las Venturas", 685.0f, 476.093f, -500.0f, 3000.0f, 3000.0f, 500.0f);
            AddCity("San Fierro", -3000.0f, -742.306f, -500.0f, -1270.53f, 1530.24f, 500.0f);
            AddCity("San Fierro", -1270.53f, -402.481f, -500.0f, -1038.45f, 832.495f, 500.0f);
            AddCity("San Fierro", -1038.45f, -145.539f, -500.0f, -897.546f, 376.632f, 500.0f);
            AddCity("Los Santos", 480.0f, -3000.0f, -500.0f, 3000.0f, -850.0f, 500.0f);
            AddCity("Los Santos", 80.0f, -2101.61f, -500.0f, 1075.0f, -1239.61f, 500.0f);
            AddCity("Tierra Robada", -1213.91f, 596.349f, -242.99f, -480.539f, 1659.68f, 900.0f);
            AddCity("Red County", -1213.91f, -768.027f, -242.99f, 2997.06f, 596.349f, 900.0f);
            AddCity("Flint County", -1213.91f, -2892.97f, -242.99f, 44.6147f, -768.027f, 900.0f);
            AddCity("Whetstone", -2997.47f, -2892.97f, -242.99f, -1213.91f, -1115.58f, 900.0f);

            AddZone("Avispa Country Club", -2667.810f, -302.135f, -28.831f, -2646.400f, -262.320f, 71.169f);
            AddZone("Easter Bay Airport", -1315.420f, -405.388f, 15.406f, -1264.400f, -209.543f, 25.406f);
            AddZone("Avispa Country Club", -2550.040f, -355.493f, 0.000f, -2470.040f, -318.493f, 39.700f);
            AddZone("Easter Bay Airport", -1490.330f, -209.543f, 15.406f, -1264.400f, -148.388f, 25.406f);
            AddZone("Garcia", -2395.140f, -222.589f, -5.3f, -2354.090f, -204.792f, 200.000f);
            AddZone("Shady Cabin", -1632.830f, -2263.440f, -3.0f, -1601.330f, -2231.790f, 200.000f);
            AddZone("East Los Santos", 2381.680f, -1494.030f, -89.084f, 2421.030f, -1454.350f, 110.916f);
            AddZone("LVA Freight Depot", 1236.630f, 1163.410f, -89.084f, 1277.050f, 1203.280f, 110.916f);
            AddZone("Blackfield Intersection", 1277.050f, 1044.690f, -89.084f, 1315.350f, 1087.630f, 110.916f);
            AddZone("Avispa Country Club", -2470.040f, -355.493f, 0.000f, -2270.040f, -318.493f, 46.100f);
            AddZone("Temple", 1252.330f, -926.999f, -89.084f, 1357.000f, -910.170f, 110.916f);
            AddZone("Unity Station", 1692.620f, -1971.800f, -20.492f, 1812.620f, -1932.800f, 79.508f);
            AddZone("LVA Freight Depot", 1315.350f, 1044.690f, -89.084f, 1375.600f, 1087.630f, 110.916f);
            AddZone("Los Flores", 2581.730f, -1454.350f, -89.084f, 2632.830f, -1393.420f, 110.916f);
            AddZone("Starfish Casino", 2437.390f, 1858.100f, -39.084f, 2495.090f, 1970.850f, 60.916f);
            AddZone("Easter Bay Chemicals", -1132.820f, -787.391f, 0.000f, -956.476f, -768.027f, 200.000f);
            AddZone("Downtown Los Santos", 1370.850f, -1170.870f, -89.084f, 1463.900f, -1130.850f, 110.916f);
            AddZone("Esplanade East", -1620.300f, 1176.520f, -4.5f, -1580.010f, 1274.260f, 200.000f);
            AddZone("Market Station", 787.461f, -1410.930f, -34.126f, 866.009f, -1310.210f, 65.874f);
            AddZone("Linden Station", 2811.250f, 1229.590f, -39.594f, 2861.250f, 1407.590f, 60.406f);
            AddZone("Montgomery Intersection", 1582.440f, 347.457f, 0.000f, 1664.620f, 401.750f, 200.000f);
            AddZone("Frederick Bridge", 2759.250f, 296.501f, 0.000f, 2774.250f, 594.757f, 200.000f);
            AddZone("Yellow Bell Station", 1377.480f, 2600.430f, -21.926f, 1492.450f, 2687.360f, 78.074f);
            AddZone("Downtown Los Santos", 1507.510f, -1385.210f, 110.916f, 1582.550f, -1325.310f, 335.916f);
            AddZone("Jefferson", 2185.330f, -1210.740f, -89.084f, 2281.450f, -1154.590f, 110.916f);
            AddZone("Mulholland", 1318.130f, -910.170f, -89.084f, 1357.000f, -768.027f, 110.916f);
            AddZone("Avispa Country Club", -2361.510f, -417.199f, 0.000f, -2270.040f, -355.493f, 200.000f);
            AddZone("Jefferson", 1996.910f, -1449.670f, -89.084f, 2056.860f, -1350.720f, 110.916f);
            AddZone("Julius Thruway West", 1236.630f, 2142.860f, -89.084f, 1297.470f, 2243.230f, 110.916f);
            AddZone("Jefferson", 2124.660f, -1494.030f, -89.084f, 2266.210f, -1449.670f, 110.916f);
            AddZone("Julius Thruway North", 1848.400f, 2478.490f, -89.084f, 1938.800f, 2553.490f, 110.916f);
            AddZone("Rodeo", 422.680f, -1570.200f, -89.084f, 466.223f, -1406.050f, 110.916f);
            AddZone("Cranberry Station", -2007.830f, 56.306f, 0.000f, -1922.000f, 224.782f, 100.000f);
            AddZone("Downtown Los Santos", 1391.050f, -1026.330f, -89.084f, 1463.900f, -926.999f, 110.916f);
            AddZone("Redsands West", 1704.590f, 2243.230f, -89.084f, 1777.390f, 2342.830f, 110.916f);
            AddZone("Little Mexico", 1758.900f, -1722.260f, -89.084f, 1812.620f, -1577.590f, 110.916f);
            AddZone("Blackfield Intersection", 1375.600f, 823.228f, -89.084f, 1457.390f, 919.447f, 110.916f);
            AddZone("Los Santos International", 1974.630f, -2394.330f, -39.084f, 2089.000f, -2256.590f, 60.916f);
            AddZone("Beacon Hill", -399.633f, -1075.520f, -1.489f, -319.033f, -977.516f, 198.511f);
            AddZone("Rodeo", 334.503f, -1501.950f, -89.084f, 422.680f, -1406.050f, 110.916f);
            AddZone("Richman", 225.165f, -1369.620f, -89.084f, 334.503f, -1292.070f, 110.916f);
            AddZone("Downtown Los Santos", 1724.760f, -1250.900f, -89.084f, 1812.620f, -1150.870f, 110.916f);
            AddZone("The Strip", 2027.400f, 1703.230f, -89.084f, 2137.400f, 1783.230f, 110.916f);
            AddZone("Downtown Los Santos", 1378.330f, -1130.850f, -89.084f, 1463.900f, -1026.330f, 110.916f);
            AddZone("Blackfield Intersection", 1197.390f, 1044.690f, -89.084f, 1277.050f, 1163.390f, 110.916f);
            AddZone("Conference Center", 1073.220f, -1842.270f, -89.084f, 1323.900f, -1804.210f, 110.916f);
            AddZone("Montgomery", 1451.400f, 347.457f, -6.1f, 1582.440f, 420.802f, 200.000f);
            AddZone("Foster Valley", -2270.040f, -430.276f, -1.2f, -2178.690f, -324.114f, 200.000f);
            AddZone("Blackfield Chapel", 1325.600f, 596.349f, -89.084f, 1375.600f, 795.010f, 110.916f);
            AddZone("Los Santos International", 2051.630f, -2597.260f, -39.084f, 2152.450f, -2394.330f, 60.916f);
            AddZone("Mulholland", 1096.470f, -910.170f, -89.084f, 1169.130f, -768.027f, 110.916f);
            AddZone("Yellow Bell Gol Course", 1457.460f, 2723.230f, -89.084f, 1534.560f, 2863.230f, 110.916f);
            AddZone("The Strip", 2027.400f, 1783.230f, -89.084f, 2162.390f, 1863.230f, 110.916f);
            AddZone("Jefferson", 2056.860f, -1210.740f, -89.084f, 2185.330f, -1126.320f, 110.916f);
            AddZone("Mulholland", 952.604f, -937.184f, -89.084f, 1096.470f, -860.619f, 110.916f);
            AddZone("Aldea Malvada", -1372.140f, 2498.520f, 0.000f, -1277.590f, 2615.350f, 200.000f);
            AddZone("Las Colinas", 2126.860f, -1126.320f, -89.084f, 2185.330f, -934.489f, 110.916f);
            AddZone("Las Colinas", 1994.330f, -1100.820f, -89.084f, 2056.860f, -920.815f, 110.916f);
            AddZone("Richman", 647.557f, -954.662f, -89.084f, 768.694f, -860.619f, 110.916f);
            AddZone("LVA Freight Depot", 1277.050f, 1087.630f, -89.084f, 1375.600f, 1203.280f, 110.916f);
            AddZone("Julius Thruway North", 1377.390f, 2433.230f, -89.084f, 1534.560f, 2507.230f, 110.916f);
            AddZone("Willowfield", 2201.820f, -2095.000f, -89.084f, 2324.000f, -1989.900f, 110.916f);
            AddZone("Julius Thruway North", 1704.590f, 2342.830f, -89.084f, 1848.400f, 2433.230f, 110.916f);
            AddZone("Temple", 1252.330f, -1130.850f, -89.084f, 1378.330f, -1026.330f, 110.916f);
            AddZone("Little Mexico", 1701.900f, -1842.270f, -89.084f, 1812.620f, -1722.260f, 110.916f);
            AddZone("Queens", -2411.220f, 373.539f, 0.000f, -2253.540f, 458.411f, 200.000f);
            AddZone("Las Venturas Airport", 1515.810f, 1586.400f, -12.500f, 1729.950f, 1714.560f, 87.500f);
            AddZone("Richman", 225.165f, -1292.070f, -89.084f, 466.223f, -1235.070f, 110.916f);
            AddZone("Temple", 1252.330f, -1026.330f, -89.084f, 1391.050f, -926.999f, 110.916f);
            AddZone("East Los Santos", 2266.260f, -1494.030f, -89.084f, 2381.680f, -1372.040f, 110.916f);
            AddZone("Julius Thruway East", 2623.180f, 943.235f, -89.084f, 2749.900f, 1055.960f, 110.916f);
            AddZone("Willowfield", 2541.700f, -1941.400f, -89.084f, 2703.580f, -1852.870f, 110.916f);
            AddZone("Las Colinas", 2056.860f, -1126.320f, -89.084f, 2126.860f, -920.815f, 110.916f);
            AddZone("Julius Thruway East", 2625.160f, 2202.760f, -89.084f, 2685.160f, 2442.550f, 110.916f);
            AddZone("Rodeo", 225.165f, -1501.950f, -89.084f, 334.503f, -1369.620f, 110.916f);
            AddZone("Las Brujas", -365.167f, 2123.010f, -3.0f, -208.570f, 2217.680f, 200.000f);
            AddZone("Julius Thruway East", 2536.430f, 2442.550f, -89.084f, 2685.160f, 2542.550f, 110.916f);
            AddZone("Rodeo", 334.503f, -1406.050f, -89.084f, 466.223f, -1292.070f, 110.916f);
            AddZone("Vinewood", 647.557f, -1227.280f, -89.084f, 787.461f, -1118.280f, 110.916f);
            AddZone("Rodeo", 422.680f, -1684.650f, -89.084f, 558.099f, -1570.200f, 110.916f);
            AddZone("Julius Thruway North", 2498.210f, 2542.550f, -89.084f, 2685.160f, 2626.550f, 110.916f);
            AddZone("Downtown Los Santos", 1724.760f, -1430.870f, -89.084f, 1812.620f, -1250.900f, 110.916f);
            AddZone("Rodeo", 225.165f, -1684.650f, -89.084f, 312.803f, -1501.950f, 110.916f);
            AddZone("Jefferson", 2056.860f, -1449.670f, -89.084f, 2266.210f, -1372.040f, 110.916f);
            AddZone("Hampton Barns", 603.035f, 264.312f, 0.000f, 761.994f, 366.572f, 200.000f);
            AddZone("Temple", 1096.470f, -1130.840f, -89.084f, 1252.330f, -1026.330f, 110.916f);
            AddZone("Kincaid Bridge", -1087.930f, 855.370f, -89.084f, -961.950f, 986.281f, 110.916f);
            AddZone("Verona Beach", 1046.150f, -1722.260f, -89.084f, 1161.520f, -1577.590f, 110.916f);
            AddZone("Commerce", 1323.900f, -1722.260f, -89.084f, 1440.900f, -1577.590f, 110.916f);
            AddZone("Mulholland", 1357.000f, -926.999f, -89.084f, 1463.900f, -768.027f, 110.916f);
            AddZone("Rodeo", 466.223f, -1570.200f, -89.084f, 558.099f, -1385.070f, 110.916f);
            AddZone("Mulholland", 911.802f, -860.619f, -89.084f, 1096.470f, -768.027f, 110.916f);
            AddZone("Mulholland", 768.694f, -954.662f, -89.084f, 952.604f, -860.619f, 110.916f);
            AddZone("Julius Thruway South", 2377.390f, 788.894f, -89.084f, 2537.390f, 897.901f, 110.916f);
            AddZone("Idlewood", 1812.620f, -1852.870f, -89.084f, 1971.660f, -1742.310f, 110.916f);
            AddZone("Ocean Docks", 2089.000f, -2394.330f, -89.084f, 2201.820f, -2235.840f, 110.916f);
            AddZone("Commerce", 1370.850f, -1577.590f, -89.084f, 1463.900f, -1384.950f, 110.916f);
            AddZone("Julius Thruway North", 2121.400f, 2508.230f, -89.084f, 2237.400f, 2663.170f, 110.916f);
            AddZone("Temple", 1096.470f, -1026.330f, -89.084f, 1252.330f, -910.170f, 110.916f);
            AddZone("Glen Park", 1812.620f, -1449.670f, -89.084f, 1996.910f, -1350.720f, 110.916f);
            AddZone("Easter Bay Airport", -1242.980f, -50.096f, 0.000f, -1213.910f, 578.396f, 200.000f);
            AddZone("Martin Bridge", -222.179f, 293.324f, 0.000f, -122.126f, 476.465f, 200.000f);
            AddZone("The Strip", 2106.700f, 1863.230f, -89.084f, 2162.390f, 2202.760f, 110.916f);
            AddZone("Willowfield", 2541.700f, -2059.230f, -89.084f, 2703.580f, -1941.400f, 110.916f);
            AddZone("Marina", 807.922f, -1577.590f, -89.084f, 926.922f, -1416.250f, 110.916f);
            AddZone("Las Venturas Airport", 1457.370f, 1143.210f, -89.084f, 1777.400f, 1203.280f, 110.916f);
            AddZone("Idlewood", 1812.620f, -1742.310f, -89.084f, 1951.660f, -1602.310f, 110.916f);
            AddZone("Esplanade East", -1580.010f, 1025.980f, -6.1f, -1499.890f, 1274.260f, 200.000f);
            AddZone("Downtown Los Santos", 1370.850f, -1384.950f, -89.084f, 1463.900f, -1170.870f, 110.916f);
            AddZone("The Mako Span", 1664.620f, 401.750f, 0.000f, 1785.140f, 567.203f, 200.000f);
            AddZone("Rodeo", 312.803f, -1684.650f, -89.084f, 422.680f, -1501.950f, 110.916f);
            AddZone("Pershing Square", 1440.900f, -1722.260f, -89.084f, 1583.500f, -1577.590f, 110.916f);
            AddZone("Mulholland", 687.802f, -860.619f, -89.084f, 911.802f, -768.027f, 110.916f);
            AddZone("Gant Bridge", -2741.070f, 1490.470f, -6.1f, -2616.400f, 1659.680f, 200.000f);
            AddZone("Las Colinas", 2185.330f, -1154.590f, -89.084f, 2281.450f, -934.489f, 110.916f);
            AddZone("Mulholland", 1169.130f, -910.170f, -89.084f, 1318.130f, -768.027f, 110.916f);
            AddZone("Julius Thruway North", 1938.800f, 2508.230f, -89.084f, 2121.400f, 2624.230f, 110.916f);
            AddZone("Commerce", 1667.960f, -1577.590f, -89.084f, 1812.620f, -1430.870f, 110.916f);
            AddZone("Rodeo", 72.648f, -1544.170f, -89.084f, 225.165f, -1404.970f, 110.916f);
            AddZone("Roca Escalante", 2536.430f, 2202.760f, -89.084f, 2625.160f, 2442.550f, 110.916f);
            AddZone("Rodeo", 72.648f, -1684.650f, -89.084f, 225.165f, -1544.170f, 110.916f);
            AddZone("Market", 952.663f, -1310.210f, -89.084f, 1072.660f, -1130.850f, 110.916f);
            AddZone("Las Colinas", 2632.740f, -1135.040f, -89.084f, 2747.740f, -945.035f, 110.916f);
            AddZone("Mulholland", 861.085f, -674.885f, -89.084f, 1156.550f, -600.896f, 110.916f);
            AddZone("King's", -2253.540f, 373.539f, -9.1f, -1993.280f, 458.411f, 200.000f);
            AddZone("Redsands East", 1848.400f, 2342.830f, -89.084f, 2011.940f, 2478.490f, 110.916f);
            AddZone("Downtown", -1580.010f, 744.267f, -6.1f, -1499.890f, 1025.980f, 200.000f);
            AddZone("Conference Center", 1046.150f, -1804.210f, -89.084f, 1323.900f, -1722.260f, 110.916f);
            AddZone("Richman", 647.557f, -1118.280f, -89.084f, 787.461f, -954.662f, 110.916f);
            AddZone("Ocean Flats", -2994.490f, 277.411f, -9.1f, -2867.850f, 458.411f, 200.000f);
            AddZone("Greenglass College", 964.391f, 930.890f, -89.084f, 1166.530f, 1044.690f, 110.916f);
            AddZone("Glen Park", 1812.620f, -1100.820f, -89.084f, 1994.330f, -973.380f, 110.916f);
            AddZone("LVA Freight Depot", 1375.600f, 919.447f, -89.084f, 1457.370f, 1203.280f, 110.916f);
            AddZone("Regular Tom", -405.770f, 1712.860f, -3.0f, -276.719f, 1892.750f, 200.000f);
            AddZone("Verona Beach", 1161.520f, -1722.260f, -89.084f, 1323.900f, -1577.590f, 110.916f);
            AddZone("East Los Santos", 2281.450f, -1372.040f, -89.084f, 2381.680f, -1135.040f, 110.916f);
            AddZone("Caligula's Palace", 2137.400f, 1703.230f, -89.084f, 2437.390f, 1783.230f, 110.916f);
            AddZone("Idlewood", 1951.660f, -1742.310f, -89.084f, 2124.660f, -1602.310f, 110.916f);
            AddZone("Pilgrim", 2624.400f, 1383.230f, -89.084f, 2685.160f, 1783.230f, 110.916f);
            AddZone("Idlewood", 2124.660f, -1742.310f, -89.084f, 2222.560f, -1494.030f, 110.916f);
            AddZone("Queens", -2533.040f, 458.411f, 0.000f, -2329.310f, 578.396f, 200.000f);
            AddZone("Downtown", -1871.720f, 1176.420f, -4.5f, -1620.300f, 1274.260f, 200.000f);
            AddZone("Commerce", 1583.500f, -1722.260f, -89.084f, 1758.900f, -1577.590f, 110.916f);
            AddZone("East Los Santos", 2381.680f, -1454.350f, -89.084f, 2462.130f, -1135.040f, 110.916f);
            AddZone("Marina", 647.712f, -1577.590f, -89.084f, 807.922f, -1416.250f, 110.916f);
            AddZone("Richman", 72.648f, -1404.970f, -89.084f, 225.165f, -1235.070f, 110.916f);
            AddZone("Vinewood", 647.712f, -1416.250f, -89.084f, 787.461f, -1227.280f, 110.916f);
            AddZone("East Los Santos", 2222.560f, -1628.530f, -89.084f, 2421.030f, -1494.030f, 110.916f);
            AddZone("Rodeo", 558.099f, -1684.650f, -89.084f, 647.522f, -1384.930f, 110.916f);
            AddZone("Easter Tunnel", -1709.710f, -833.034f, -1.5f, -1446.010f, -730.118f, 200.000f);
            AddZone("Rodeo", 466.223f, -1385.070f, -89.084f, 647.522f, -1235.070f, 110.916f);
            AddZone("Redsands East", 1817.390f, 2202.760f, -89.084f, 2011.940f, 2342.830f, 110.916f);
            AddZone("The Clown's Pocket", 2162.390f, 1783.230f, -89.084f, 2437.390f, 1883.230f, 110.916f);
            AddZone("Idlewood", 1971.660f, -1852.870f, -89.084f, 2222.560f, -1742.310f, 110.916f);
            AddZone("Montgomery Intersection", 1546.650f, 208.164f, 0.000f, 1745.830f, 347.457f, 200.000f);
            AddZone("Willowfield", 2089.000f, -2235.840f, -89.084f, 2201.820f, -1989.900f, 110.916f);
            AddZone("Temple", 952.663f, -1130.840f, -89.084f, 1096.470f, -937.184f, 110.916f);
            AddZone("Prickle Pine", 1848.400f, 2553.490f, -89.084f, 1938.800f, 2863.230f, 110.916f);
            AddZone("Los Santos International", 1400.970f, -2669.260f, -39.084f, 2189.820f, -2597.260f, 60.916f);
            AddZone("Garver Bridge", -1213.910f, 950.022f, -89.084f, -1087.930f, 1178.930f, 110.916f);
            AddZone("Garver Bridge", -1339.890f, 828.129f, -89.084f, -1213.910f, 1057.040f, 110.916f);
            AddZone("Kincaid Bridge", -1339.890f, 599.218f, -89.084f, -1213.910f, 828.129f, 110.916f);
            AddZone("Kincaid Bridge", -1213.910f, 721.111f, -89.084f, -1087.930f, 950.022f, 110.916f);
            AddZone("Verona Beach", 930.221f, -2006.780f, -89.084f, 1073.220f, -1804.210f, 110.916f);
            AddZone("Verdant Bluffs", 1073.220f, -2006.780f, -89.084f, 1249.620f, -1842.270f, 110.916f);
            AddZone("Vinewood", 787.461f, -1130.840f, -89.084f, 952.604f, -954.662f, 110.916f);
            AddZone("Vinewood", 787.461f, -1310.210f, -89.084f, 952.663f, -1130.840f, 110.916f);
            AddZone("Commerce", 1463.900f, -1577.590f, -89.084f, 1667.960f, -1430.870f, 110.916f);
            AddZone("Market", 787.461f, -1416.250f, -89.084f, 1072.660f, -1310.210f, 110.916f);
            AddZone("Rockshore West", 2377.390f, 596.349f, -89.084f, 2537.390f, 788.894f, 110.916f);
            AddZone("Julius Thruway North", 2237.400f, 2542.550f, -89.084f, 2498.210f, 2663.170f, 110.916f);
            AddZone("East Beach", 2632.830f, -1668.130f, -89.084f, 2747.740f, -1393.420f, 110.916f);
            AddZone("Fallow Bridge", 434.341f, 366.572f, 0.000f, 603.035f, 555.680f, 200.000f);
            AddZone("Willowfield", 2089.000f, -1989.900f, -89.084f, 2324.000f, -1852.870f, 110.916f);
            AddZone("Chinatown", -2274.170f, 578.396f, -7.6f, -2078.670f, 744.170f, 200.000f);
            AddZone("El Castillo del Diablo", -208.570f, 2337.180f, 0.000f, 8.430f, 2487.180f, 200.000f);
            AddZone("Ocean Docks", 2324.000f, -2145.100f, -89.084f, 2703.580f, -2059.230f, 110.916f);
            AddZone("Easter Bay Chemicals", -1132.820f, -768.027f, 0.000f, -956.476f, -578.118f, 200.000f);
            AddZone("The Visage", 1817.390f, 1703.230f, -89.084f, 2027.400f, 1863.230f, 110.916f);
            AddZone("Ocean Flats", -2994.490f, -430.276f, -1.2f, -2831.890f, -222.589f, 200.000f);
            AddZone("Richman", 321.356f, -860.619f, -89.084f, 687.802f, -768.027f, 110.916f);
            AddZone("Green Palms", 176.581f, 1305.450f, -3.0f, 338.658f, 1520.720f, 200.000f);
            AddZone("Richman", 321.356f, -768.027f, -89.084f, 700.794f, -674.885f, 110.916f);
            AddZone("Starfish Casino", 2162.390f, 1883.230f, -89.084f, 2437.390f, 2012.180f, 110.916f);
            AddZone("East Beach", 2747.740f, -1668.130f, -89.084f, 2959.350f, -1498.620f, 110.916f);
            AddZone("Jefferson", 2056.860f, -1372.040f, -89.084f, 2281.450f, -1210.740f, 110.916f);
            AddZone("Downtown Los Santos", 1463.900f, -1290.870f, -89.084f, 1724.760f, -1150.870f, 110.916f);
            AddZone("Downtown Los Santos", 1463.900f, -1430.870f, -89.084f, 1724.760f, -1290.870f, 110.916f);
            AddZone("Garver Bridge", -1499.890f, 696.442f, -179.615f, -1339.890f, 925.353f, 20.385f);
            AddZone("Julius Thruway South", 1457.390f, 823.228f, -89.084f, 2377.390f, 863.229f, 110.916f);
            AddZone("East Los Santos", 2421.030f, -1628.530f, -89.084f, 2632.830f, -1454.350f, 110.916f);
            AddZone("Greenglass College", 964.391f, 1044.690f, -89.084f, 1197.390f, 1203.220f, 110.916f);
            AddZone("Las Colinas", 2747.740f, -1120.040f, -89.084f, 2959.350f, -945.035f, 110.916f);
            AddZone("Mulholland", 737.573f, -768.027f, -89.084f, 1142.290f, -674.885f, 110.916f);
            AddZone("Ocean Docks", 2201.820f, -2730.880f, -89.084f, 2324.000f, -2418.330f, 110.916f);
            AddZone("East Los Santos", 2462.130f, -1454.350f, -89.084f, 2581.730f, -1135.040f, 110.916f);
            AddZone("Ganton", 2222.560f, -1722.330f, -89.084f, 2632.830f, -1628.530f, 110.916f);
            AddZone("Avispa Country Club", -2831.890f, -430.276f, -6.1f, -2646.400f, -222.589f, 200.000f);
            AddZone("Willowfield", 1970.620f, -2179.250f, -89.084f, 2089.000f, -1852.870f, 110.916f);
            AddZone("Esplanade North", -1982.320f, 1274.260f, -4.5f, -1524.240f, 1358.900f, 200.000f);
            AddZone("The High Roller", 1817.390f, 1283.230f, -89.084f, 2027.390f, 1469.230f, 110.916f);
            AddZone("Ocean Docks", 2201.820f, -2418.330f, -89.084f, 2324.000f, -2095.000f, 110.916f);
            AddZone("Last Dime Motel", 1823.080f, 596.349f, -89.084f, 1997.220f, 823.228f, 110.916f);
            AddZone("Bayside Marina", -2353.170f, 2275.790f, 0.000f, -2153.170f, 2475.790f, 200.000f);
            AddZone("King's", -2329.310f, 458.411f, -7.6f, -1993.280f, 578.396f, 200.000f);
            AddZone("El Corona", 1692.620f, -2179.250f, -89.084f, 1812.620f, -1842.270f, 110.916f);
            AddZone("Blackfield Chapel", 1375.600f, 596.349f, -89.084f, 1558.090f, 823.228f, 110.916f);
            AddZone("The Pink Swan", 1817.390f, 1083.230f, -89.084f, 2027.390f, 1283.230f, 110.916f);
            AddZone("Julius Thruway West", 1197.390f, 1163.390f, -89.084f, 1236.630f, 2243.230f, 110.916f);
            AddZone("Los Flores", 2581.730f, -1393.420f, -89.084f, 2747.740f, -1135.040f, 110.916f);
            AddZone("The Visage", 1817.390f, 1863.230f, -89.084f, 2106.700f, 2011.830f, 110.916f);
            AddZone("Prickle Pine", 1938.800f, 2624.230f, -89.084f, 2121.400f, 2861.550f, 110.916f);
            AddZone("Verona Beach", 851.449f, -1804.210f, -89.084f, 1046.150f, -1577.590f, 110.916f);
            AddZone("Robada Intersection", -1119.010f, 1178.930f, -89.084f, -862.025f, 1351.450f, 110.916f);
            AddZone("Linden Side", 2749.900f, 943.235f, -89.084f, 2923.390f, 1198.990f, 110.916f);
            AddZone("Ocean Docks", 2703.580f, -2302.330f, -89.084f, 2959.350f, -2126.900f, 110.916f);
            AddZone("Willowfield", 2324.000f, -2059.230f, -89.084f, 2541.700f, -1852.870f, 110.916f);
            AddZone("King's", -2411.220f, 265.243f, -9.1f, -1993.280f, 373.539f, 200.000f);
            AddZone("Commerce", 1323.900f, -1842.270f, -89.084f, 1701.900f, -1722.260f, 110.916f);
            AddZone("Mulholland", 1269.130f, -768.027f, -89.084f, 1414.070f, -452.425f, 110.916f);
            AddZone("Marina", 647.712f, -1804.210f, -89.084f, 851.449f, -1577.590f, 110.916f);
            AddZone("Battery Point", -2741.070f, 1268.410f, -4.5f, -2533.040f, 1490.470f, 200.000f);
            AddZone("The Four Dragons Casino", 1817.390f, 863.232f, -89.084f, 2027.390f, 1083.230f, 110.916f);
            AddZone("Blackfield", 964.391f, 1203.220f, -89.084f, 1197.390f, 1403.220f, 110.916f);
            AddZone("Julius Thruway North", 1534.560f, 2433.230f, -89.084f, 1848.400f, 2583.230f, 110.916f);
            AddZone("Yellow Bell Gol Course", 1117.400f, 2723.230f, -89.084f, 1457.460f, 2863.230f, 110.916f);
            AddZone("Idlewood", 1812.620f, -1602.310f, -89.084f, 2124.660f, -1449.670f, 110.916f);
            AddZone("Redsands West", 1297.470f, 2142.860f, -89.084f, 1777.390f, 2243.230f, 110.916f);
            AddZone("Doherty", -2270.040f, -324.114f, -1.2f, -1794.920f, -222.589f, 200.000f);
            AddZone("Hilltop Farm", 967.383f, -450.390f, -3.0f, 1176.780f, -217.900f, 200.000f);
            AddZone("Las Barrancas", -926.130f, 1398.730f, -3.0f, -719.234f, 1634.690f, 200.000f);
            AddZone("Pirates in Men's Pants", 1817.390f, 1469.230f, -89.084f, 2027.400f, 1703.230f, 110.916f);
            AddZone("City Hall", -2867.850f, 277.411f, -9.1f, -2593.440f, 458.411f, 200.000f);
            AddZone("Avispa Country Club", -2646.400f, -355.493f, 0.000f, -2270.040f, -222.589f, 200.000f);
            AddZone("The Strip", 2027.400f, 863.229f, -89.084f, 2087.390f, 1703.230f, 110.916f);
            AddZone("Hashbury", -2593.440f, -222.589f, -1.0f, -2411.220f, 54.722f, 200.000f);
            AddZone("Los Santos International", 1852.000f, -2394.330f, -89.084f, 2089.000f, -2179.250f, 110.916f);
            AddZone("Whitewood Estates", 1098.310f, 1726.220f, -89.084f, 1197.390f, 2243.230f, 110.916f);
            AddZone("Sherman Reservoir", -789.737f, 1659.680f, -89.084f, -599.505f, 1929.410f, 110.916f);
            AddZone("El Corona", 1812.620f, -2179.250f, -89.084f, 1970.620f, -1852.870f, 110.916f);
            AddZone("Downtown", -1700.010f, 744.267f, -6.1f, -1580.010f, 1176.520f, 200.000f);
            AddZone("Foster Valley", -2178.690f, -1250.970f, 0.000f, -1794.920f, -1115.580f, 200.000f);
            AddZone("Las Payasadas", -354.332f, 2580.360f, 2.0f, -133.625f, 2816.820f, 200.000f);
            AddZone("Valle Ocultado", -936.668f, 2611.440f, 2.0f, -715.961f, 2847.900f, 200.000f);
            AddZone("Blackfield Intersection", 1166.530f, 795.010f, -89.084f, 1375.600f, 1044.690f, 110.916f);
            AddZone("Ganton", 2222.560f, -1852.870f, -89.084f, 2632.830f, -1722.330f, 110.916f);
            AddZone("Easter Bay Airport", -1213.910f, -730.118f, 0.000f, -1132.820f, -50.096f, 200.000f);
            AddZone("Redsands East", 1817.390f, 2011.830f, -89.084f, 2106.700f, 2202.760f, 110.916f);
            AddZone("Esplanade East", -1499.890f, 578.396f, -79.615f, -1339.890f, 1274.260f, 20.385f);
            AddZone("Caligula's Palace", 2087.390f, 1543.230f, -89.084f, 2437.390f, 1703.230f, 110.916f);
            AddZone("Royal Casino", 2087.390f, 1383.230f, -89.084f, 2437.390f, 1543.230f, 110.916f);
            AddZone("Richman", 72.648f, -1235.070f, -89.084f, 321.356f, -1008.150f, 110.916f);
            AddZone("Starfish Casino", 2437.390f, 1783.230f, -89.084f, 2685.160f, 2012.180f, 110.916f);
            AddZone("Mulholland", 1281.130f, -452.425f, -89.084f, 1641.130f, -290.913f, 110.916f);
            AddZone("Downtown", -1982.320f, 744.170f, -6.1f, -1871.720f, 1274.260f, 200.000f);
            AddZone("Hankypanky Point", 2576.920f, 62.158f, 0.000f, 2759.250f, 385.503f, 200.000f);
            AddZone("K.A.C.C. Military Fuels", 2498.210f, 2626.550f, -89.084f, 2749.900f, 2861.550f, 110.916f);
            AddZone("Harry Gold Parkway", 1777.390f, 863.232f, -89.084f, 1817.390f, 2342.830f, 110.916f);
            AddZone("Bayside Tunnel", -2290.190f, 2548.290f, -89.084f, -1950.190f, 2723.290f, 110.916f);
            AddZone("Ocean Docks", 2324.000f, -2302.330f, -89.084f, 2703.580f, -2145.100f, 110.916f);
            AddZone("Richman", 321.356f, -1044.070f, -89.084f, 647.557f, -860.619f, 110.916f);
            AddZone("Randolph Industrial Estate", 1558.090f, 596.349f, -89.084f, 1823.080f, 823.235f, 110.916f);
            AddZone("East Beach", 2632.830f, -1852.870f, -89.084f, 2959.350f, -1668.130f, 110.916f);
            AddZone("Flint Water", -314.426f, -753.874f, -89.084f, -106.339f, -463.073f, 110.916f);
            AddZone("Blueberry", 19.607f, -404.136f, 3.8f, 349.607f, -220.137f, 200.000f);
            AddZone("Linden Station", 2749.900f, 1198.990f, -89.084f, 2923.390f, 1548.990f, 110.916f);
            AddZone("Glen Park", 1812.620f, -1350.720f, -89.084f, 2056.860f, -1100.820f, 110.916f);
            AddZone("Downtown", -1993.280f, 265.243f, -9.1f, -1794.920f, 578.396f, 200.000f);
            AddZone("Redsands West", 1377.390f, 2243.230f, -89.084f, 1704.590f, 2433.230f, 110.916f);
            AddZone("Richman", 321.356f, -1235.070f, -89.084f, 647.522f, -1044.070f, 110.916f);
            AddZone("Gant Bridge", -2741.450f, 1659.680f, -6.1f, -2616.400f, 2175.150f, 200.000f);
            AddZone("Lil' Probe Inn", -90.218f, 1286.850f, -3.0f, 153.859f, 1554.120f, 200.000f);
            AddZone("Flint Intersection", -187.700f, -1596.760f, -89.084f, 17.063f, -1276.600f, 110.916f);
            AddZone("Las Colinas", 2281.450f, -1135.040f, -89.084f, 2632.740f, -945.035f, 110.916f);
            AddZone("Sobell Rail Yards", 2749.900f, 1548.990f, -89.084f, 2923.390f, 1937.250f, 110.916f);
            AddZone("The Emerald Isle", 2011.940f, 2202.760f, -89.084f, 2237.400f, 2508.230f, 110.916f);
            AddZone("El Castillo del Diablo", -208.570f, 2123.010f, -7.6f, 114.033f, 2337.180f, 200.000f);
            AddZone("Santa Flora", -2741.070f, 458.411f, -7.6f, -2533.040f, 793.411f, 200.000f);
            AddZone("Playa del Seville", 2703.580f, -2126.900f, -89.084f, 2959.350f, -1852.870f, 110.916f);
            AddZone("Market", 926.922f, -1577.590f, -89.084f, 1370.850f, -1416.250f, 110.916f);
            AddZone("Queens", -2593.440f, 54.722f, 0.000f, -2411.220f, 458.411f, 200.000f);
            AddZone("Pilson Intersection", 1098.390f, 2243.230f, -89.084f, 1377.390f, 2507.230f, 110.916f);
            AddZone("Spinybed", 2121.400f, 2663.170f, -89.084f, 2498.210f, 2861.550f, 110.916f);
            AddZone("Pilgrim", 2437.390f, 1383.230f, -89.084f, 2624.400f, 1783.230f, 110.916f);
            AddZone("Blackfield", 964.391f, 1403.220f, -89.084f, 1197.390f, 1726.220f, 110.916f);
            AddZone("'The Big Ear'", -410.020f, 1403.340f, -3.0f, -137.969f, 1681.230f, 200.000f);
            AddZone("Dillimore", 580.794f, -674.885f, -9.5f, 861.085f, -404.790f, 200.000f);
            AddZone("El Quebrados", -1645.230f, 2498.520f, 0.000f, -1372.140f, 2777.850f, 200.000f);
            AddZone("Esplanade North", -2533.040f, 1358.900f, -4.5f, -1996.660f, 1501.210f, 200.000f);
            AddZone("Easter Bay Airport", -1499.890f, -50.096f, -1.0f, -1242.980f, 249.904f, 200.000f);
            AddZone("Fisher's Lagoon", 1916.990f, -233.323f, -100.000f, 2131.720f, 13.800f, 200.000f);
            AddZone("Mulholland", 1414.070f, -768.027f, -89.084f, 1667.610f, -452.425f, 110.916f);
            AddZone("East Beach", 2747.740f, -1498.620f, -89.084f, 2959.350f, -1120.040f, 110.916f);
            AddZone("San Andreas Sound", 2450.390f, 385.503f, -100.000f, 2759.250f, 562.349f, 200.000f);
            AddZone("Shady Creeks", -2030.120f, -2174.890f, -6.1f, -1820.640f, -1771.660f, 200.000f);
            AddZone("Market", 1072.660f, -1416.250f, -89.084f, 1370.850f, -1130.850f, 110.916f);
            AddZone("Rockshore West", 1997.220f, 596.349f, -89.084f, 2377.390f, 823.228f, 110.916f);
            AddZone("Prickle Pine", 1534.560f, 2583.230f, -89.084f, 1848.400f, 2863.230f, 110.916f);
            AddZone("Easter Basin", -1794.920f, -50.096f, -1.04f, -1499.890f, 249.904f, 200.000f);
            AddZone("Leafy Hollow", -1166.970f, -1856.030f, 0.000f, -815.624f, -1602.070f, 200.000f);
            AddZone("LVA Freight Depot", 1457.390f, 863.229f, -89.084f, 1777.400f, 1143.210f, 110.916f);
            AddZone("Prickle Pine", 1117.400f, 2507.230f, -89.084f, 1534.560f, 2723.230f, 110.916f);
            AddZone("Blueberry", 104.534f, -220.137f, 2.3f, 349.607f, 152.236f, 200.000f);
            AddZone("El Castillo del Diablo", -464.515f, 2217.680f, 0.000f, -208.570f, 2580.360f, 200.000f);
            AddZone("Downtown", -2078.670f, 578.396f, -7.6f, -1499.890f, 744.267f, 200.000f);
            AddZone("Rockshore East", 2537.390f, 676.549f, -89.084f, 2902.350f, 943.235f, 110.916f);
            AddZone("San Fierro Bay", -2616.400f, 1501.210f, -3.0f, -1996.660f, 1659.680f, 200.000f);
            AddZone("Paradiso", -2741.070f, 793.411f, -6.1f, -2533.040f, 1268.410f, 200.000f);
            AddZone("The Camel's Toe", 2087.390f, 1203.230f, -89.084f, 2640.400f, 1383.230f, 110.916f);
            AddZone("Old Venturas Strip", 2162.390f, 2012.180f, -89.084f, 2685.160f, 2202.760f, 110.916f);
            AddZone("Juniper Hill", -2533.040f, 578.396f, -7.6f, -2274.170f, 968.369f, 200.000f);
            AddZone("Juniper Hollow", -2533.040f, 968.369f, -6.1f, -2274.170f, 1358.900f, 200.000f);
            AddZone("Roca Escalante", 2237.400f, 2202.760f, -89.084f, 2536.430f, 2542.550f, 110.916f);
            AddZone("Julius Thruway East", 2685.160f, 1055.960f, -89.084f, 2749.900f, 2626.550f, 110.916f);
            AddZone("Verona Beach", 647.712f, -2173.290f, -89.084f, 930.221f, -1804.210f, 110.916f);
            AddZone("Foster Valley", -2178.690f, -599.884f, -1.2f, -1794.920f, -324.114f, 200.000f);
            AddZone("Arco del Oeste", -901.129f, 2221.860f, 0.000f, -592.090f, 2571.970f, 200.000f);
            AddZone("Fallen Tree", -792.254f, -698.555f, -5.3f, -452.404f, -380.043f, 200.000f);
            AddZone("The Farm", -1209.670f, -1317.100f, 114.981f, -908.161f, -787.391f, 251.981f);
            AddZone("The Sherman Dam", -968.772f, 1929.410f, -3.0f, -481.126f, 2155.260f, 200.000f);
            AddZone("Esplanade North", -1996.660f, 1358.900f, -4.5f, -1524.240f, 1592.510f, 200.000f);
            AddZone("Financial", -1871.720f, 744.170f, -6.1f, -1701.300f, 1176.420f, 300.000f);
            AddZone("Garcia", -2411.220f, -222.589f, -1.14f, -2173.040f, 265.243f, 200.000f);
            AddZone("Montgomery", 1119.510f, 119.526f, -3.0f, 1451.400f, 493.323f, 200.000f);
            AddZone("Creek", 2749.900f, 1937.250f, -89.084f, 2921.620f, 2669.790f, 110.916f);
            AddZone("Los Santos International", 1249.620f, -2394.330f, -89.084f, 1852.000f, -2179.250f, 110.916f);
            AddZone("Santa Maria Beach", 72.648f, -2173.290f, -89.084f, 342.648f, -1684.650f, 110.916f);
            AddZone("Mulholland Intersection", 1463.900f, -1150.870f, -89.084f, 1812.620f, -768.027f, 110.916f);
            AddZone("Angel Pine", -2324.940f, -2584.290f, -6.1f, -1964.220f, -2212.110f, 200.000f);
            AddZone("Verdant Meadows", 37.032f, 2337.180f, -3.0f, 435.988f, 2677.900f, 200.000f);
            AddZone("Octane Springs", 338.658f, 1228.510f, 0.000f, 664.308f, 1655.050f, 200.000f);
            AddZone("Come-A-Lot", 2087.390f, 943.235f, -89.084f, 2623.180f, 1203.230f, 110.916f);
            AddZone("Redsands West", 1236.630f, 1883.110f, -89.084f, 1777.390f, 2142.860f, 110.916f);
            AddZone("Santa Maria Beach", 342.648f, -2173.290f, -89.084f, 647.712f, -1684.650f, 110.916f);
            AddZone("Verdant Bluffs", 1249.620f, -2179.250f, -89.084f, 1692.620f, -1842.270f, 110.916f);
            AddZone("Las Venturas Airport", 1236.630f, 1203.280f, -89.084f, 1457.370f, 1883.110f, 110.916f);
            AddZone("Flint Range", -594.191f, -1648.550f, 0.000f, -187.700f, -1276.600f, 200.000f);
            AddZone("Verdant Bluffs", 930.221f, -2488.420f, -89.084f, 1249.620f, -2006.780f, 110.916f);
            AddZone("Palomino Creek", 2160.220f, -149.004f, 0.000f, 2576.920f, 228.322f, 200.000f);
            AddZone("Ocean Docks", 2373.770f, -2697.090f, -89.084f, 2809.220f, -2330.460f, 110.916f);
            AddZone("Easter Bay Airport", -1213.910f, -50.096f, -4.5f, -947.980f, 578.396f, 200.000f);
            AddZone("Whitewood Estates", 883.308f, 1726.220f, -89.084f, 1098.310f, 2507.230f, 110.916f);
            AddZone("Calton Heights", -2274.170f, 744.170f, -6.1f, -1982.320f, 1358.900f, 200.000f);
            AddZone("Easter Basin", -1794.920f, 249.904f, -9.1f, -1242.980f, 578.396f, 200.000f);
            AddZone("Los Santos Inlet", -321.744f, -2224.430f, -89.084f, 44.615f, -1724.430f, 110.916f);
            AddZone("Doherty", -2173.040f, -222.589f, -1.0f, -1794.920f, 265.243f, 200.000f);
            AddZone("Mount Chiliad", -2178.690f, -2189.910f, -47.917f, -2030.120f, -1771.660f, 576.083f);
            AddZone("Fort Carson", -376.233f, 826.326f, -3.0f, 123.717f, 1220.440f, 200.000f);
            AddZone("Foster Valley", -2178.690f, -1115.580f, 0.000f, -1794.920f, -599.884f, 200.000f);
            AddZone("Ocean Flats", -2994.490f, -222.589f, -1.0f, -2593.440f, 277.411f, 200.000f);
            AddZone("Fern Ridge", 508.189f, -139.259f, 0.000f, 1306.660f, 119.526f, 200.000f);
            AddZone("Bayside", -2741.070f, 2175.150f, 0.000f, -2353.170f, 2722.790f, 200.000f);
            AddZone("Las Venturas Airport", 1457.370f, 1203.280f, -89.084f, 1777.390f, 1883.110f, 110.916f);
            AddZone("Blueberry Acres", -319.676f, -220.137f, 0.000f, 104.534f, 293.324f, 200.000f);
            AddZone("Palisades", -2994.490f, 458.411f, -6.1f, -2741.070f, 1339.610f, 200.000f);
            AddZone("North Rock", 2285.370f, -768.027f, 0.000f, 2770.590f, -269.740f, 200.000f);
            AddZone("Hunter Quarry", 337.244f, 710.840f, -115.239f, 860.554f, 1031.710f, 203.761f);
            AddZone("Los Santos International", 1382.730f, -2730.880f, -89.084f, 2201.820f, -2394.330f, 110.916f);
            AddZone("Missionary Hill", -2994.490f, -811.276f, 0.000f, -2178.690f, -430.276f, 200.000f);
            AddZone("San Fierro Bay", -2616.400f, 1659.680f, -3.0f, -1996.660f, 2175.150f, 200.000f);
            AddZone("Restricted Area", -91.586f, 1655.050f, -50.000f, 421.234f, 2123.010f, 250.000f);
            AddZone("Mount Chiliad", -2997.470f, -1115.580f, -47.917f, -2178.690f, -971.913f, 576.083f);
            AddZone("Mount Chiliad", -2178.690f, -1771.660f, -47.917f, -1936.120f, -1250.970f, 576.083f);
            AddZone("Easter Bay Airport", -1794.920f, -730.118f, -3.0f, -1213.910f, -50.096f, 200.000f);
            AddZone("The Panopticon", -947.980f, -304.320f, -1.1f, -319.676f, 327.071f, 200.000f);
            AddZone("Shady Creeks", -1820.640f, -2643.680f, -8.0f, -1226.780f, -1771.660f, 200.000f);
            AddZone("Back o Beyond", -1166.970f, -2641.190f, 0.000f, -321.744f, -1856.030f, 200.000f);
            AddZone("Mount Chiliad", -2994.490f, -2189.910f, -47.917f, -2178.690f, -1115.580f, 576.083f);
            AddZone("Tierra Robada", -1213.910f, 596.349f, -242.990f, -480.539f, 1659.680f, 900.000f);
            AddZone("Flint County", -1213.910f, -2892.970f, -242.990f, 44.615f, -768.027f, 900.000f);
            AddZone("Whetstone", -2997.470f, -2892.970f, -242.990f, -1213.910f, -1115.580f, 900.000f);
            AddZone("Bone County", -480.539f, 596.349f, -242.990f, 869.461f, 2993.870f, 900.000f);
            AddZone("Tierra Robada", -2997.470f, 1659.680f, -242.990f, -480.539f, 2993.870f, 900.000f);
            AddZone("San Fierro", -2997.470f, -1115.580f, -242.990f, -1213.910f, 1659.680f, 900.000f);
            AddZone("Las Venturas", 869.461f, 596.349f, -242.990f, 2997.060f, 2993.870f, 900.000f);
            AddZone("Red County", -1213.910f, -768.027f, -242.990f, 2997.060f, 596.349f, 900.000f);
            AddZone("Los Santos", 44.615f, -2892.970f, -242.990f, 2997.060f, -768.027f, 900.000f);
        }

        internal static ZoneManager GetInstance()
        {
            if (instance == null)
                instance = new ZoneManager();

            return instance;
        }

        private void AddCity(string name, float aX, float aY, float aZ, float bX, float bY, float bZ)
        {
            float[] coords = { aX, aY, aZ, bX, bY, bZ };
            cityName.Add(name);
            cityPosition.Add(coords);
        }

        private void AddZone(string name, float aX, float aY, float aZ, float bX, float bY, float bZ)
        {
            float[] coords = { aX, aY, aZ, bX, bY, bZ };
            zoneName.Add(name);
            zonePosition.Add(coords);
        }

        internal string City(float x, float y, float z)
        {
            string city = "Unbekannt";
            for (int i = 0; i < cityName.Count; i++)
            {
                string name = cityName[i];
                float[] pos = cityPosition[i];

                if (x >= pos[0] && y >= pos[1] && z >= pos[2] && x <= pos[3] && y <= pos[4] && z <= pos[5])
                {
                    city = name;
                }
            }

            return city;
        }

        internal string Zone(float x, float y, float z)
        {
            string zone = "Unbekannt";
            for (int i = 0; i < zoneName.Count; i++)
            {
                string name = zoneName[i];
                float[] pos = zonePosition[i];

                if (x >= pos[0] && y >= pos[1] && z >= pos[2] && x <= pos[3] && y <= pos[4] && z <= pos[5])
                {
                    zone = name;
                    break;
                }
            }

            return zone;
        }
    }
}
