﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.EldenRing;

namespace cli
{
    internal class EventFlagDiscovery
    {
        private EldenRing _eldenRing;
        public EventFlagDiscovery(EldenRing eldenRing)
        {
            _eldenRing = eldenRing;
            
            var knownBosses = Enum.GetValues(typeof(Boss)).Cast<uint>().ToList();
            foreach (var b in knownBosses)
            {
                _bossFlags.Remove(b);
            }


            foreach (var f in _bossFlags)
            {
                var val = _eldenRing.ReadEventFlag(f);
                if (val)
                {
                    Console.WriteLine($"bossflag {f} enabled during init");
                }
                _bossData[f] = val;
            }

            //foreach (var f in _bonfires)
            //{
            //    var val = _eldenRing.MaybeReadEventFlag(f);
            //    if (val)
            //    {
            //        Console.WriteLine($"bossflag {f} enabled during init");
            //    }
            //    _bonfireData[f] = val;
            //}
        }

        public void Update()
        {
            foreach (var f in _bossFlags)
            {
                var previous = _bossData[f];
                var current = _eldenRing.ReadEventFlag(f);
                _bossData[f] = current;

                if (previous != current)
                {
                    Console.WriteLine($"bossflag {f} went from {previous} to {current}");
                }
            }

            //foreach (var f in _bonfires)
            //{
            //    var previous = _bonfireData[f];
            //    var current = _eldenRing.MaybeReadEventFlag(f);
            //    _bonfireData[f] = current;
            //
            //    if (previous != current)
            //    {
            //        Console.WriteLine($"bonfire {f} went from {previous} to {current}");
            //    }
            //}
        }



        private Dictionary<uint, bool> _bossData = new Dictionary<uint, bool>();
        private Dictionary<uint, bool> _bonfireData = new Dictionary<uint, bool>();


        private List<uint> _bossFlags = new List<uint>()
        {
            10000800,
            10000850,
            10010800,
            11000800,
            11000850,
            11050800,
            11050850,
            12010800,
            12010850,
            12020800,
            12020830,
            12020850,
            12030390,
            12030800,
            12030850,
            12040800,
            12050800,
            12080800,
            12090800,
            13000800,
            13000830,
            13000850,
            14000800,
            14000850,
            15000800,
            15000850,
            16000800,
            16000850,
            16000860,
            18000800,
            18000850,
            19000800,
            35000800,
            35000850,
            39200800,
            30000800,
            30010800,
            30020800,
            30110800,
            30040800,
            30050800,
            30050850,
            30030800,
            30060800,
            30080800,
            30090800,
            30100800,
            30100801,
            30120800,
            30120801,
            30070800,
            30130800,
            30140800,
            30150800,
            30160800,
            30170800,
            30180800,
            30190800,
            30200800,
            31000800,
            31010800,
            31020800,
            31030800,
            31150800,
            31170800,
            31040800,
            31050800,
            31060800,
            31070800,
            31090800,
            31180800,
            31190800,
            31210800,
            31100800,
            31200800,
            31110800,
            31120800,
            31220800,
            32000800,
            32010800,
            32020800,
            32040800,
            34120800,
            32050800,
            32050801,
            32070800,
            32080800,
            32110800,
            34130800,
            34140850,
            1044360800,
            1043370340,
            1042380800,
            1042380850,
            1042330800,
            1044350800,
            1042370800,
            1043330800,
            1044320342,
            1044320340,
            1043300800,
            1042360800,
            1043360800,
            1045390800,
            1034480800,
            1038410800,
            1033450800,
            1036500800,
            1033420800,
            1033430800,
            1038480800,
            1035500800,
            1037460800,
            1039430340,
            1036480340,
            1037420340,
            1036450340,
            1034450800,
            1034500800,
            1034420800,
            1035420800,
            1039440800,
            1037510800,
            1041520800,
            1038510800,
            1041500800,
            1040530800,
            1041510800,
            1042550800,
            1040520800,
            1045520800,
            1039500800,
            1041530800,
            1039510800,
            1044530800,
            1043530800,
            1037530800,
            1035530800,
            1036540800,
            1039540800,
            1037540810,
            1038520340,
            1047400800,
            1048370800,
            1048400800,
            1049370800,
            1049370850,
            1049380800,
            1051360800,
            1052380800,
            1049390800,
            1048410800,
            1049390850,
            1051400800,
            1052410800,
            1052410850,
            1051430800,
            1048510800,
            1049520800,
            1054560800,
            1053560800,
            1052520800,
            1052560800,
            1050570800,
            1050570850,
            1051570800,
            1050560800,
            1248550800,
            1048570800,
        };

