
namespace JustClick
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LabelJustClickTitle = new System.Windows.Forms.Label();
            this.LabelKoortinat = new System.Windows.Forms.Label();
            this.LabelKoordinatX = new System.Windows.Forms.Label();
            this.LabelKoordinatY = new System.Windows.Forms.Label();
            this.LabelWaitingTime = new System.Windows.Forms.Label();
            this.TextBoxKoordinatX = new System.Windows.Forms.TextBox();
            this.TextBoxKoordinatY = new System.Windows.Forms.TextBox();
            this.TextBoxWaitingTime = new System.Windows.Forms.TextBox();
            this.LabelStartStopButton = new System.Windows.Forms.Label();
            this.CheckListStartStopButton = new System.Windows.Forms.CheckedListBox();
            this.ButtonStartStop = new System.Windows.Forms.Button();
            this.Zamanlayici = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelJustClickTitle
            // 
            this.LabelJustClickTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelJustClickTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelJustClickTitle.Location = new System.Drawing.Point(35, 10);
            this.LabelJustClickTitle.Margin = new System.Windows.Forms.Padding(0);
            this.LabelJustClickTitle.Name = "LabelJustClickTitle";
            this.LabelJustClickTitle.Size = new System.Drawing.Size(200, 25);
            this.LabelJustClickTitle.TabIndex = 0;
            this.LabelJustClickTitle.Text = "Juct Left Click";
            this.LabelJustClickTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelKoortinat
            // 
            this.LabelKoortinat.AutoSize = true;
            this.LabelKoortinat.Location = new System.Drawing.Point(10, 50);
            this.LabelKoortinat.Margin = new System.Windows.Forms.Padding(0);
            this.LabelKoortinat.Name = "LabelKoortinat";
            this.LabelKoortinat.Size = new System.Drawing.Size(102, 24);
            this.LabelKoortinat.TabIndex = 1;
            this.LabelKoortinat.Text = "Coordinate";
            this.LabelKoortinat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelKoordinatX
            // 
            this.LabelKoordinatX.AutoSize = true;
            this.LabelKoordinatX.Location = new System.Drawing.Point(110, 50);
            this.LabelKoordinatX.Margin = new System.Windows.Forms.Padding(0);
            this.LabelKoordinatX.Name = "LabelKoordinatX";
            this.LabelKoordinatX.Size = new System.Drawing.Size(24, 24);
            this.LabelKoordinatX.TabIndex = 2;
            this.LabelKoordinatX.Text = "X";
            this.LabelKoordinatX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelKoordinatY
            // 
            this.LabelKoordinatY.AutoSize = true;
            this.LabelKoordinatY.Location = new System.Drawing.Point(190, 50);
            this.LabelKoordinatY.Margin = new System.Windows.Forms.Padding(0);
            this.LabelKoordinatY.Name = "LabelKoordinatY";
            this.LabelKoordinatY.Size = new System.Drawing.Size(22, 24);
            this.LabelKoordinatY.TabIndex = 3;
            this.LabelKoordinatY.Text = "Y";
            this.LabelKoordinatY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelWaitingTime
            // 
            this.LabelWaitingTime.AutoSize = true;
            this.LabelWaitingTime.Location = new System.Drawing.Point(10, 90);
            this.LabelWaitingTime.Margin = new System.Windows.Forms.Padding(0);
            this.LabelWaitingTime.Name = "LabelWaitingTime";
            this.LabelWaitingTime.Size = new System.Drawing.Size(162, 24);
            this.LabelWaitingTime.TabIndex = 4;
            this.LabelWaitingTime.Text = "Waiting Time (ms)";
            this.LabelWaitingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxKoordinatX
            // 
            this.TextBoxKoordinatX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxKoordinatX.Location = new System.Drawing.Point(135, 47);
            this.TextBoxKoordinatX.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxKoordinatX.Name = "TextBoxKoordinatX";
            this.TextBoxKoordinatX.Size = new System.Drawing.Size(50, 29);
            this.TextBoxKoordinatX.TabIndex = 5;
            this.TextBoxKoordinatX.Text = "0";
            this.TextBoxKoordinatX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxKoordinatX.TextChanged += new System.EventHandler(this.TextBoxKoordinatX_TextChanged);
            // 
            // TextBoxKoordinatY
            // 
            this.TextBoxKoordinatY.Location = new System.Drawing.Point(215, 47);
            this.TextBoxKoordinatY.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxKoordinatY.Name = "TextBoxKoordinatY";
            this.TextBoxKoordinatY.Size = new System.Drawing.Size(50, 29);
            this.TextBoxKoordinatY.TabIndex = 6;
            this.TextBoxKoordinatY.Text = "0";
            this.TextBoxKoordinatY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxKoordinatY.TextChanged += new System.EventHandler(this.TextBoxKoordinatY_TextChanged);
            // 
            // TextBoxWaitingTime
            // 
            this.TextBoxWaitingTime.Location = new System.Drawing.Point(181, 90);
            this.TextBoxWaitingTime.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxWaitingTime.Name = "TextBoxWaitingTime";
            this.TextBoxWaitingTime.Size = new System.Drawing.Size(75, 29);
            this.TextBoxWaitingTime.TabIndex = 7;
            this.TextBoxWaitingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxWaitingTime.TextChanged += new System.EventHandler(this.TextBoxWaitingTime_TextChanged);
            // 
            // LabelStartStopButton
            // 
            this.LabelStartStopButton.AutoSize = true;
            this.LabelStartStopButton.Location = new System.Drawing.Point(10, 130);
            this.LabelStartStopButton.Margin = new System.Windows.Forms.Padding(0);
            this.LabelStartStopButton.Name = "LabelStartStopButton";
            this.LabelStartStopButton.Size = new System.Drawing.Size(148, 24);
            this.LabelStartStopButton.TabIndex = 8;
            this.LabelStartStopButton.Text = "Start-Stop Button";
            this.LabelStartStopButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckListStartStopButton
            // 
            this.CheckListStartStopButton.CheckOnClick = true;
            this.CheckListStartStopButton.FormattingEnabled = true;
            this.CheckListStartStopButton.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.CheckListStartStopButton.Location = new System.Drawing.Point(10, 155);
            this.CheckListStartStopButton.Margin = new System.Windows.Forms.Padding(0);
            this.CheckListStartStopButton.MultiColumn = true;
            this.CheckListStartStopButton.Name = "CheckListStartStopButton";
            this.CheckListStartStopButton.Size = new System.Drawing.Size(255, 76);
            this.CheckListStartStopButton.TabIndex = 9;
            this.CheckListStartStopButton.SelectedIndexChanged += new System.EventHandler(this.CheckListStartStopButton_SelectedIndexChanged);
            // 
            // ButtonStartStop
            // 
            this.ButtonStartStop.Location = new System.Drawing.Point(95, 240);
            this.ButtonStartStop.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonStartStop.Name = "ButtonStartStop";
            this.ButtonStartStop.Size = new System.Drawing.Size(90, 35);
            this.ButtonStartStop.TabIndex = 10;
            this.ButtonStartStop.Text = "START";
            this.ButtonStartStop.UseVisualStyleBackColor = true;
            this.ButtonStartStop.Click += new System.EventHandler(this.ButtonStartStop_Click);
            // 
            // Zamanlayici
            // 
            this.Zamanlayici.Tick += new System.EventHandler(this.Zamanlayici_Tick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Learn Coordinate with Space";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(274, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonStartStop);
            this.Controls.Add(this.CheckListStartStopButton);
            this.Controls.Add(this.LabelStartStopButton);
            this.Controls.Add(this.TextBoxWaitingTime);
            this.Controls.Add(this.TextBoxKoordinatY);
            this.Controls.Add(this.TextBoxKoordinatX);
            this.Controls.Add(this.LabelWaitingTime);
            this.Controls.Add(this.LabelKoordinatY);
            this.Controls.Add(this.LabelKoordinatX);
            this.Controls.Add(this.LabelKoortinat);
            this.Controls.Add(this.LabelJustClickTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juct Click";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelJustClickTitle;
        private System.Windows.Forms.Label LabelKoortinat;
        private System.Windows.Forms.Label LabelKoordinatX;
        private System.Windows.Forms.Label LabelKoordinatY;
        private System.Windows.Forms.Label LabelWaitingTime;
        private System.Windows.Forms.TextBox TextBoxKoordinatX;
        private System.Windows.Forms.TextBox TextBoxKoordinatY;
        private System.Windows.Forms.TextBox TextBoxWaitingTime;
        private System.Windows.Forms.Label LabelStartStopButton;
        private System.Windows.Forms.CheckedListBox CheckListStartStopButton;
        private System.Windows.Forms.Button ButtonStartStop;
        private System.Windows.Forms.Timer Zamanlayici;
        private System.Windows.Forms.Label label1;
    }
}

