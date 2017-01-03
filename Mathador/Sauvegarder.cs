using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathador
{
    class Sauvegarder
    {
        private List<Json_Data> json_tab = new List<Json_Data>();
        public static string filepath = @"D:\Bureau\save.txt";
        
        public static void sauve(int n_1, int n_2, int n_3, int n_4, int n_5, int v_cible)
        {
            
            Json_Data d = new Json_Data()
            {

                number_cible = v_cible,

                tirage = new int[5] { n_1, n_2, n_3, n_4, n_5 }
            };

            
            var jsonData = File.ReadAllText(filepath);

            
            var data = JsonConvert.DeserializeObject<List<Json_Data>>(jsonData) ?? new List<Json_Data>() ;

            data.Add(d);


            File.WriteAllText(filepath, JsonConvert.SerializeObject(data, Formatting.Indented));


           
        }

       
        public static Json_Data read(int ind)
        {
            Json_Data j_data = new Json_Data();

            string json = File.ReadAllText(filepath);
            JArray data = JArray.Parse(json);

            string json_data = JsonConvert.SerializeObject(data[ind]);

            j_data = JsonConvert.DeserializeObject<Json_Data>(json_data);

            return j_data;
                 
        }
    }
}
