using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Policy;
using LiveCharts;
using System.Windows.Forms.DataVisualization.Charting;

namespace csvFiles
{
    public partial class Form1 : Form
    {
        public struct User
        {
          
            public string name;
            public int age;
          

            public User( string _name, int _age)
            {
               
                name = _name;
                age = _age;
                
            }
        }

        List<User> users = new List<User>();

        public double John { get; }
        public double Mark { get; }
        public double Tim { get; }
        public double Maxim { get; }



        public Form1()
        {

            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            users.Add(new User("Mark", 16));
            users.Add(new User("John", 21));
            users.Add(new User("Tim", 12));
            users.Add(new User("Maxim", 18));

            DataTable table = new DataTable();
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("Age",typeof(int));

            for (int i = 0; i < users.Count; i++)
            {
                table.Rows.Add(users[i].name, users[i].age);
            }

            dataGridView1.DataSource = table;

           
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].XValueMember = "Age";
            chart1.Series["Series1"].XValueMember = "Name";
            chart1.DataSource = dataGridView1;
        }
    }
}
