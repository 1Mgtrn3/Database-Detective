﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModelActualizer
{
    class ProcessControl
    {
        public ProcessControl()
        {
            


        }

        public void StartProcessing() {
            var proc = new PackageProcessor();
            proc.startProcessing();


        }

    }
}
