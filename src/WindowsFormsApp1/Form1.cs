using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KitalaloProgram;
using KitalaloProgram.Classes;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Guessing mg;
        private delegate void DelGuess(int which, int guessed, int generated);
        private delegate int DelGetGeneratedNum();
        private delegate int DelGetTips();

        public Form1()
        {
            InitializeComponent();
            label4.Text = "";
            label7.Text = "";
            button3.Enabled = false;
            groupBox1.Enabled = false;
        }

        private int Checker()
        {
            if (radioButton1.Checked)
            {
                return 0;
            }
            else if (radioButton2.Checked)
            {
                return 1;
            }
            else if (radioButton3.Checked)
            {
                return 2;
            }
            else
            {
                throw new Exception("Kerem valasszon opciot!");
            }
        }

        private int GetGeneratedNumber(DelGetGeneratedNum callback)
        {
            return callback();
        }

        //Start button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mg = new Guessing(int.Parse(textBox1.Text));
                DelGetGeneratedNum handle = mg.GetGeneratedNum;
                DelGetTips tipshandle = mg.GetTipsCount;
                button1.Enabled = false;
                textBox1.Enabled = false;
                button3.Enabled = true;
                label4.Text = GetGeneratedNumber(handle).ToString();
                label7.Text = GetTipsNum(tipshandle).ToString();
                groupBox1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Guess(int which, int guessed, int generated, DelGuess callback)
        {
            callback(which, guessed, generated);
        }

        private int GetTipsNum(DelGetTips callback)
        {
            return callback();
        }

        //Guess button
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DelGuess handle = mg.Guess;
                DelGetTips tipshandle = mg.GetTipsCount;
                int which = Checker();
                Guess(which, int.Parse(textBox2.Text), mg.GetGeneratedNum(), handle);
                label7.Text = GetTipsNum(tipshandle).ToString();
                //handle(which, int.Parse(textBox2.Text), mg.GetGeneratedNum());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //Reset button
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Enabled = true;
                button1.Enabled = true;
                groupBox1.Enabled = false;
                label7.Text = "";
                mg = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
