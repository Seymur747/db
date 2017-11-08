using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
       
    {
        public int say = 0;
        Elaqe isde = new Elaqe();
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in isde.list)
            {
                dtgr.Rows.Add(item);
                dtgr.Hide();

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {



            dtgr.Show();
            
           

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            dtgr.Rows.Add("  ", "  ", "  ", "  ");
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        //                                    MessageBox.Show(dtgr.Rows[1].Cells[2].Value.ToString());
      
        }
    }
    public class Elaqe {

        public string Link;
        public SqlCommand command;
        public SqlConnection connection;
        public string cmdText;

        public List<string[]> list;

        public Elaqe()
        {

            Link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Seymur\Documents\Test1.mdf;Integrated Security=True;Connect Timeout=30";
            connection = new SqlConnection(Link);
            connection.Open();
            cmdText = "select * from Qafqaz";
            command = new SqlCommand(cmdText,connection);
            SqlDataReader reader = command.ExecuteReader();
            list = new List<string[]>();
            
            while  ( reader.Read()) {


                list.Add(new string[4]);

                list[list.Count - 1][0] = reader[0].ToString();
                list[list.Count - 1][1] = reader[1].ToString();
                list[list.Count - 1][2] = reader[2].ToString();
                list[list.Count - 1][3] = reader[3].ToString();






            }
           
          
            


     


            
        }
     


    }
}
