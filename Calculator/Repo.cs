using Calculator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Repo : IRepo
    {
        public List<int> GetValues()
        {
            return new List<int>
            {
                1,
                2,
                3,
                4,
                5
            };
        }
    }
}
