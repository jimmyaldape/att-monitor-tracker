using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HtmlAgilityPack;

namespace MonitorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessHtml();

            Console.ReadLine();
        }

        private static void ProcessHtml()
        {
            // load html document
            var html = new HtmlDocument();
            html.Load("monitors.html");

            // get table with id named main_tbl
            var mainTable = html.DocumentNode.SelectNodes("//table[@id='main_tbl']/tr/td");

            if (mainTable != null)
            {
                int x = 0;
                /*foreach (var tag1 in mainTable)
                {

                    Console.WriteLine("{0} Value: {1}", x, tag1.InnerText);
                    x++;
                }*/

                var titles = new List<string>();

                //get titles
                for (int i = 0; i < 8; i++)
                {
                    titles.Add(mainTable[i].InnerText);
                }
               
                

                for (int i = 9; i < mainTable.Count(); i++)
                {
                   /* if (i% 8 == 1)
                    {
                        Console.WriteLine("{0}: {1}", titles[0], mainTable[i].InnerText);
                    }*/

                    Console.WriteLine("{0}: {1}", titles[0], mainTable[i].InnerText);
                }


            }

        }
    }
}
