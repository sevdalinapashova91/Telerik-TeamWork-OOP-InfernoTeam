﻿namespace GameLogic.Fields.Institutions
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GameLogic.Map;

    public class InsuranceAgency : Field
    {
        public InsuranceAgency(string name, Color color, int row, int col)
            : base(name, color, row, col)
        {
        }
    }
}
