using System;

namespace Tennista.Model
{
    /// <summary>
    /// Class model for a tennis player.
    /// </summary>
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PreferredHandType { get; set; }
        public string BackhandType { get; set; }
        public string PlaceOfBirth { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
