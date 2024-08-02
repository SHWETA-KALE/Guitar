using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GuitarOOADDemo.Models.Enums;

namespace GuitarSpecOOADDemo.Models
{
    internal class GuitarSpec
    {
        public GuiterBuilder Builder
        {
            get; set;
        }

        public string Model
        {
            get; set;
        }

        public GuiterType Type
        {
            get; set;
        }

        public Wood Backwood
        {
            get; set;
        }

        public Wood Topwood
        {
            get; set;
        }

        public GuitarSpec()
        {

        }

        public GuitarSpec( GuiterBuilder builder, string model, GuiterType type, Wood backwood, Wood topwood)
        {

            Builder = builder;
            Model = model;
            Type = type;
            Backwood = backwood;
            Topwood = topwood;

        }

    }
}
