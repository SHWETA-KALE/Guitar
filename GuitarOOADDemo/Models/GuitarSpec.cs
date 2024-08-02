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
        private int numStrings;
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

        public int NumStrings { get; set; }



        public GuitarSpec()
        {

        }

        public GuitarSpec(GuiterBuilder builder, string model, int numstrings, GuiterType type, Wood backwood, Wood topwood)
        {
            Builder = builder;
            Model = model;
            NumStrings = numstrings;
            Type = type;
            Backwood = backwood;
            Topwood = topwood;


        }

        public int getNumstrings()
        {
            return NumStrings;
        }

        public bool Matches(GuitarSpec spec)
        {
            if (Builder != spec.Builder) return false;
            if (Model != spec.Model) return false;
            if (Type != spec.Type) return false;
            if (Backwood != spec.Backwood) return false;
            if (Topwood != spec.Topwood) return false;
            return true;


        }

    }
}
