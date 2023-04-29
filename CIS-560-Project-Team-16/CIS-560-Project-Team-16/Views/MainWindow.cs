using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CIS_560_Project_Team_16
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ShowMainWindow()
        {
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }


        //-----------Likely want to do something here, not sure what though----------------
        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDb;Initial Catalog=CIS560Project;Integrated Security=True";
            /*            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MovieDatabase.Directors", "Data Source=(localdb)\\MSSQLLocalDb;Initial Catalog=CIS560Project;Integrated Security=True");
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Directors");
                        dataGridView1.DataSource = ds;*/
            /*
                        using (SqlCeConnection c = new SqlCeConnection(connectionString))
                        {
                            c.Open();
                            // Step 2: Create new DataAdapter.
                            using (SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT * FROM Animals", c))
                            {
                                // Step 3: Use DataAdapter to fill DataTable.
                                DataTable t = new DataTable();
                                a.Fill(t);
                                // Step 4: Render data onto the screen.
                                dataGridView1.DataSource = t;
                            }
                        }*/

            var select = "SELECT * FROM MovieDatabase.Directors";
            var c = new SqlConnection(connectionString); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];


            /*string connectionString = "Data Source=(localdb)\\MSSQLLocalDb;Initial Catalog=CIS560Project;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Get all table names from the database
                DataTable schemaTable = connection.GetSchema("MovieDatabase.Directors");

                // Create a new DataTable to store table names
                DataTable tableNames = new DataTable();
                tableNames.Columns.Add("Directors");

                //Add table names to the DataTable
                foreach (DataRow row in schemaTable.Rows)
                {
                    tableNames.Rows.Add(row["Movies"]);
                }

                // Set the DataGridView's data source to the table names DataTable
                dataGridView1.DataSource = tableNames;
            }*/
        }
    }
}
