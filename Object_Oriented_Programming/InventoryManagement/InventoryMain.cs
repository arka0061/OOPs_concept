using System;
using Newtonsoft.Json;
using Object_Oriented_Programming;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Object_Oriented_Programming.InventoryManagement
{
    public class InventoryMain
    {

        public void DisplayData(String filepath)
        {
            try
            {
                using(StreamReader read=new StreamReader(filepath))
                {
                    var json = read.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<InventoryModel>>(json);
                    Console.WriteLine("Name/Weight/Rate/Amount");
                    foreach(var item in items)
                    {
                        Console.WriteLine("{0}"+"\t"+"{1}"+"\t"+"{2}"+"\t"+"{3}",item.Name,item.Weight,item.PricePerKg,item.Weight*item.PricePerKg);
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
