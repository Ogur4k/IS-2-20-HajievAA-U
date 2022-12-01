using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_2_20_HajievAA_U
{
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }
        ///////////////////////////////////////////////////////
        public class Connect
        {
            string strConnect;
            MySqlConnection Conn;
            public MySqlConnection Connection()
            {
                Conn = new MySqlConnection(strConnect);
                return Conn;
            }
            public string RCon()
            {
                return strConnect;
            }
            public Connect(string connect)
            {
                strConnect = connect;
            }
        }
        ///////////////////////////////////////////////////////
        MySqlConnection сon;
        Connect connect = new Connect("server=chuc.caseum.ru;port=33333;username=st_2_20_28;password=29461060;database=is_2_20_st28_KURS");
        DataTable dtable = new DataTable();
        MySqlDataAdapter medtable = new MySqlDataAdapter();
        BindingSource bs = new BindingSource();
        public void Infomation()
        {
            dtable.Clear();
            string sqlI = "SELECT Client.ID AS `Код`, Client.Full_name AS `Имя`, Client.Phone AS `Телефон`, Client.Mail AS `Почта`, FROM Client FULL JOIN Main ON Client.ID = Main.ID_client"; 
            сon.Open();

            medtable.SelectCommand = new MySqlCommand(sqlI, сon);
            medtable.Fill(dtable);

            bs.DataSource = dtable;

            dataGridView1.DataSource = bs;
            сon.Close();

            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;


            dataGridView1.Columns[0].FillWeight = 12;
            dataGridView1.Columns[1].FillWeight = 12;
            dataGridView1.Columns[2].FillWeight = 12;
            dataGridView1.Columns[3].FillWeight = 12;

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.RowHeadersVisible = false;

            dataGridView1.ColumnHeadersVisible = true;
        }

        private void Ex3_Load(object sender, EventArgs e)
        {
            сon = connect.Connection();
            Infomation();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            сon.Open();
            string i1 = "";
            string i2 = "";
            string i3 = "";
            string i4 = "";
            string sql = $"SELECT Client.ID AS `Код`, Client.Full_name AS `Имя`, Client.Phone AS `Телефон`, Client.Mail AS `Почта`, FROM Client FULL JOIN Main ON Client.ID = Main.ID_client" + id;
            MySqlCommand cmd = new MySqlCommand(sql, сon);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                i1 = reader[0].ToString();
                i2 = reader[1].ToString();
                i3 = reader[2].ToString();
                i4 = reader[3].ToString();
            }
            reader.Close();
            label1.Text = $"Код: " + i1 + "\n" + "Имя: " + i2 + "\n" + "Телефон: " + i3 + "\n" + "Почта: " + i4;
            сon.Close();
        }
    }
}
