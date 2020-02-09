using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace StarChart.Models
{
    public class CelestialObject
    {
        public int id;
        [Required]
        public string name;
        public int? OrbitedObjectId;
        [NotMapped]
        public List<CelestialObject> Satellites;
        public TimeSpan OrbitalPeriod;

        public CelestialObject()
        {
            
        }
    }
}
