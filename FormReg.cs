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
using System.IO;
using System.Globalization;

namespace Diplom
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }
        int mounthIndex = 0;
        int day = 0;
        string[] mounths = new string[12] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        int person_id;
        string dbName = "";
        string connectionString = "";
        public int ID
        {
            get
            {
                return person_id;
            }
            set
            {
                person_id = value;
            }
        }
        private void FormReg_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Today;
            label1.Text = mounths[dateTime.Month - 1];
            mounthIndex = 5;
            if (label1.Text == "Апрель" || label1.Text == "Июнь" || label1.Text == "Сентябрь" || label1.Text == "Ноябрь")
                button31.Visible = false;
            else if (label1.Text == "Февраль")
            {
                button29.Visible = false;
                button30.Visible = false;
                button31.Visible = false;
            }
            else
            {
                button29.Visible = true;
                button30.Visible = true;
                button31.Visible = true;
            }
        }

        private void buttonMove(object sender, MouseEventArgs e)
        {
            ButtonMove buttonMove = new ButtonMove();
            Button l = sender as Button;
            switch (l.TabIndex)
            {
                case 1:
                    buttonMove.ButtonForeColor(this.button1);
                    break;
                case 2:
                    buttonMove.ButtonForeColor(this.button2);
                    break;
                case 3:
                    buttonMove.ButtonForeColor(this.button3);
                    break;
                case 4:
                    buttonMove.ButtonForeColor(this.button4);
                    break;
                case 5:
                    buttonMove.ButtonForeColor(this.button5);
                    break;
                case 6:
                    buttonMove.ButtonForeColor(this.button6);
                    break;
                case 7:
                    buttonMove.ButtonForeColor(this.button7);
                    break;
                case 8:
                    buttonMove.ButtonForeColor(this.button8);
                    break;
                case 9:
                    buttonMove.ButtonForeColor(this.button9);
                    break;
                case 10:
                    buttonMove.ButtonForeColor(this.button10);
                    break;
                case 11:
                    buttonMove.ButtonForeColor(this.button11);
                    break;
                case 12:
                    buttonMove.ButtonForeColor(this.button12);
                    break;
                case 13:
                    buttonMove.ButtonForeColor(this.button13);
                    break;
                case 14:
                    buttonMove.ButtonForeColor(this.button14);
                    break;
                case 15:
                    buttonMove.ButtonForeColor(this.button15);
                    break;
                case 16:
                    buttonMove.ButtonForeColor(this.button16);
                    break;
                case 17:
                    buttonMove.ButtonForeColor(this.button17);
                    break;
                case 18:
                    buttonMove.ButtonForeColor(this.button18);
                    break;
                case 19:
                    buttonMove.ButtonForeColor(this.button19);
                    break;
                case 20:
                    buttonMove.ButtonForeColor(this.button20);
                    break;
                case 21:
                    buttonMove.ButtonForeColor(this.button21);
                    break;
                case 22:
                    buttonMove.ButtonForeColor(this.button22);
                    break;
                case 23:
                    buttonMove.ButtonForeColor(this.button23);
                    break;
                case 24:
                    buttonMove.ButtonForeColor(this.button24);
                    break;
                case 25:
                    buttonMove.ButtonForeColor(this.button25);
                    break;
                case 26:
                    buttonMove.ButtonForeColor(this.button26);
                    break;
                case 27:
                    buttonMove.ButtonForeColor(this.button27);
                    break;
                case 28:
                    buttonMove.ButtonForeColor(this.button28);
                    break;
                case 29:
                    buttonMove.ButtonForeColor(this.button29);
                    break;
                case 30:
                    buttonMove.ButtonForeColor(this.button30);
                    break;
                case 31:
                    buttonMove.ButtonForeColor(this.button31);
                    break;
            }
        }

        private void buttonPress(object sender, MouseEventArgs e)
        {
            ButtonPress buttonPress = new ButtonPress();
            Button l = sender as Button;
            switch (l.TabIndex)
            {
                case 1:
                    buttonPress.ButtonForeColor(this.button1);
                    break;
                case 2:
                    buttonPress.ButtonForeColor(this.button2);
                    break;
                case 3:
                    buttonPress.ButtonForeColor(this.button3);
                    break;
                case 4:
                    buttonPress.ButtonForeColor(this.button4);
                    break;
                case 5:
                    buttonPress.ButtonForeColor(this.button5);
                    break;
                case 6:
                    buttonPress.ButtonForeColor(this.button6);
                    break;
                case 7:
                    buttonPress.ButtonForeColor(this.button7);
                    break;
                case 8:
                    buttonPress.ButtonForeColor(this.button8);
                    break;
                case 9:
                    buttonPress.ButtonForeColor(this.button9);
                    break;
                case 10:
                    buttonPress.ButtonForeColor(this.button10);
                    break;
                case 11:
                    buttonPress.ButtonForeColor(this.button11);
                    break;
                case 12:
                    buttonPress.ButtonForeColor(this.button12);
                    break;
                case 13:
                    buttonPress.ButtonForeColor(this.button13);
                    break;
                case 14:
                    buttonPress.ButtonForeColor(this.button14);
                    break;
                case 15:
                    buttonPress.ButtonForeColor(this.button15);
                    break;
                case 16:
                    buttonPress.ButtonForeColor(this.button16);
                    break;
                case 17:
                    buttonPress.ButtonForeColor(this.button17);
                    break;
                case 18:
                    buttonPress.ButtonForeColor(this.button18);
                    break;
                case 19:
                    buttonPress.ButtonForeColor(this.button19);
                    break;
                case 20:
                    buttonPress.ButtonForeColor(this.button20);
                    break;
                case 21:
                    buttonPress.ButtonForeColor(this.button21);
                    break;
                case 22:
                    buttonPress.ButtonForeColor(this.button22);
                    break;
                case 23:
                    buttonPress.ButtonForeColor(this.button23);
                    break;
                case 24:
                    buttonPress.ButtonForeColor(this.button24);
                    break;
                case 25:
                    buttonPress.ButtonForeColor(this.button25);
                    break;
                case 26:
                    buttonPress.ButtonForeColor(this.button26);
                    break;
                case 27:
                    buttonPress.ButtonForeColor(this.button27);
                    break;
                case 28:
                    buttonPress.ButtonForeColor(this.button28);
                    break;
                case 29:
                    buttonPress.ButtonForeColor(this.button29);
                    break;
                case 30:
                    buttonPress.ButtonForeColor(this.button30);
                    break;
                case 31:
                    buttonPress.ButtonForeColor(this.button31);
                    break;
            }
        }

        private void buttonMouseLeave(object sender, EventArgs e)
        {
            ButtonLeave buttonLeave = new ButtonLeave();
            Button l = sender as Button;
            switch (l.TabIndex)
            {
                case 1:
                    buttonLeave.ButtonForeColor(this.button1);
                    break;
                case 2:
                    buttonLeave.ButtonForeColor(this.button2);
                    break;
                case 3:
                    buttonLeave.ButtonForeColor(this.button3);
                    break;
                case 4:
                    buttonLeave.ButtonForeColor(this.button4);
                    break;
                case 5:
                    buttonLeave.ButtonForeColor(this.button5);
                    break;
                case 6:
                    buttonLeave.ButtonForeColor(this.button6);
                    break;
                case 7:
                    buttonLeave.ButtonForeColor(this.button7);
                    break;
                case 8:
                    buttonLeave.ButtonForeColor(this.button8);
                    break;
                case 9:
                    buttonLeave.ButtonForeColor(this.button9);
                    break;
                case 10:
                    buttonLeave.ButtonForeColor(this.button10);
                    break;
                case 11:
                    buttonLeave.ButtonForeColor(this.button11);
                    break;
                case 12:
                    buttonLeave.ButtonForeColor(this.button12);
                    break;
                case 13:
                    buttonLeave.ButtonForeColor(this.button13);
                    break;
                case 14:
                    buttonLeave.ButtonForeColor(this.button14);
                    break;
                case 15:
                    buttonLeave.ButtonForeColor(this.button15);
                    break;
                case 16:
                    buttonLeave.ButtonForeColor(this.button16);
                    break;
                case 17:
                    buttonLeave.ButtonForeColor(this.button17);
                    break;
                case 18:
                    buttonLeave.ButtonForeColor(this.button18);
                    break;
                case 19:
                    buttonLeave.ButtonForeColor(this.button19);
                    break;
                case 20:
                    buttonLeave.ButtonForeColor(this.button20);
                    break;
                case 21:
                    buttonLeave.ButtonForeColor(this.button21);
                    break;
                case 22:
                    buttonLeave.ButtonForeColor(this.button22);
                    break;
                case 23:
                    buttonLeave.ButtonForeColor(this.button23);
                    break;
                case 24:
                    buttonLeave.ButtonForeColor(this.button24);
                    break;
                case 25:
                    buttonLeave.ButtonForeColor(this.button25);
                    break;
                case 26:
                    buttonLeave.ButtonForeColor(this.button26);
                    break;
                case 27:
                    buttonLeave.ButtonForeColor(this.button27);
                    break;
                case 28:
                    buttonLeave.ButtonForeColor(this.button28);
                    break;
                case 29:
                    buttonLeave.ButtonForeColor(this.button29);
                    break;
                case 30:
                    buttonLeave.ButtonForeColor(this.button30);
                    break;
                case 31:
                    buttonLeave.ButtonForeColor(this.button31);
                    break;
            }
        }

        private async void buttonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.TabIndex)
            {
                case 1:
                    day = Convert.ToInt32(button1.Text);
                    break;
                case 2:
                    day = Convert.ToInt32(button2.Text);
                    break;
                case 3:
                    day = Convert.ToInt32(button3.Text);
                    break;
                case 4:
                    day = Convert.ToInt32(button4.Text);
                    break;
                case 5:
                    day = Convert.ToInt32(button5.Text);
                    break;
                case 6:
                    day = Convert.ToInt32(button6.Text);
                    break;
                case 7:
                    day = Convert.ToInt32(button7.Text);
                    break;
                case 8:
                    day = Convert.ToInt32(button8.Text);
                    break;
                case 9:
                    day = Convert.ToInt32(button9.Text);
                    break;
                case 10:
                    day = Convert.ToInt32(button10.Text);
                    break;
                case 11:
                    day = Convert.ToInt32(button11.Text);
                    break;
                case 12:
                    day = Convert.ToInt32(button12.Text);
                    break;
                case 13:
                    day = Convert.ToInt32(button13.Text);
                    break;
                case 14:
                    day = Convert.ToInt32(button14.Text);
                    break;
                case 15:
                    day = Convert.ToInt32(button15.Text);
                    break;
                case 16:
                    day = Convert.ToInt32(button16.Text);
                    break;
                case 17:
                    day = Convert.ToInt32(button17.Text);
                    break;
                case 18:
                    day = Convert.ToInt32(button18.Text);
                    break;
                case 19:
                    day = Convert.ToInt32(button19.Text);
                    break;
                case 20:
                    day = Convert.ToInt32(button20.Text);
                    break;
                case 21:
                    day = Convert.ToInt32(button21.Text);
                    break;
                case 22:
                    day = Convert.ToInt32(button22.Text);
                    break;
                case 23:
                    day = Convert.ToInt32(button23.Text);
                    break;
                case 24:
                    day = Convert.ToInt32(button24.Text);
                    break;
                case 25:
                    day = Convert.ToInt32(button25.Text);
                    break;
                case 26:
                    day = Convert.ToInt32(button26.Text);
                    break;
                case 27:
                    day = Convert.ToInt32(button27.Text);
                    break;
                case 28:
                    day = Convert.ToInt32(button28.Text);
                    break;
                case 29:
                    day = Convert.ToInt32(button29.Text);
                    break;
                case 30:
                    day = Convert.ToInt32(button30.Text);
                    break;
                case 31:
                    day = Convert.ToInt32(button31.Text);
                    break;
            }
            domainUpDown1.Enabled = true;
            domainUpDown2.Enabled = true;
            domainUpDown3.Enabled = true;
            domainUpDown4.Enabled = true;
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
                    await sqlConnection.OpenAsync();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = $"SELECT Clients.[Имя], Clients.[Фамилия], Registration.[Дата записи], Registration.[Время окончания] FROM Registration " +
                    $"FULL JOIN Clients ON Registration.[id_клиента] = Clients.[id] WHERE MONTH(Registration.[Дата записи]) IN ({mounthIndex + 1})";
                    SqlDataReader dataReader = null;
                    dataReader = await sqlCommand.ExecuteReaderAsync();
                    while (await dataReader.ReadAsync())
                    {
                        listBox1.Items.Add(Convert.ToString(dataReader["Имя"]) + "  " + Convert.ToString(dataReader["Фамилия"]) + "  " + Convert.ToString(dataReader["Дата записи"]) + " - " + Convert.ToString(dataReader["Время окончания"]));
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            mounthIndex++;
            if (mounthIndex > 11)
                mounthIndex = 0;
            label1.Text = mounths[mounthIndex];
            if (label1.Text == "Апрель" || label1.Text == "Июнь" || label1.Text == "Сентябрь" || label1.Text == "Ноябрь")
                button31.Visible = false;
            else if (label1.Text == "Февраль")
            {
                button29.Visible = false;
                button30.Visible = false;
                button31.Visible = false;
            }
            else
            {
                button29.Visible = true;
                button30.Visible = true;
                button31.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            mounthIndex--;
            if (mounthIndex < 0)
                mounthIndex = 11;
            label1.Text = mounths[mounthIndex];
            if (label1.Text == "Апрель" || label1.Text == "Июнь" || label1.Text == "Сентябрь" || label1.Text == "Ноябрь")
                button31.Visible = false;
            else if (label1.Text == "Февраль")
            {
                button29.Visible = false;
                button30.Visible = false;
                button31.Visible = false;
            }
            else
            {
                button29.Visible = true;
                button30.Visible = true;
                button31.Visible = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(domainUpDown1.Text) && !string.IsNullOrWhiteSpace(domainUpDown2.Text) &&
                !string.IsNullOrEmpty(domainUpDown3.Text) && !string.IsNullOrWhiteSpace(domainUpDown4.Text))
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
                        string dateBegin = $"{day}.{mounthIndex + 1}.2021 {domainUpDown1.Text}:{domainUpDown2.Text}:00";
                        DateTime dateTimeBegin = DateTime.ParseExact(dateBegin, "dd.mm.yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                        string dateEnd = $"{day}.{mounthIndex + 1}.2021 {domainUpDown3.Text}:{domainUpDown4.Text}:00";
                        DateTime dateTimeEnd = DateTime.ParseExact(dateEnd, "dd.mm.yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                        SqlConnection sqlConnection = new SqlConnection($@"Data Source={connectionString};AttachDbFilename={dbName};Integrated Security=true");
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = $"INSERT INTO Registration ([Дата записи], [Время окончания], [id_клиента])" +
                        $"VALUES(@DateBegin, @DateEnd, @id_client";
                        sqlCommand.Parameters.AddWithValue("DateBegin", dateTimeBegin);
                        sqlCommand.Parameters.AddWithValue("DateEnd", dateTimeEnd);
                        sqlCommand.Parameters.AddWithValue("id_client", person_id);
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Неверный формат даты!", "Brazers Data Base", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
