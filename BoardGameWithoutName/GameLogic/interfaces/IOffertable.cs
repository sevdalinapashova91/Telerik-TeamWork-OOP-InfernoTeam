﻿namespace GameLogic.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GameLogic.Fields.Institutions;

    public interface IOffertable
    {
        Offer MakeOffer();
    }
}
