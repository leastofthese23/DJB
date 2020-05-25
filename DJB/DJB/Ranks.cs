using System;
using System.Collections.Generic;
using System.Text;

namespace DJB
{
    public class Ranks
    {
        public static string GetNextRank(string rank)
        {
            var dicRanks = RankNextRankDic();
            return dicRanks[rank];
        }

        public static List<string> RanksList()
        {
            var rnks = new List<string>();
            rnks.Add("10th Kyu - White Belt");
            rnks.Add("9th Kyu - Blue I");
            rnks.Add("8th Kyu - Blue II");
            rnks.Add("7th Kyu - Blue III");
            rnks.Add("6th Kyu - Green I");
            rnks.Add("5th Kyu - Green II");
            rnks.Add("4th Kyu - Green III");
            rnks.Add("3rd Kyu - Brown I");
            rnks.Add("2nd Kyu - Brown II");
            rnks.Add("1st Kyu - Brown III");
            rnks.Add("Shodan - Black I");
            rnks.Add("Nidan - Black II");
            rnks.Add("Sandan - Black III");
            rnks.Add("Yandan - Black IV");
            rnks.Add("Godan - Black V");
            rnks.Add("Rokudan - Black VI");
            rnks.Add("Nanadan - Black VII");
            rnks.Add("Hachidan - Black VIII");
            rnks.Add("Kudan - Black IV");

            return rnks;
        }

        public static List<string> RanksListMinus1()
        {
            var rnks = new List<string>();
            rnks.Add("10th Kyu - White Belt");
            rnks.Add("9th Kyu - Blue I");
            rnks.Add("8th Kyu - Blue II");
            rnks.Add("7th Kyu - Blue III");
            rnks.Add("6th Kyu - Green I");
            rnks.Add("5th Kyu - Green II");
            rnks.Add("4th Kyu - Green III");
            rnks.Add("3rd Kyu - Brown I");
            rnks.Add("2nd Kyu - Brown II");
            rnks.Add("1st Kyu - Brown III");
            rnks.Add("Shodan - Black I");
            rnks.Add("Nidan - Black II");
            rnks.Add("Sandan - Black III");
            rnks.Add("Yandan - Black IV");
            rnks.Add("Godan - Black V");
            rnks.Add("Rokudan - Black VI");
            rnks.Add("Nanadan - Black VII");
            rnks.Add("Hachidan - Black VIII");

            return rnks;
        }


        public static Dictionary<string, string> RankNextRankDic()
        {
            var rDic = new Dictionary<string, string>();
            rDic.Add("10th Kyu - White Belt", "9th Kyu - Blue I");
            rDic.Add("9th Kyu - Blue I", "8th Kyu - Blue II");
            rDic.Add("8th Kyu - Blue II", "7th Kyu - Blue III");
            rDic.Add("7th Kyu - Blue III", "6th Kyu - Green I");
            rDic.Add("6th Kyu - Green I", "5th Kyu - Green II");
            rDic.Add("5th Kyu - Green II", "4th Kyu - Green III");
            rDic.Add("4th Kyu - Green III", "3rd Kyu - Brown I");
            rDic.Add("3rd Kyu - Brown I", "2nd Kyu - Brown II");
            rDic.Add("2nd Kyu - Brown II", "1st Kyu - Brown III");
            rDic.Add("1st Kyu - Brown III", "Shodan - Black I");
            rDic.Add("Shodan - Black I", "Nidan - Black II");
            rDic.Add("Nidan - Black II", "Sandan - Black III");
            rDic.Add("Sandan - Black III", "Yandan - Black IV");
            rDic.Add("Yandan - Black IV", "Godan - Black V");
            rDic.Add("Godan - Black V", "Rokudan - Black VI");
            rDic.Add("Rokudan - Black VI", "Nanadan - Black VII");
            rDic.Add("Nanadan - Black VII", "Hachidan - Black VIII");
            rDic.Add("Hachidan - Black VIII", "Kudan - Black IV");
            rDic.Add("Kudan - Black IV", "Chuck Norris");

            return rDic;
        }

