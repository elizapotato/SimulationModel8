using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_8
{
    public partial class Form1 : Form
    {
        MagicBall ball = new MagicBall();
        string prevText = "";
        public Form1()
        {
            InitializeComponent();
            labAns.Text = "";
        }

        public class MagicBall
        {
            private readonly Dictionary<int, string> ans = new Dictionary<int, string>()
            {
                {0, "It is certain."},
                {1, "Without a doubt."},
                {2, "You may rely on it."},
                {3, "It is decidedly so."},
                {4, "Signs point to yes."},

                {5, "Don’t count on it."},
                {6, "Very doubtful."},
                {7, "No, no, definitely not."},
                {8, "It is absolutely not."},
                {9, "Outlook not so good."},

                {10, "Cannot predict now."},
                {11, "Ask again later."},
            };

            private readonly Dictionary<int, double> prob = new Dictionary<int, double>()
            {
                {0, 0.08},
                {1, 0.1},
                {2, 0.11},
                {3, 0.09},
                {4, 0.07},

                {5, 0.08},
                {6, 0.1},
                {7, 0.11},
                {8, 0.09},
                {9, 0.07},

                {10, 0.06},
                {11, 0.04},
            };

            public string GetAnswer()
            {
                Random random = new Random();
                double chance = random.NextDouble();
                for (var i = 0; i <= prob.Count; i++)
                {
                    chance -= prob[i];
                    if (chance <= 0)
                        return ans[i];
                };
                return ans[0];
            }
        }

        private void checkMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ansButton_Click(object sender, EventArgs e)
        {
            if (questBox.Text == "")
            {
                labAns.Text = "Ask the question!";
                return;
            }
            if (questBox.Text == prevText)
            {
                labAns.Text = "Ask the new question!";
                return;
            }
            else 
            {
                if (checkMode.Checked)
                {
                    Random random = new Random();
                    if (random.NextDouble() < 0.5) labAns.Text = "Yes";
                    else labAns.Text = "No";
                    prevText = questBox.Text;
                    return;
                }
                else
                {
                    labAns.Text = ball.GetAnswer();
                    prevText = questBox.Text;
                    return;
                }
            }
            
        }
    }
}
