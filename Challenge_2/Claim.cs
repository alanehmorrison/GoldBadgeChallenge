using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class Claim
    {
        public Claim(int id, string type, string description, int amount, DateTime incident, DateTime report)
        {

            Id = id;
            Type = type;
            Description = description;
            Amount = amount;
            Incident = incident;
            Report = report; 

        }
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public DateTime Incident { get; set; }
        public DateTime Report { get; set; }
        public bool isValid => Incident.Subtract(Report).Days < 30;
    }
}
