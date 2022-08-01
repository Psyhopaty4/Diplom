using System;
using System.IO;
using System.Windows.Forms;

namespace Diplom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.AutoPopDelay = 5000;
            toolTip.SetToolTip(this.labelContinue, "Продолжить работу с базой данных");
            toolTip.SetToolTip(this.labelChangeDB, "Выбрать существующую базу данных");
            toolTip.SetToolTip(this.labelCreateDB, "Создание новой базы данных");
            toolTip.SetToolTip(this.labelDeleteDB, "Удаление базы данных");
            toolTip.SetToolTip(this.labelExit, "Закрытие программы");
            toolTip.SetToolTip(this.labelStringConnection, "Определение строки подключения");
        }

        private void labelMouseMove(object sender, MouseEventArgs e)
        {
            LabelMove labelMove = new LabelMove();
            Label l = sender as Label;
            switch (l.TabIndex)
            {
                case 0:
                    labelMove.LabelForeColor(this.labelChangeDB);
                    break;
                case 1:
                    labelMove.LabelForeColor(this.labelCreateDB);
                    break;
                case 2:
                    labelMove.LabelForeColor(this.labelExit);
                    break;
                case 3:
                    labelMove.LabelForeColor(this.labelContinue);
                    break;
                case 4:
                    labelMove.LabelForeColor(this.labelDeleteDB);
                    break;
                case 5:
                    labelMove.LabelForeColor(this.labelStringConnection);
                    break;
            }
        }

        private void labelMouseLeave(object sender, EventArgs e)
        {
            LabelLeave labelLeave = new LabelLeave();
            Label l = sender as Label;
            switch (l.TabIndex)
            {
                case 0:
                    labelLeave.LabelForeColor(this.labelChangeDB);
                    break;
                case 1:
                    labelLeave.LabelForeColor(this.labelCreateDB);
                    break;
                case 2:
                    labelLeave.LabelForeColor(this.labelExit);
                    break;
                case 3:
                    labelLeave.LabelForeColor(this.labelContinue);
                    break;
                case 4:
                    labelLeave.LabelForeColor(this.labelDeleteDB);
                    break;
                case 5:
                    labelLeave.LabelForeColor(this.labelStringConnection);
                    break;
            }
        }

        private void labelMouseDown(object sender, MouseEventArgs e)
        {
            LabelPress labelPress = new LabelPress();
            Label l = sender as Label;
            switch (l.TabIndex)
            {
                case 0:
                    labelPress.LabelForeColor(this.labelChangeDB);
                    break;
                case 1:
                    labelPress.LabelForeColor(this.labelCreateDB);
                    break;
                case 2:
                    labelPress.LabelForeColor(this.labelExit);
                    break;
                case 3:
                    labelPress.LabelForeColor(this.labelContinue);
                    break;
                case 4:
                    labelPress.LabelForeColor(this.labelDeleteDB);
                    break;
                case 5:
                    labelPress.LabelForeColor(this.labelStringConnection);
                    break;
            }
        }

        private void labelOpenDB_MouseUp(object sender, MouseEventArgs e)
        {
            FormOpenDB formOpenDB = new FormOpenDB();
            formOpenDB.Show();
        }

        private void labelCreateDB_MouseUp(object sender, MouseEventArgs e)
        {
            FormInputDBName formInputDB = new FormInputDBName();
            formInputDB.Show();
        }

        private void labelExit_MouseUp(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void labelStringConnection_MouseUp(object sender, MouseEventArgs e)
        {
            FormConnectionString formConnection = new FormConnectionString();
            formConnection.Show();
        }

        private void labelChangeDB_MouseUp(object sender, MouseEventArgs e)
        {
            string fileName = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                FormOpenDB formOpenDB = new FormOpenDB();
                StreamWriter streamWriter = new StreamWriter("DBName.txt", false);
                streamWriter.WriteLine(fileName);
                streamWriter.Close();
                formOpenDB.Show();
            }
        }

        private void labelDeleteDB_MouseUp(object sender, MouseEventArgs e)
        {
            string fileName = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                File.Delete(fileName);
            }
        }
    }
}
