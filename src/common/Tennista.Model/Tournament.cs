using System;
using System.Collections.Generic;
using System.Text;

namespace Tennista.Model
{
    /// <summary>
    /// Class model for a tennis tournament.
    /// </summary>
    public class Tournament
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string SurfaceType { get; set; }
        public float Points { get; set; }
    }
}
