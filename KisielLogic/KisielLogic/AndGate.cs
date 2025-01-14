﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisielLogic
{
    class AndGate : Gate2Input
    {

        public AndGate(string pName) : base(pName, "AndGate")
        {

        }

        public override void Update()
        {
            bool state1 = inputGates[0].State;
            bool state2 = inputGates[1].State;

            state = state1 && state2;

            UpdateConnected();
        }
    }
}
