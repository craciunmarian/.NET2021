using System;

namespace Lab2.Weather
{
    class DailyWeather
    {
        public int Day { get; private set; }
        private readonly decimal mxT;
        private readonly decimal mnT;
        private readonly decimal avT;
        private readonly int hDDay;
        private readonly decimal avDP;
        private readonly decimal tpcpn;
        private readonly string wxType;
        private readonly int pDir;
        private readonly decimal avSp;
        private readonly int dir;
        private readonly int mxS;
        private readonly decimal skyC;
        private readonly int mxR;
        private readonly int mnR;
        private readonly decimal avSLP;

        public DailyWeather(int Day, decimal MxT, decimal MnT, decimal AvT, int HDDay, decimal AvDP, decimal Tpcpn, string WxType, int PDir, decimal AvSp, int Dir, int MxS, decimal SkyC, int MxR, int MnR, decimal AvSLP)
        {
            this.Day = Day;
            mxT = MxT;
            mnT = MnT;
            avT = AvT;
            hDDay = HDDay;
            avDP = AvDP;
            tpcpn = Tpcpn;
            wxType = WxType;
            pDir = PDir;
            avSp = AvSp;
            dir = Dir;
            mxS = MxS;
            skyC = SkyC;
            mxR = MxR;
            mnR = MnR;
            avSLP = AvSLP;
        }

        public decimal TemperatureSpread()
        {
            return mxT - mnT;
        }

        public static int minimumSpread(DailyWeather[] records)
        {
            int day = records[0].Day;
            decimal minimumTemp = records[0].TemperatureSpread();
            foreach (var item in records)
            {
                if(item.TemperatureSpread() < minimumTemp)
                {
                    minimumTemp = item.TemperatureSpread();
                    day = item.Day;
                }
            }
            return day;
        }

        public override string ToString()
        {
            return string.Join(" ", Day, mxT, mnT, avT, hDDay, avDP, tpcpn, wxType, pDir, avSp,  dir,  mxS, skyC, mxR, mnR, avSLP);
        }
        
    }
}
