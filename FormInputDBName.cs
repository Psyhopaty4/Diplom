using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Diplom
{
    public partial class FormInputDBName : Form
    {
        public FormInputDBName()
        {
            InitializeComponent();
        }

        private void buttonOK_MouseUp(object sender, MouseEventArgs e)
        {
            FormOpenDB formOpenDB = new FormOpenDB();
            string nameDB = textBoxInputDBName.Text;
            if (!string.IsNullOrEmpty(nameDB) && !string.IsNullOrWhiteSpace(nameDB))
            {
                string queryCreateDB;
                string queryCreateTable;
                StreamReader streamReaderCS = new StreamReader("connectionString.txt");
                string connectionString = streamReaderCS.ReadLine();
                streamReaderCS.Close();
                SqlConnection sqlConnection = new SqlConnection($@"Server={connectionString};Integrated security=SSPI;database=master");
                queryCreateDB = $"CREATE DATABASE {nameDB}";
                /*queryCreateTable = "CREATE TABLE dbo.Clients"  +
                "(ClientID int PRIMARY KEY NOT NULL AUTO_INCREMENT," +
                "Name varchar(max) NOT NULL," +
                "LName varchar(max) NOT NULL," +
                "Patronymic varchar(max) NULL," +
                "Male varchar(25) NOT NULL," +
                "DateofBorn Date NOT NULL," +
                "RegistrationID int NULL,";*/
                SqlCommand sqlCommand = new SqlCommand(queryCreateDB, sqlConnection);
                try
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    DialogResult dialogResult = MessageBox.Show("База данных создана успешно!", "Brazers Data Base", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        /*StreamWriter streamWriter = new StreamWriter("DBName.txt", false);
                        streamWriter.WriteLine(Path.GetFullPath(nameDB));
                        streamWriter.Close();*/
                        this.Close();
                        /*formOpenDB.Show();*/
                    }
                    /*else
                        this.Close();*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Brazers Data Base", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    if (sqlConnection.State == ConnectionState.Open)
                        sqlConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Некорректное имя базы данных!", "Brazers Data Base", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMove(object sender, MouseEventArgs e)
        {
            ButtonMove buttonMove = new ButtonMove();
            Button l = sender as Button;
            switch (l.TabIndex)
            {
                case 2:
                    buttonMove.ButtonForeColor(this.buttonOK);
                    break;
                case 3:
                    buttonMove.ButtonForeColor(this.buttonCancel);
                    break;
            }
        }

        private void buttonPress(object sender, MouseEventArgs e)
        {
            ButtonPress buttonPress = new ButtonPress();
            Button l = sender as Button;
            switch (l.TabIndex)
            {
                case 2:
                    buttonPress.ButtonForeColor(this.buttonOK);
                    break;
                case 3:
                    buttonPress.ButtonForeColor(this.buttonCancel);
                    break;
            }
        }

        private void buttonLeave(object sender, EventArgs e)
        {
            ButtonLeave buttonLeave = new ButtonLeave();
            Button l = sender as Button;
            switch (l.TabIndex)
            {
                case 2:
                    buttonLeave.ButtonForeColor(this.buttonOK);
                    break;
                case 3:
                    buttonLeave.ButtonForeColor(this.buttonCancel);
                    break;
            }
        }

        private void buttonCancel_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void textBoxInputDBName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {

            }
            else
                e.Handled = true;
        }
    }
}
