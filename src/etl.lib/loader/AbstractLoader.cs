﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using etl.lib.util;

namespace etl.lib.loader
{
    public class AbstractLoader : ILoader
    {
        protected Arguments arguments = null;

        public virtual void load( Arguments arg, DataTable data)
        {
            this.arguments = arg;
        }
    }
}