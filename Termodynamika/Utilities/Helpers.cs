using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Termodynamika.Models;

namespace Termodynamika.Utilities
{
    static class Helpers
    {
        public static InputDataModel ParseFile(this Stream s)
        {
            if (s != null)
            {
                InputDataModel input = new InputDataModel();
                using(StreamReader sR = new StreamReader(s))
                {
                    input.CO = sR.ReadLine().TryParseDouble();
                    input.CO2 = sR.ReadLine().TryParseDouble();
                    input.CH4 = sR.ReadLine().TryParseDouble();
                    input.O2 = sR.ReadLine().TryParseDouble();
                    input.N2 = sR.ReadLine().TryParseDouble();
                    input.H2 = sR.ReadLine().TryParseDouble();
                    input.Lambda = sR.ReadLine().TryParseDouble();
                    input.Vg = sR.ReadLine().TryParseDouble();
                    input.tg = sR.ReadLine().TryParseDouble();
                    input.tp = sR.ReadLine().TryParseDouble();
                    input.twin = sR.ReadLine().TryParseDouble();
                    input.mw = sR.ReadLine().TryParseDouble();
                    input.A = sR.ReadLine().TryParseDouble();
                    input.alfa = sR.ReadLine().TryParseDouble();
                    input.beta = sR.ReadLine().TryParseDouble();
                    sR.Close();
                }
                return input;
            }
            throw new NullReferenceException(@"Can't read from file...");
        }

        private static double TryParseDouble(this string line)
        {
            double value;
            if (double.TryParse(line.Trim(), out value))
            {
                return value;
            }
            else
            {
                line = line.Replace(".", ",");
                if (double.TryParse(line.Trim(), out value))
                {
                    return value;
                }
                else
                {
                    throw new FormatException("The format of the double is not supported.");
                }
            }
        }

        public static bool ParseDouble(this string line, out double value)
        {
            try
            {
                value = line.TryParseDouble();
                return true;
            }catch(Exception e)
            {
                value = double.NegativeInfinity;
                return false;
            }
        }

        public static void WriteToFile(this OutputDataModel o, string fileName)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName))
            {
                file.AutoFlush = false;
                file.WriteLine(string.Format("CO2= {0} %", o.CO2));
                file.WriteLine(string.Format("H2O= {0} %", o.H2O));
                file.WriteLine(string.Format("N2= {0} %", o.N2));
                file.WriteLine(string.Format("O2= {0} %", o.O2));
                file.WriteLine(string.Format("Vg = {0} Nm3/h", o.Vg));
                file.WriteLine(string.Format("Vc = {0} Nm3/h", o.Vc));
                file.WriteLine(string.Format("Vc = {0} m3/h", o.Vc));
                file.WriteLine(string.Format("Vs = {0} Nm3/h", o.Vs));
                file.WriteLine(string.Format("Vs = {0} m3/h", o.Vs));
                file.WriteLine(string.Format("t,w = {0} C", o.tw));
                file.WriteLine(string.Format("t,a = {0} C", o.ta));
                file.WriteLine(string.Format("t,s = {0} C", o.ts));
                file.WriteLine(string.Format("Q,q = {0} kW", o.Qq));
                file.WriteLine(string.Format("Q,p = {0} kW", o.Qp));
                file.WriteLine(string.Format("Q,w = {0} kW", o.Qw));
                file.WriteLine(string.Format("Q,s = {0} kW", o.Qs));
                file.WriteLine(string.Format("Q,str = {0} kW", o.Qstr));
                file.Flush();
                file.Close();
            }
        }
    }
}
