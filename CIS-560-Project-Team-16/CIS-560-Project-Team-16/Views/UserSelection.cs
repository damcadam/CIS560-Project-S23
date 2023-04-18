using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_560_Project_Team_16
{
    /// <summary>
    /// GUI for selecting an existing user or creating a new one. Each account can have many users
    /// like Netflix. May be a user for each member in a family. Each user has their own unique 
    /// watchlist
    /// </summary>
    public partial class UserSelection : Form
    {

        public UserSelection()
        {
            InitializeComponent();
        }
    }
}
