using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System.IO.Ports;

namespace Diplom
{
    public partial class FormOpenDB : Form
    {
        public FormOpenDB()
        {
            InitializeComponent();
        }
        static SerialPort pt;
        BindingSource bind = new BindingSource();
        DataSet dataSet = new DataSet();
        SqlDataAdapter sqlData = new SqlDataAdapter();
        string dbName = "";
        string connectionString = "";

        private void FormOpenDB_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader streamReaderDB = new StreamReader("DBName.txt", false);
                dbName = streamReaderDB.ReadLine();
                streamReaderDB.Close();
                StreamReader streamReaderCS = new StreamReader("connectionString.txt");
                connectionString = streamReaderCS.ReadLine();
                streamReaderCS.Close();
                if (!string.IsNullOrEmpty(dbName) && !string.IsNullOrWhiteSpace(dbName))
                {
                    SqlConnection sqlConnection = new SqlConnection($@"Data Source={connectionString};AttachDbFilename={dbName};Integrated Security=true");
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT * FROM Clients";
                    sqlData = new SqlDataAdapter(sqlCommand);
                    sqlData.Fill(dataSet);
                    bind.DataSource = dataSet.Tables[0];
                    dataGridView1.DataSource = bind;
                    sqlConnection.Close();
                }
                else
                {
                    MessageBox.Show("Базы данных не существует!", "Brazers Data Base", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            label1.Text = dbName;
        }

        private void updateToolStripButton1_Click(object sender, EventArgs e)
        {
            UpDate();
        }

        private void UpDate ()
        {
            try
            {
                string dbName;
                StreamReader streamReaderDB = new StreamReader("DBName.txt", false);
                dbName = streamReaderDB.ReadLine();
                streamReaderDB.Close();
                StreamReader streamReaderCS = new StreamReader("connectionString.txt");
                string connectionString = streamReaderCS.ReadLine();
                streamReaderCS.Close();
                if (!string.IsNullOrEmpty(dbName) && !string.IsNullOrWhiteSpace(dbName))
                {
                    SqlConnection sqlConnection = new SqlConnection($@"Data Source={connectionString};AttachDbFilename={dbName};Integrated Security=true");
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT * FROM Clients";
                    SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                    DataSet dataSet = new DataSet();
                    sqlData.Fill(dataSet);
                    bind.DataSource = dataSet.Tables[0];
                    dataGridView1.DataSource = bind;
                    sqlConnection.Close();
                }
                else
                {
                    MessageBox.Show("Базы данных не существует!", "Brazers Data Base", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void отАДоЯToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bind.Sort = "[Фамилия] ASC";
        }

        private void возрастToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bind.Sort = "[Дата рождения] ASC";
        }

        private void отменитьСортировкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bind.Sort = "[id] ASC";
        }

        private void отменитьФильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bind.RemoveFilter();
        }

        private void мужчиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bind.Filter = "[пол] LIKE 'мужской'";
        }

        private void женщиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bind.Filter = "[пол] LIKE 'женский'";
        }

        private void от18ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime Date = DateTime.Now;
            Date = Date.AddYears(-18);
            bind.Filter = $"[дата рождения] <= '{Date}'";
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            labelTextChange();
        }

        private void saveToolStripButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void labelTextChange()
        {
            label1.Text = $"{dbName}*";
        }

        private void printToolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                var dataGridView = new DataGridView { Parent = this, Dock = DockStyle.Fill, DataSource = bind };
                var printDocument = new PrintDocument();
                printDocument.PrintPage += (s, ex) =>
                {
                    var bmp = new Bitmap(dataGridView.Width, dataGridView.Height);
                    dataGridView.DrawToBitmap(bmp, dataGridView.ClientRectangle);
                    ex.Graphics.DrawImage(bmp, new Point(100, 100));
                };
                printDocument.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchToolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(searchToolStripTextBox1.Text) && !string.IsNullOrWhiteSpace(searchToolStripTextBox1.Text))
                bind.Filter = $"[имя] LIKE '{searchToolStripTextBox1.Text}%' OR [фамилия] LIKE '{searchToolStripTextBox1.Text}%' OR [отчество] LIKE '{searchToolStripTextBox1.Text}%'";
            else
                bind.RemoveFilter();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sms.ru/?panel=mass&subpanel=mass&add=1");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.Rows != null)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                FormReg formReg = new FormReg();
                formReg.ID = Convert.ToInt32(selectedRow.Cells["id"].Value);
                formReg.Show();
            }
            else
            {
                MessageBox.Show("Клиент не выбран!");
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