        private List<uint> _bonfires = new List<uint>()
        {
            100000,
            100001,
            100002,
            100003,
            100004,
            100005,
            100006,
            100007,
            100008,
            110000,
            110001,
            110002,
            110003,
            110004,
            110005,
            110007,
            110008,
            110009,
            110500,
            110501,
            110502,
            110503,
            110504,
            110505,
            111000,
            120100,
            120101,
            120102,
            120103,
            120104,
            120105,
            120106,
            120108,
            120109,
            120200,
            120201,
            120203,
            120204,
            120206,
            120207,
            120208,
            120209,
            120300,
            120301,
            120302,
            120303,
            120304,
            120305,
            120400,
            120500,
            120501,
            120502,
            120503,
            120600,
            120601,
            120700,
            120701,
            130000,
            130001,
            130002,
            130003,
            130004,
            130005,
            130006,
            130007,
            130008,
            130009,
            130010,
            140000,
            140001,
            140002,
            140003,
            150000,
            150001,
            150002,
            150003,
            150004,
            150005,
            150006,
            150007,
            150008,
            160000,
            160001,
            160002,
            160003,
            160004,
            160005,
            160006,
            160007,
            180000,
            180001,
            190000,
            300000,
            300100,
            300200,
            300300,
            300400,
            300500,
            300600,
            300700,
            300800,
            300900,
            301000,
            301100,
            301200,
            301300,
            301400,
            301500,
            301600,
            301700,
            301800,
            301900,
            302000,
            310000,
            310100,
            310200,
            310300,
            310400,
            310500,
            310600,
            310700,
            310900,
            311000,
            311100,
            311200,
            311500,
            311700,
            311800,
            311900,
            312000,
            312100,
            312200,
            320000,
            320100,
            320200,
            320400,
            320500,
            320700,
            320701,
            320800,
            321100,
            341000,
            341002,
            341100,
            341101,
            341102,
            341200,
            341201,
            341202,
            341301,
            341302,
            341400,
            341401,
            341500,
            350000,
            350001,
            350002,
            350003,
            350004,
            390000,
            390001,
            390002,
            61423600,
            61423601,
            61413800,
            61443800,
            61463800,
            61453600,
            61443500,
            61433700,
            61413500,
            61423700,
            61433500,
            61443700,
            61433800,
            61433900,
            61423800,
            61443900,
            61443600,
            61433400,
            61443300,
            61423300,
            61443301,
            61443302,
            61453300,
            61413200,
            61443400,
            61433100,
            61433101,
            61433102,
            61433000,
            61413300,
            62394000,
            62384000,
            62384100,
            62374200,
            62374400,
            62354500,
            62354600,
            62364800,
            62364900,
            62385000,
            62334600,
            62344701,
            62344800,
            62344900,
            62355003,
            62364100,
            62364300,
            62384500,
            62334400,
            62354300,
            62344200,
            62394200,
            62384300,
            62384501,
            62374600,
            62384700,
            62374800,
            62334700,
            62345000,
            62385001,
            62355000,
            62355001,
            62355002,
            62364500,
            62384600,
            62364901,
            62364301,
            62344300,
            62365000,
            62384800,
            62374900,
            62344400,
            62354700,
            62344600,
            62394100,
            62394400,
            62345000,
            62344100,
            62354200,
            62334000,
            63375100,
            63385002,
            63385100,
            63395100,
            63405200,
            63415201,
            63405300,
            63405400,
            63415400,
            63425100,
            63435000,
            63435300,
            63435301,
            63425500,
            63455200,
            63395300,
            63385400,
            63365401,
            63365402,
            63375200,
            63355300,
            63365200,
            63375300,
            63395400,
            63395401,
            63395402,
            64464000,
            64464001,
            64473900,
            64474000,
            64483600,
            64483700,
            64483800,
            64483801,
            64483900,
            64484000,
            64493700,
            64493800,
            64493801,
            64493900,
            64493901,
            64493902,
            64503600,
            64503800,
            64513600,
            64513601,
            64523800,
            64484001,
            64484100,
            64504000,
            64513900,
            64514300,
            64524100,
            64524200,
            65475100,
            65495300,
            65495301,
            65515600,
            65525700,
            65545500,
            65525400,
            65515300,
            65525300,
            65535200,
            65545300,
            65525600,
            65515700,
            65515701,
            65515702,
            65515703,
            65495400,
            65495500,
            65485700,
            65475800,
        };
    }
}
