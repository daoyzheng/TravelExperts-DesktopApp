using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntites {
    public class Agent {
        public enum AgtPos {junior, intermediate, senior}
        public int AgentId { get; set; }
        public string AgtFirstName { get; set; }
        public string AgtMiddleInitial { get; set; }
        public string AgtLastName { get; set; }
        public string AgtBusPhone { get; set; }
        public string AgtEmail { get; set; }
        public string AgtPostion { get; set; }
        public int? AgencyId { get; set; }
        public string AgtUserName { get; set; }
        public byte[] password { get; set; }
        public AgtPos Position { get; set; }

    }
}
