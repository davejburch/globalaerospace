using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeypadFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sInput = "global aerospace";

            string[] keys = { " ", " ", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz", "*", "#" };
            string seq = "";
            int mintime = 0;
            int additionalMS = 0;

            foreach (char c in sInput)
            {
                int button = Array.FindIndex(keys, item => item.Contains(c));   //find button to press
                int press = keys[button].IndexOf(c)+1;                          //count times to press
                seq = seq + button.ToString() + press.ToString() + ",";         //record sequence to press
                mintime += press;
                if (press > 1) { additionalMS += ((press-1)*500); }             //same button used, pause between, but not last
            }

            int iTime = (mintime * 100) + additionalMS; //for each character(keypress) 100ms press + 500ms pause [for each 'same key letter']
            
            //Answers: seq for sequence, iTime for min time required

            // TODO:  consider capital letters and full stop etc and multi press of space key..


        }
    }
}
