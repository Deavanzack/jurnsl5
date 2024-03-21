using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302223124
{
    internal class SimpleDataBase <T>
    {
        private List <T> Data {  get; set; }
        private List<DateTime> Dates {  get; set; } 
        public SimpleDataBase()
        {
            Data = new List <T>();
            Dates = new List<DateTime>();
            Dates.Add(DateTime.Now);
        }
        public void addnewdata(T data)
        {
            Data.Add(data);
        }
        
        public void printalldata()
        {
            for (int i = 0; i < Data.Count; i++)
            {
                Console.WriteLine("Data " + i + "berisi: " + Data[i] + "yang disimpan pada waktu UTC: " + Dates[i]);
            }
        }

    }
}