        public static List<string> GetRankReqs(string rank)
        {
            var ranksCol = new Dictionary<string, List<string>>();
            var reqList = new List<string>();

            ranksCol.Add("10th Kyu - White Belt", WhiteBeltReq());
            ranksCol.Add("9th Kyu - Blue I", Blue1Req());
            ranksCol.Add("8th Kyu - Blue II", Blue2Req());
            ranksCol.Add("7th Kyu - Blue III", Blue3Req());
            ranksCol.Add("6th Kyu - Green I", Green1Req());
            ranksCol.Add("5th Kyu - Green II", Green2Req());
            ranksCol.Add("4th Kyu - Green III", Green3Req());
            ranksCol.Add("3rd Kyu - Brown I", Brown1Req());
            ranksCol.Add("2nd Kyu - Brown II", Brown2Req());
            ranksCol.Add("1st Kyu - Brown III", Brown3Req());
            ranksCol.Add("Shodan - Black I", Black1Req());
            ranksCol.Add("Nidan - Black II", Black2Req());
            ranksCol.Add("Sandan - Black III", Black3Req());
            ranksCol.Add("Yandan - Black IV", Black4Req());
            ranksCol.Add("Godan - Black V", Black5Req());
            ranksCol.Add("Rokudan - Black VI", Black6Req());
            ranksCol.Add("Nanadan - Black VII", Black7Req());
            ranksCol.Add("Hachidan - Black VIII", Black8Req());

            reqList = ranksCol[rank];
            return reqList;
        }

        public static List<string> GetRankReqByIndex(int i)
        {
            var ranksCol = new Dictionary<int, List<string>>();
            var reqList = new List<string>();

            ranksCol.Add(0, WhiteBeltReq());
            ranksCol.Add(1, Blue1Req());
            ranksCol.Add(2, Blue2Req());
            ranksCol.Add(3, Blue3Req());
            ranksCol.Add(4, Green1Req());
            ranksCol.Add(5, Green2Req());
            ranksCol.Add(6, Green3Req());
            ranksCol.Add(7, Brown1Req());
            ranksCol.Add(8, Brown2Req());
            ranksCol.Add(9, Brown3Req());
            ranksCol.Add(10, Black1Req());
            ranksCol.Add(11, Black2Req());
            ranksCol.Add(12, Black3Req());
            ranksCol.Add(13, Black4Req());
            ranksCol.Add(14, Black5Req());
            ranksCol.Add(15, Black6Req());
            ranksCol.Add(16, Black7Req());
            ranksCol.Add(17, Black8Req());

            reqList = ranksCol[i];
            return reqList;
        }

        public static List<string> WhiteBeltReq()
        {
            var wbr = new List<string>();
            wbr.Add("Age Requirement: none");
            wbr.Add("Time Requirement: 3 months");
            wbr.Add("Kyu Rank Basics");
            wbr.Add("Kata Fukyugata Ichi");
            wbr.Add("Tuite - White Belt");
            wbr.Add("Ippon Kumite - White Belt");

            return wbr;
        }

        public static List<string> Blue1Req()
        {
            var wbr = new List<string>();
            wbr.Add("Age Requirement: none");
            wbr.Add("Time Requirement: 3 months");
            wbr.Add("Kata Fukyugata Ni");
            wbr.Add("Kata Fukyugata San");
            wbr.Add("Koteatie Set 1");
            wbr.Add("Bo Warmups");
            wbr.Add("Ippon Kumite - Blue Belt");

            return wbr;
        }

        public static List<string> Blue2Req()
        {
            var wbr = new List<string>();
            wbr.Add("Age Requirement: none");
            wbr.Add("Time Requirement: 3 months");
            wbr.Add("Kata Geigazai Dai Ichi");
            wbr.Add("Weapons Kata: Fukyu No Kon");
            wbr.Add("self defense set #1");
            wbr.Add("Bo Basics");
            wbr.Add("13 training exercises");
            wbr.Add("kick drill #1");

            return wbr;
        }

        public static List<string> Blue3Req()
        {
            var wbr = new List<string>();
            wbr.Add("Age Requirement: none");
            wbr.Add("Time Requirement: 3 months");
            wbr.Add("Kata Wansu");
            wbr.Add("Bo Shodan");
            wbr.Add("self defense set #2");
            wbr.Add("bo tai bo set #1");

            return wbr;
        }

        public static List<string> Green1Req()
        {
            var wbr = new List<string>();
            wbr.Add("Age Requirement: none");
            wbr.Add("Time Requirement: 3 months");
            wbr.Add("Pinan Shodan");
            wbr.Add("Bo Nidan");
            wbr.Add("6th kyu tuite");
            wbr.Add("green belt ippon kumite");
            wbr.Add("Sai basics");
            wbr.Add("change body drills");

            return wbr;
        }

        public static List<string> Green2Req()
        {
            var wbr = new List<string>();
            wbr.Add("Age Requirement: none");
            wbr.Add("Time Requirement: 3 months");
            wbr.Add("Kata Pinan Nidan");
            wbr.Add("Bo Jitsu");
            wbr.Add("Sai Shodan");
            wbr.Add("5th kyu tuite");
            wbr.Add("bo tai bo set #2");
            wbr.Add("koteatie set #2");

            return wbr;
        }

