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
                if(File.Exists(filepath))
                {
                    string jsonData = File.ReadAllText(filepath);
                    InventoryModel jsonObjectArray = JsonConvert.DeserializeObject<InventoryModel>(jsonData);
                    Console.WriteLine("Name"+"\t"+"Weight"+"\t"+"Rate"+"\t"+"Amount");
                    List<Rice> rice = jsonObjectArray.RiceList;
                    foreach(var item in rice)
                    {
                        Console.WriteLine("{0}"+"\t"+"{1}"+"\t"+"{2}"+"\t"+"{3}",item.Name,item.Weight,item.PricePerKg,item.Weight*item.PricePerKg);
                    }
                    List<Wheat> wheat = jsonObjectArray.WheatList;
                    foreach (var item in wheat)
                    {
                        Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t" + "{3}", item.Name, item.Weight, item.PricePerKg, item.Weight * item.PricePerKg);
                    }
                    List<Pulses> pulses = jsonObjectArray.PulsesList;
                    foreach (var item in pulses)
                    {
                        Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t" + "{3}", item.Name, item.Weight, item.PricePerKg, item.Weight * item.PricePerKg);
                    }
                }
                else
                {
                    Console.WriteLine("File Does not Exists");
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        

    }
}
