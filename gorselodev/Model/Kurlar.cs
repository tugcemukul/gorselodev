﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gorselodev.Model
{
    public class kurItem
    {
        public string Doviz { get; set; }
        public string Alis { get; set; }
        public string Satis { get; set; }
        public string Fark { get; set; }
        public string Yon { get; set; }

        public class Root
        {
            public USD USD { get; set; }
            public EUR EUR { get; set; }
            public GBP GBP { get; set; }
            public GA GA { get; set; }
            public C C { get; set; }
            public GAG GAG { get; set; }
            public BTC BTC { get; set; }
            public ETH ETH { get; set; }
        }
        public class BTC
        {
            public string satis { get; set; }
            public string alis { get; set; }
            public string yuksek { get; set; }
            public string dusuk { get; set; }
            public string degisim { get; set; }
            public string oran { get; set; }
            public string yon { get; set; }
        }

        public class C
        {
            public string satis { get; set; }
            public string alis { get; set; }
            public string yuksek { get; set; }
            public string dusuk { get; set; }
            public string degisim { get; set; }
            public string oran { get; set; }
            public string yon { get; set; }
        }

        public class ETH
        {
            public string satis { get; set; }
            public string alis { get; set; }
            public string yuksek { get; set; }
            public string dusuk { get; set; }
            public string degisim { get; set; }
            public string oran { get; set; }
            public string yon { get; set; }
        }

        public class EUR
        {
            public string satis { get; set; }
            public string alis { get; set; }
            public string yuksek { get; set; }
            public string dusuk { get; set; }
            public string degisim { get; set; }
            public string oran { get; set; }
            public string yon { get; set; }
        }

        public class GA
        {
            public string satis { get; set; }
            public string alis { get; set; }
            public string yuksek { get; set; }
            public string dusuk { get; set; }
            public string degisim { get; set; }
            public string oran { get; set; }
            public string yon { get; set; }
        }

        public class GAG
        {
            public string satis { get; set; }
            public string alis { get; set; }
            public string yuksek { get; set; }
            public string dusuk { get; set; }
            public string degisim { get; set; }
            public string oran { get; set; }
            public string yon { get; set; }
        }

        public class GBP
        {
            public string satis { get; set; }
            public string alis { get; set; }
            public string yuksek { get; set; }
            public string dusuk { get; set; }
            public string degisim { get; set; }
            public string oran { get; set; }
            public string yon { get; set; }
        }


        public class USD
        {
            public string satis { get; set; }
            public string alis { get; set; }
            public string yuksek { get; set; }
            public string dusuk { get; set; }
            public string degisim { get; set; }
            public string oran { get; set; }
            public string yon { get; set; }
        }
    }
}
