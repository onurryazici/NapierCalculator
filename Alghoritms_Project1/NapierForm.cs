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
using System.Text.RegularExpressions;
namespace Alghoritms_Project1
{


    public partial class NapierForm : Form
    {
        public NapierForm()
        {
            InitializeComponent();
        }
        NapierTools tools = new NapierTools();
        private void calculateButton_Click(object sender, EventArgs e)
        {

            if (primaryNumberTB.Text.ToString() == String.Empty || secondaryNumberTB.Text.ToString() == String.Empty)
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Thread napierThread = new Thread(new ThreadStart(renderingNapier));
                napierThread.Start();
            }
        }
        
        private void renderingNapier()
        {
            /// Invoker kullanılmasının sebebi: ///////////////////////////////////////////////////////////////////////
            /// Bu dilde buton click vb. olaylarına(event) yoğun işlemlerin kullanılması
            /// pek önerilmez. Program main thread üzerinde çalışırken ui thread(yazılım arayüzü) üzerine erişmekte 
            /// sorunlar yaşar (cross thread problemi). Bu yüzden ui thread üzerindeki elementlere(buton, textbox, vb)
            /// erişebilmek için invoke kullandım. Ayrı bir thread ile bu işlem yoğunluğunu önledim.
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            this.Invoke(new Action(() =>
            {
                workPanelRight.Visible = true;
                workPanel.Visible = true;
                workPanel.Controls.Clear();

                int primaryValue = Convert.ToInt16(primaryNumberTB.Text);
                int secondaryValue = Convert.ToInt16(secondaryNumberTB.Text);
                int primary_size = tools.getNumberLength(primaryValue);
                int secondary_size = tools.getNumberLength(secondaryValue);

                // Array for parsing digits
                int[] primary   = new int[primary_size];
                int[] secondary = new int[secondary_size];
                tools.fillDigitsToArray(primary, primaryValue);
                tools.fillDigitsToArray(secondary, secondaryValue);

                string[] napierData = new string[primary_size];


                //////////////////////////////////////////////////////
                ///
                ///                  Rendering UI
                /// 
                //////////////////////////////////////////////////////
                int xButton;
                int yButton = 10;
                for (int i = 0; i < 10; i++)
                {
                    bool available = false;
                    for (int j = 0; j < primary.Length; j++)
                    {
                        if (primary[j] == i)
                        {
                            available = true;
                        }
                    }
                    var button = new Button();
                    xButton = 5;
                    yButton += 30;
                    button.Width = 30;
                    button.Height = 30;
                    button.Location = new Point(xButton, yButton);
                    button.Text = i.ToString();
                    if (available)
                    {
                        button.BackColor = Color.Coral;
                    }
                    workPanel.Controls.Add(button);
                }

                int xLabel = 10;  ////////////////////////////////////////////////
                int yLabel = 30;  ///       For rendering napier x,y coordination
                int xMask = 45;   ///
                int yMask = 45;   ////////////////////////////////////////////////


                for (int j = 0; j < secondary.Length; j++)
                {
                    var label = new Label();
                    xLabel += 45;
                    yLabel = 10;
                    yMask = 45;
                    label.AutoSize = true;
                    label.Text = secondary[j].ToString();
                    label.Location = new Point(xLabel, yLabel);
                    workPanel.Controls.Add(label);

                    for (int k = 0; k < 10; k++)
                    {
                        var maskedTextBox = new MaskedTextBox();
                        maskedTextBox.Enabled = false;
                        maskedTextBox.Mask = "9/0";
                        maskedTextBox.Width = 30;
                        maskedTextBox.Height = 40;
                        maskedTextBox.Location = new Point(xMask, yMask);
                        if ((secondary[j] * k) < 10)
                        {
                            maskedTextBox.Text = "0" + (k * secondary[j]).ToString();
                        }
                        else
                        {
                            maskedTextBox.Text = (k * secondary[j]).ToString();
                        }
                        workPanel.Controls.Add(maskedTextBox);
                        yMask += 30;
                    }
                    xMask += 45;
                }
                //findNapier(napierData);
                renderNapierSolutionUI();
            }));
        }
        private void renderNapierSolutionUI()
        {
            workPanelRight.Visible = true;
            workPanelRight.Controls.Clear();

            int primaryValue = Convert.ToInt16(primaryNumberTB.Text);     ///  Getting value from ui object
            int secondaryValue = Convert.ToInt16(secondaryNumberTB.Text);
            int primary_size = tools.getNumberLength(primaryValue);
            int secondary_size = tools.getNumberLength(secondaryValue);

            // Array for parsing digits
            int[] primary = new int[primary_size];
            int[] secondary = new int[secondary_size];
            tools.fillDigitsToArray(primary, primaryValue);
            tools.fillDigitsToArray(secondary, secondaryValue);

            string[] napierData = new string[primary_size];

            
            int xButton;
            int yButton = 10;
            for (int i = primary.Length-1; i >=0 ; i--)
            {
                var button = new Button();
                xButton = 10;
                yButton += 30;
                button.Width = 30;
                button.Height = 30;
                button.Location = new Point(xButton, yButton);
                button.Text = primary[i].ToString();
                workPanelRight.Controls.Add(button);
            }

            int xLabel = 10;  ////////////////////////////////////////////////
            int yLabel = 30;  ///       Rendering napier for x,y coordination
            int xMask = 45;   ///
            int yMask = 45;   ////////////////////////////////////////////////

            for (int j = 0; j < secondary.Length; j++)
            {
                var label = new Label();
                xLabel += 45;
                yLabel = 10;
                yMask = 45;
                label.AutoSize = true;
                label.Text = secondary[j].ToString();
                label.Location = new Point(xLabel, yLabel);
                workPanelRight.Controls.Add(label);

                int index = 0;
                for (int k = primary.Length-1; k >= 0; k--)
                {
                    var maskedTextBox = new MaskedTextBox();
                    maskedTextBox.Enabled = false;
                    maskedTextBox.Mask = "9/0";
                    maskedTextBox.Width = 30;
                    maskedTextBox.Height = 40;
                    maskedTextBox.Location = new Point(xMask, yMask);
                    if ((secondary[j] * primary[k]) < 10)
                    {
                        maskedTextBox.Text = "0" + (secondary[j] * primary[k]).ToString();
                    }
                    else
                    {
                        maskedTextBox.Text = (secondary[j] * primary[k]).ToString();
                    }
                    napierData[index++] += (maskedTextBox.Text.ToString());
                    workPanelRight.Controls.Add(maskedTextBox);
                    yMask += 30;
                }
                xMask += 45;
            }
            findNapier(napierData, primaryValue, secondaryValue);
        }
        private void findNapier(string[] napierData, int primary, int secondary)
        {
            this.Invoke(new Action(() =>
            {
                //////////////////////////////////////////////////////////
                ///
                ///    Napier calculating
                /// 
                //////////////////////////////////////////////////////////

                int primaryLength = tools.getNumberLength(primary);
                string[] napierLine = new string[primaryLength];
                string s = "";
                int lineIndex = 0;
                for (int i = 0; i < napierData.Length; i++)
                {
                    int tempDigit = 0;
                    int carry = 0;
                    int lineLength = napierData[i].Length - 1;
                    foreach (char c in napierData[i].Reverse())
                    {
                        if (c == '/')
                        {
                            int hold = tempDigit;
                            tempDigit = (tempDigit % 10) + carry;
                            carry = hold / 10;
                            s += tempDigit.ToString();
                            tempDigit = 0;

                        }
                        else if (lineLength == 0)
                        {
                            tempDigit += Convert.ToInt16(c.ToString());
                            tempDigit += carry;
                            s += tempDigit.ToString();
                            tempDigit = 0;


                            // Reverse and save napier line for sum.
                            char[] temp = s.ToCharArray();
                            Array.Reverse(temp);
                            string line = new string(temp);
                            napierLine[lineIndex++] = line;
                            s = "";
                            
                        }
                        else
                        {
                            tempDigit += Convert.ToInt16(c.ToString());
                        }
                        lineLength--;
                    }
                }
                sumOfNapierLine(napierLine);
            }));
        }
        private void sumOfNapierLine(string[] lines)
        {
            this.Invoke(new Action(() =>
            {
                int result=0;
                int coefficient = 10;
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i != 0)
                    {
                        lines[i] = (Convert.ToInt32(lines[i]) * coefficient).ToString();
                        coefficient *= 10;
                       
                    }
                    result += Convert.ToInt32(lines[i]);
                }
                toolStripStatusLabel.Text = "Hesaplama tamamlandı bulunan sonuç " + result.ToString();
                MessageBox.Show("" + result.ToString(),"Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));
        }
        private void NapierForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Hazır";
        }

        private void primaryNumberTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)8  )  // if is digit or backspace 
            {
                if(primaryNumberTB.Text.Length < 3)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }

        }

        private void secondaryNumberTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)8) // if is digit or backspace 
            {
                if (secondaryNumberTB.Text.Length < 3)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Onur YAZICI 376950\n" +
                "Napier yöntemine göre 3 basamaklı sayıların çarpımını gerçekleştirebilirsiniz..",
                "Bilgi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            primaryNumberTB.Clear();
            secondaryNumberTB.Clear();
            workPanel.Visible = false;
            workPanelRight.Visible = false;
            workPanel.Controls.Clear();
            workPanelRight.Controls.Clear();
        }
    }
}
