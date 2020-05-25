using System;
using System.Collections.Generic;
using System.Text;


namespace DJB.Controls
{
    public class Lists
    {

        static void Main(string[] args)
        {

        }

        public static List<ListViewTextItem> RankReq(string rank) //TODO: this method needs to query the database and return a list of requirements from the database table.
        {
            var rrList = new List<ListViewTextItem>();
            var listOfRankReqs = new List<string>();
            
            listOfRankReqs = DJB.Ranks.GetRankReqs(rank);
            foreach (string item in listOfRankReqs)
            {
                rrList.Add(new ListViewTextItem() { requirement = item });
            }

            return rrList;
        }

        public static List<int> MonthsList()
        {
            var mList = new List<int>();
            for (int i = 0; i <= 1000; i++)
            {
                mList.Add(i);
            }

            return mList;
        }

        public static List<string> GenderList()
        {
            var gList = new List<string>();
            gList.Add("Male");
            gList.Add("Female");
            gList.Add("Herm");
            gList.Add("Trans");

            return gList;
        }

        public static List<string> ActiveStudents()
        {
            var stdList = new List<string>();
            stdList.Add("Adam Wright Sirkis");
            stdList.Add("Alyssa Webb");
            stdList.Add("Angelina Kukkonnen");
            stdList.Add("Anthony Pirot");
            stdList.Add("Diana Reynolds");
            stdList.Add("Erik Anderson");
            stdList.Add("Max Puls");

            return stdList;
        }

        public static List<string> TrueFalse()
        {
            var tfList = new List<string>();
            tfList.Add("True");
            tfList.Add("False");

            return tfList;
        }

        public static List<string> StateAbbList()
        {
            var stList = new List<string>();
            stList.Add("AL");
            stList.Add("AK");
            stList.Add("AZ");
            stList.Add("AR");
            stList.Add("CA");
            stList.Add("CO");
            stList.Add("CT");
            stList.Add("DE");
            stList.Add("FL");
            stList.Add("GA");
            stList.Add("HI");
            stList.Add("ID");
            stList.Add("IL");
            stList.Add("IN");
            stList.Add("IA");
            stList.Add("KS");
            stList.Add("KY");
            stList.Add("LA");
            stList.Add("ME");
            stList.Add("MD");
            stList.Add("MA");
            stList.Add("MI");
            stList.Add("MN");
            stList.Add("MS");
            stList.Add("MO");
            stList.Add("MT");
            stList.Add("NE");
            stList.Add("NV");
            stList.Add("NH");
            stList.Add("NJ");
            stList.Add("NM");
            stList.Add("NY");
            stList.Add("NC");
            stList.Add("ND");
            stList.Add("OH");
            stList.Add("OK");
            stList.Add("OR");
            stList.Add("PA");
            stList.Add("RI");
            stList.Add("SC");
            stList.Add("SD");
            stList.Add("TN");
            stList.Add("TX");
            stList.Add("UT");
            stList.Add("VT");
            stList.Add("VA");
            stList.Add("WA");
            stList.Add("WV");
            stList.Add("WI");
            stList.Add("WY");

            return stList;
        }

    }

    
}
