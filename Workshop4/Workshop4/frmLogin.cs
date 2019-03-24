using ClassEntites;
using DBAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop4 {
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e) {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            List<Agent> agents = AgentDB.GetAllAgents();

            // Find if user first name and last name is in database
            var agent = agents.SingleOrDefault(a => a.AgtFirstName.ToLower() == firstName.ToLower()
                                               && a.AgtLastName.ToLower() == lastName.ToLower());

            if (agent != null) { // if found a match
                
            }
        }
    }
}
