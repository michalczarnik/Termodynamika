using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Termodynamika.Models;

namespace Termodynamika.Solver
{
    static class SolverEngine
    {
        public static OutputDataModel Count(this InputDataModel input, int VgMultiplier = 1)
        {
            OutputDataModel output = new OutputDataModel();
            input.Vg = input.Vg * VgMultiplier;

            //Tu trzeba napisac solver

            return output;
        }
    }
}
