using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class FormConnectionString : Form
    {
        public FormConnectionString()
        {
            InitializeComponent();
        }

        private void buttonOK_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxInputCS.Text) && !string.IsNullOrEmpty(textBoxInputCS.Text))
                {
                    StreamWriter streamWriter = new StreamWriter("connectionString.txt",false);
                    streamWriter.WriteLine(textBoxInputCS.Text);
                    streamWriter.Close();
                    MessageBox.Show("Строка подключения записана");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Недопустимое значение");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void FormConnectionString_Load(object sender, EventArgs e)
        {
            StreamReader streamReaderCS = new StreamReader("connectionString.txt");
            textBoxInputCS.Text = streamReaderCS.ReadLine();
            streamReaderCS.Close();
        }
    }
}
