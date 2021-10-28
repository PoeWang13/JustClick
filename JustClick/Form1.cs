using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace JustClick
{
    public partial class Form1 : Form
    {
        private int koordinat_X;
        private int koordinat_Y;
        private int clickTime;
        private int selectedFButton;
        private bool started;
        ClickButton clickButton = new ClickButton();
        public Form1()
        {
            InitializeComponent();
            CheckListStartStopButton.SetItemChecked(0, true);
            selectedFButton = 0;
            Zamanlayici.Interval = 5000;
            TextBoxWaitingTime.Text = 5000.ToString();

            clickButton.hookedKeys.Add(Keys.Space);
            clickButton.hookedKeys.Add((Keys)(selectedFButton + 112));
            clickButton.KeyDown += new KeyEventHandler(KullanilanTuslar);
        }

        #region Panel Degislikleri
        private void TextBoxKoordinatX_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxKoordinatX.Text != "")
            {
                if (int.TryParse(TextBoxKoordinatX.Text, out int deger))
                {
                    koordinat_X = deger;
                }
                else
                {
                    MessageBox.Show("Lütfen rakam giriniz.");
                }
            }
        }
        private void TextBoxKoordinatY_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxKoordinatY.Text != "")
            {
                if (int.TryParse(TextBoxKoordinatY.Text, out int deger))
                {
                    koordinat_Y = deger;
                }
                else
                {
                    MessageBox.Show("Lütfen rakam giriniz.");
                }
            }
        }
        private void TextBoxWaitingTime_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxWaitingTime.Text != "")
            {
                if (int.TryParse(TextBoxWaitingTime.Text, out int deger))
                {
                    clickTime = deger;
                }
                else
                {
                    MessageBox.Show("Lütfen rakam giriniz.");
                }
            }
        }
        private void CheckListStartStopButton_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFButton = CheckListStartStopButton.SelectedIndex;
            while (CheckListStartStopButton.CheckedIndices.Count > 0)
            {
                CheckListStartStopButton.SetItemChecked(CheckListStartStopButton.CheckedIndices[0], false);
            }
            CheckListStartStopButton.SetItemChecked(selectedFButton, true);

            while (clickButton.hookedKeys.Count > 1)
            {
                clickButton.hookedKeys.RemoveAt(1);
            }
            clickButton.hookedKeys.Add((Keys)(selectedFButton + 112));
        }
        private void ButtonStartStop_Click(object sender, EventArgs e)
        {
            ClickStart();
        }
        private void ClickStart()
        {
            Zamanlayici.Interval = clickTime;
            ButtonStartStop.Enabled = started;
            TextBoxKoordinatX.Enabled = started;
            TextBoxKoordinatY.Enabled = started;
            TextBoxWaitingTime.Enabled = started;
            CheckListStartStopButton.Enabled = started;
            started = !started;
            if (started)
            {
                Zamanlayici.Start();
            }
            else
            {
                Zamanlayici.Stop();
            }
        }
        #endregion

        #region Dinlenecek Tuslar
        private void KullanilanTuslar(object sender, KeyEventArgs keyEventArgs)
        {
            if (keyEventArgs.KeyCode == Keys.Space)
            {
                koordinat_X = Cursor.Position.X;
                koordinat_Y = Cursor.Position.Y;

                TextBoxKoordinatX.Text = koordinat_X.ToString();
                TextBoxKoordinatY.Text = koordinat_Y.ToString();
            }
            else if (keyEventArgs.KeyCode == (Keys)(selectedFButton + 112))
            {
                ClickStart();
            }
        }
        #endregion
        private void Zamanlayici_Tick(object sender, EventArgs e)
        {
            Point clickPoint = new Point();
            clickPoint.X = koordinat_X;
            clickPoint.Y = koordinat_Y;

            clickButton.LeftDownClick(clickPoint);
            Thread.Sleep(100);
            clickButton.LeftUpClick();
        }
    }
}