﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RigCAT.NET
{
    public sealed class RadioFactory
    {
        public IRadio GetRadio(RadioModel model, RadioConnectionSettings connectionSettings)
        {
            switch (model)
            {
                case RadioModel.ElecraftK3:
                    return new Elecraft.K3(connectionSettings);
                default:
                    throw new UnsupportedRadioException();
            }
        }
    }
}
