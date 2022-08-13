using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerSystemProject.Entities
{
    internal class Campaign
    {
        public int Id { get; set; }
        public string CampaignTitle { get; set; }
        public string  CampaignDetail { get; set; }
        public DateTime CampaingEndTime { get; set; }

    }
}