        public static List<string> Green3Req()
        {
            var wbr = new List<string>();
            wbr.Add("Age Requirement: none");
            wbr.Add("Time Requirement: 3 months");
            wbr.Add("Kata Naihanchi Shodan");
            wbr.Add("Kata Pinan Sandan");
            wbr.Add("Sai Nidan");
            wbr.Add("4th kyu tuite");

            return wbr;
        }

        public static List<string> Brown1Req()
        {
            var wbr = new List<string>();
            wbr.Add("Age Requirement: none");
            wbr.Add("Time Requirement: 4 months");
            wbr.Add("Kata Naihanchi Nidan");
            wbr.Add("Kata Anan Ku");
            wbr.Add("Sai Jitsu");
            wbr.Add("3rd kyu tuite");
            wbr.Add("brown belt ippon kumite");
            wbr.Add("bo tai bo set #3");

            return wbr;
        }

        public static List<string> Brown2Req()
        {
            var wbr = new List<string>();
            wbr.Add("Age Requirement: none");
            wbr.Add("Time Requirement: 4 months");
            wbr.Add("Kata Naihanchi Sandan");
            wbr.Add("Bo Sandan");
            wbr.Add("2nd kyu tuite");
            wbr.Add("Kama basics");
            wbr.Add("koteatie set #3");
            wbr.Add("");

            return wbr;
        }

        public static List<string> Brown3Req()
        {
            var wbr = new List<string>();
            wbr.Add("Age Requirement: 16");
            wbr.Add("Time Requirement: 7 months");
            wbr.Add("Kata Seisan");
            wbr.Add("Pinan Yondan");
            wbr.Add("Kama Shodan");
            wbr.Add("Suishi no kon Sho");
            wbr.Add("1st kyu tuite");

            return wbr;
        }

        public static List<string> Black1Req()
        {
            var wbr = new List<string>();
            wbr.Add("Age Requirement: 17");
            wbr.Add("Time Requirement: 1 year");
            wbr.Add("Black belt basics");
            wbr.Add("Kata Passai Sho");
            wbr.Add("Kata Pinan Godan");
            wbr.Add("Kise Bo");
            wbr.Add("Sai Sandan");
            wbr.Add("black belt ippon kumite");

            return wbr;
        }

        public static List<string> Black2Req()
        {
            var wbr = new List<string>();
            wbr.Add("Age Requirement: 19");
            wbr.Add("Time Requirement: 2 years");
            wbr.Add("Kata Passai Dai");
            wbr.Add("Kata NijuShiho");
            wbr.Add("Tokumine no kon");
            wbr.Add("Tonfa Shodan");
            wbr.Add("Tonfa Basics");

            return wbr;
        }

        public static List<string> Black3Req()
        {
            var wbr = new List<string>();
            wbr.Add("Age Requirement: 23");
            wbr.Add("Time Requirement: 3 years");
            wbr.Add("Kata Chinto");
            wbr.Add("Kata Jion");
            wbr.Add("Kama Nidan");
            wbr.Add("Suishi no kon Dai");

            return wbr;
        }

        public static List<string> Black4Req()
        {
            var wbr = new List<string>();
            wbr.Add("Age Requirement: 28");
            wbr.Add("Time Requirement: 4 years");
            wbr.Add("Kata Gojushiho");
            wbr.Add("Soken no Nunchaku");
            wbr.Add("Teco Kata");

            return wbr;
        }

        public static List<string> Black5Req()
        {
            var wbr = new List<string>();
            wbr.Add("Age Requirement: 35");
            wbr.Add("Time Requirement: 4.5 years");
            wbr.Add("Kata Kusanku");
            wbr.Add("Sakugawa no kon Sho");

            return wbr;
        }

        public static List<string> Black6Req()
        {
            var wbr = new List<string>();
            wbr.Add("Age Requirement: 45");
            wbr.Add("Time Requirement: 5 years");
            wbr.Add("Kata Rohai Sho");
            wbr.Add("Kata Rohai Ni");
            wbr.Add("Sakugawa no kon Dai");
            wbr.Add("Tsuken Sunakake no Kon");

            return wbr;
        }

        public static List<string> Black7Req()
        {
            var wbr = new List<string>();
            wbr.Add("There are no technical requirements to be promoted to 8th dan Black belt. It is an honorary title reserved for masters.");

            return wbr;
        }

        public static List<string> Black8Req()
        {
            var wbr = new List<string>();
            wbr.Add("There are no technical requirements to be promoted to 9th dan Black belt. It is an honorary title reserved for the grandmaster.");

            return wbr;
        }


    }
}
