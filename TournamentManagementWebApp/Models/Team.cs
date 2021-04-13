using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TournamentManagementWebApp.Models
{
    public class Team
    {
        public int Id { get; set; }
        [Display(Name = "Team Number")]
        public string TeamNumber { get; set; }
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }
        [Display(Name = "Primary Number")]
        public string PrimaryNumber { get; set; }
        [Display(Name = "Secondary Number")]
        public string SecondaryNumber { get; set; }
        [Display(Name = "Person Name")]
        public string PersonName { get; set; }
        [Display(Name = "Match Slot")]
        public string MatchSlot { get; set; }
        [Display(Name = "Match Date & Time")]
        public string MatchDate { get; set; }
        [Display(Name = "WhatsApp Group")]
        public string WhatsAppGroup { get; set; }
    }
}

