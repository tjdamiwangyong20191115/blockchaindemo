using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace tjdamiblockchainclientdemo
{
    public class JsonHepler
    {        
        static public string getvaluefromjson(string p_json, string p_key)
        {
            if (p_json == "")
                return "";

            string strRet = "";

            try
            {
                JObject jo = JObject.Parse(p_json);

                string[] keys = p_key.Split('|');

                switch (keys.Length)
                {
                    case 1:
                        strRet = (string)jo[keys[0]];
                        break;
                    case 2:
                        strRet = (string)jo[keys[0]][keys[1]];
                        break;
                    case 3:
                        if (jo[keys[0]][keys[1]].GetType().ToString().Equals("Newtonsoft.Json.Linq.JArray"))
                        {
                            strRet = (string)jo[keys[0]][keys[1]][0][keys[2]];
                        }
                        else
                        {
                            strRet = (string)jo[keys[0]][keys[1]][keys[2]];
                        }
                        break;
                    case 4:
                        strRet = (string)jo[keys[0]][keys[1]][keys[2]][keys[3]];
                        break;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
            return strRet;
        }

    }
}
