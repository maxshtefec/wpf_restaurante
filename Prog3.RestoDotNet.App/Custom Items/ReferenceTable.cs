﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prog3.RestoDotNet.Model.Enums;

namespace Prog3.RestoDotNet.App.Custom_Items
{
    public class ReferenceTable : PictureBox
    {
        public TableShapeEnum Shape { get; set; }
    }
}