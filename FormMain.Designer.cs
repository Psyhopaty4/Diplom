namespace Diplom
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelChangeDB = new System.Windows.Forms.Label();
            this.labelCreateDB = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelContinue = new System.Windows.Forms.Label();
            this.labelDeleteDB = new System.Windows.Forms.Label();
            this.labelStringConnection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelChangeDB
            // 
            this.labelChangeDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChangeDB.BackColor = System.Drawing.Color.Transparent;
            this.labelChangeDB.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelChangeDB.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeDB.ForeColor = System.Drawing.Color.White;
            this.labelChangeDB.Location = new System.Drawing.Point(186, 373);
            this.labelChangeDB.MinimumSize = new System.Drawing.Size(600, 70);
            this.labelChangeDB.Name = "labelChangeDB";
            this.labelChangeDB.Size = new System.Drawing.Size(600, 70);
            this.labelChangeDB.TabIndex = 0;
            this.labelChangeDB.Tag = "0";
            this.labelChangeDB.Text = "Выбрать";
            this.labelChangeDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelChangeDB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelMouseDown);
            this.labelChangeDB.MouseLeave += new System.EventHandler(this.labelMouseLeave);
            this.labelChangeDB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelMouseMove);
            this.labelChangeDB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelChangeDB_MouseUp);
            // 
            // labelCreateDB
            // 
            this.labelCreateDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCreateDB.BackColor = System.Drawing.Color.Transparent;
            this.labelCreateDB.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelCreateDB.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateDB.ForeColor = System.Drawing.Color.White;
            this.labelCreateDB.Location = new System.Drawing.Point(201, 454);
            this.labelCreateDB.MinimumSize = new System.Drawing.Size(570, 70);
            this.labelCreateDB.Name = "labelCreateDB";
            this.labelCreateDB.Size = new System.Drawing.Size(570, 70);
            this.labelCreateDB.TabIndex = 1;
            this.labelCreateDB.Tag = "1";
            this.labelCreateDB.Text = "Создать";
            this.labelCreateDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCreateDB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelMouseDown);
            this.labelCreateDB.MouseLeave += new System.EventHandler(this.labelMouseLeave);
            this.labelCreateDB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelMouseMove);
            this.labelCreateDB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelCreateDB_MouseUp);
            // 
            // labelExit
            // 
            this.labelExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelExit.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.White;
            this.labelExit.Location = new System.Drawing.Point(376, 695);
            this.labelExit.MinimumSize = new System.Drawing.Size(220, 70);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(220, 70);
            this.labelExit.TabIndex = 2;
            this.labelExit.Tag = "2";
            this.labelExit.Text = "Выход";
            this.labelExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelMouseDown);
            this.labelExit.MouseLeave += new System.EventHandler(this.labelMouseLeave);
            this.labelExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelMouseMove);
            this.labelExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelExit_MouseUp);
            // 
            // labelContinue
            // 
            this.labelContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelContinue.BackColor = System.Drawing.Color.Transparent;
            this.labelContinue.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelContinue.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContinue.ForeColor = System.Drawing.Color.White;
            this.labelContinue.Location = new System.Drawing.Point(186, 293);
            this.labelContinue.MinimumSize = new System.Drawing.Size(600, 70);
            this.labelContinue.Name = "labelContinue";
            this.labelContinue.Size = new System.Drawing.Size(600, 70);
            this.labelContinue.TabIndex = 3;
            this.labelContinue.Tag = "0";
            this.labelContinue.Text = "Продолжить";
            this.labelContinue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelContinue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelMouseDown);
            this.labelContinue.MouseLeave += new System.EventHandler(this.labelMouseLeave);
            this.labelContinue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelMouseMove);
            this.labelContinue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelOpenDB_MouseUp);
            // 
            // labelDeleteDB
            // 
            this.labelDeleteDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDeleteDB.BackColor = System.Drawing.Color.Transparent;
            this.labelDeleteDB.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelDeleteDB.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteDB.ForeColor = System.Drawing.Color.White;
            this.labelDeleteDB.Location = new System.Drawing.Point(186, 535);
            this.labelDeleteDB.MinimumSize = new System.Drawing.Size(600, 70);
            this.labelDeleteDB.Name = "labelDeleteDB";
            this.labelDeleteDB.Size = new System.Drawing.Size(600, 70);
            this.labelDeleteDB.TabIndex = 4;
            this.labelDeleteDB.Tag = "0";
            this.labelDeleteDB.Text = "Удалить";
            this.labelDeleteDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDeleteDB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelMouseDown);
            this.labelDeleteDB.MouseLeave += new System.EventHandler(this.labelMouseLeave);
            this.labelDeleteDB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelMouseMove);
            this.labelDeleteDB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelDeleteDB_MouseUp);
            // 
            // labelStringConnection
            // 
            this.labelStringConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStringConnection.BackColor = System.Drawing.Color.Transparent;
            this.labelStringConnection.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelStringConnection.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStringConnection.ForeColor = System.Drawing.Color.White;
            this.labelStringConnection.Location = new System.Drawing.Point(186, 616);
            this.labelStringConnection.MinimumSize = new System.Drawing.Size(600, 70);
            this.labelStringConnection.Name = "labelStringConnection";
            this.labelStringConnection.Size = new System.Drawing.Size(600, 70);
            this.labelStringConnection.TabIndex = 5;
            this.labelStringConnection.Tag = "0";
            this.labelStringConnection.Text = "Строка подключения";
            this.labelStringConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStringConnection.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelMouseDown);
            this.labelStringConnection.MouseLeave += new System.EventHandler(this.labelMouseLeave);
            this.labelStringConnection.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelMouseMove);
            this.labelStringConnection.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelStringConnection_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 784);
            this.ControlBox = false;
            this.Controls.Add(this.labelStringConnection);
            this.Controls.Add(this.labelDeleteDB);
            this.Controls.Add(this.labelContinue);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelCreateDB);
            this.Controls.Add(this.labelChangeDB);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 530);
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelChangeDB;
        private System.Windows.Forms.Label labelCreateDB;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelContinue;
        private System.Windows.Forms.Label labelDeleteDB;
        private System.Windows.Forms.Label labelStringConnection;
    }
}

