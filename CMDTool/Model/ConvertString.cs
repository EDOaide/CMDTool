using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDTool.Model
{
    public class ConvertString
    {
        public static string UnderLine(string param)
        {
            StringBuilder returnParam = new StringBuilder();
            bool upperFlag = false;

            var cList = param.ToCharArray();
            for (int j = 0; j < param.Count(); j++)
            {
                if (j == 0)
                {
                    returnParam.Append(cList[j].ToString().ToUpper());
                    upperFlag = false;
                }
                else if (cList[j].Equals('_'))
                {
                    upperFlag = true;
                }
                else if (upperFlag)
                {
                    returnParam.Append(cList[j].ToString().ToUpper());
                    upperFlag = false;
                }
                else
                {
                    returnParam.Append(cList[j].ToString().ToLower());
                    upperFlag = false;
                }
            }

            return returnParam.ToString();
        }
    }
}
