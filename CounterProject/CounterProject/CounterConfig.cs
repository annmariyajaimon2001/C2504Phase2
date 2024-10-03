using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CounterProject
{
    static class CounterConfig
    {
        public static CounterViewModel VueModel { get; set; }

        static CounterConfig()
        {
            VueModel = new CounterViewModel();
        }
    }
}
