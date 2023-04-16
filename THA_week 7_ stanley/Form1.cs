using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_week_7__stanley
{
    public partial class Form1 : Form
    {
        int x = 0;
        int y = 0;
        int z = 0;
        int check = 0;
        List <Button> buttons1 = new List <Button> ();
        List <Button> buttons2 = new List <Button> ();
        List <Button> buttons3 = new List <Button>();
        List<Button> buttons4 = new List<Button>();
        List<Button> buttons5 = new List<Button>();
        List<Button> buttons6 = new List<Button>();
        List<Button> buttons7 = new List<Button>();
        List<Button> buttons8 = new List<Button>();
        List<Button> buttons9 = new List<Button>();
        List<Button> buttons10 = new List<Button>();
        List<Button> buttons11 = new List<Button>();
        List<Button> buttons12 = new List<Button>();
        List<Button> buttons13 = new List<Button>();
        List<Button> buttons14 = new List<Button>();
        List<Button> buttons15 = new List<Button>();
        List<Button> buttons16 = new List<Button>();
        List<Button> buttons17 = new List<Button>();
        List<Button> buttons18 = new List<Button>();
        List<Button> buttons19 = new List<Button>();
        List<Button> buttons20 = new List<Button>();
        List<Button> buttons21 = new List<Button>();
        List<Button> buttons22 = new List<Button>();
        List<Button> buttons23 = new List<Button>();
        List<Button> buttons24 = new List<Button>();

        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i<10; i++)
            {
                for( int o = 0; 0<10; o++ )
                {
                    Button kursi = new Button();
                    kursi.Location = new Point(2+x,2+y);
                    kursi.Size = new Size(50, 50);
                    kursi.Tag = z;
                    kursi.BackColor = Color.Green;
                    buttons1.Add(kursi);
                    buttons2.Add(kursi);
                    buttons3.Add(kursi);
                    buttons4.Add(kursi);
                    buttons5.Add(kursi);
                    buttons6.Add(kursi);
                    buttons7.Add(kursi);
                    buttons8.Add(kursi);
                    buttons9.Add(kursi);
                    buttons10.Add(kursi);
                    buttons11.Add(kursi);
                    buttons12.Add(kursi);
                    buttons13.Add(kursi);
                    buttons14.Add(kursi);
                    buttons15.Add(kursi);
                    buttons16.Add(kursi);
                    buttons17.Add(kursi);
                    buttons18.Add(kursi);
                    buttons19.Add(kursi);
                    buttons20.Add(kursi);
                    buttons21.Add(kursi);
                    buttons22.Add(kursi);
                    buttons23.Add(kursi);
                    buttons24.Add(kursi);
                    kursi.Click += kursiclick;
                    x += 55;
                    z++;
                }
                x = 0; 
                y +=  55;
            }
            for(int i = 0; i<70; i++)
            {
                buttons1[random.Next(0,100)].BackColor = Color.Red;
                buttons2[random.Next(0, 100)].BackColor = Color.Red;
                buttons3[random.Next(0, 100)].BackColor = Color.Red;
                buttons4[random.Next(0, 100)].BackColor = Color.Red;
                buttons5[random.Next(0, 100)].BackColor = Color.Red;
                buttons6[random.Next(0, 100)].BackColor = Color.Red;
                buttons7[random.Next(0, 100)].BackColor = Color.Red;
                buttons8[random.Next(0, 100)].BackColor = Color.Red;
                buttons9[random.Next(0, 100)].BackColor = Color.Red;
                buttons10[random.Next(0, 100)].BackColor = Color.Red;
                buttons11[random.Next(0, 100)].BackColor = Color.Red;
                buttons12[random.Next(0, 100)].BackColor = Color.Red;
                buttons13[random.Next(0, 100)].BackColor = Color.Red;
                buttons14[random.Next(0, 100)].BackColor = Color.Red;
                buttons15[random.Next(0, 100)].BackColor = Color.Red;
                buttons16[random.Next(0, 100)].BackColor = Color.Red;
                buttons17[random.Next(0, 100)].BackColor = Color.Red;
                buttons18[random.Next(0, 100)].BackColor = Color.Red;
                buttons19[random.Next(0, 100)].BackColor = Color.Red;
                buttons20[random.Next(0, 100)].BackColor = Color.Red;
                buttons21[random.Next(0, 100)].BackColor = Color.Red;
                buttons22[random.Next(0, 100)].BackColor = Color.Red;
                buttons23[random.Next(0, 100)].BackColor = Color.Red;
                buttons24[random.Next(0, 100)].BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check = 1;
            panel1.Controls.Clear();
            foreach(Button button in buttons1) 
            {
                panel1.Controls.Add(button);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            check = 2;
            panel1.Controls.Clear();
            foreach (Button button in buttons2)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            check = 3;
            panel1.Controls.Clear();
            foreach (Button button in buttons3)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            check = 4;
            panel1.Controls.Clear();
            foreach (Button button in buttons4)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            check = 5;
            panel1.Controls.Clear();
            foreach (Button button in buttons5)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            check = 6;
            panel1.Controls.Clear();
            foreach (Button button in buttons6)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            check = 7;
            panel1.Controls.Clear();
            foreach (Button button in buttons7)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            check = 8;
            panel1.Controls.Clear();
            foreach (Button button in buttons8)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            check = 9;
            panel1.Controls.Clear();
            foreach (Button button in buttons9)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            check = 10;
            panel1.Controls.Clear();
            foreach (Button button in buttons10)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            check = 11;
            panel1.Controls.Clear();
            foreach (Button button in buttons11)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            check = 12;
            panel1.Controls.Clear();
            foreach (Button button in buttons12)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            check = 13;
            panel1.Controls.Clear();
            foreach (Button button in buttons13)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            check = 14;
            panel1.Controls.Clear();
            foreach (Button button in buttons14)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            check = 15;
            panel1.Controls.Clear();
            foreach (Button button in buttons15)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            check = 16;
            panel1.Controls.Clear();
            foreach (Button button in buttons16)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            check = 17;
            panel1.Controls.Clear();
            foreach (Button button in buttons17)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            check = 18;
            panel1.Controls.Clear();
            foreach (Button button in buttons18)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            check = 19;
            panel1.Controls.Clear();
            foreach (Button button in buttons19)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            check = 20;
            panel1.Controls.Clear();
            foreach (Button button in buttons20)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            check = 21;
            panel1.Controls.Clear();
            foreach (Button button in buttons21)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            check = 22;
            panel1.Controls.Clear();
            foreach (Button button in buttons22)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            check = 23;
            panel1.Controls.Clear();
            foreach (Button button in buttons23)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            check = 24;
            panel1.Controls.Clear();
            foreach (Button button in buttons24)
            {
                panel1.Controls.Add(button);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                foreach (Button button in buttons1)
                {
                    button.BackColor = Color.Green; 
                }
            }
            if (check == 2)
            {
                foreach (Button button in buttons2)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 3)
            {
                foreach (Button button in buttons3)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 4)
            {
                foreach (Button button in buttons4)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 5)
            {
                foreach (Button button in buttons5)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 6)
            {
                foreach (Button button in buttons6)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 7)
            {
                foreach (Button button in buttons7)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 8)
            {
                foreach (Button button in buttons8)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 9)
            {
                foreach (Button button in buttons9)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 10)
            {
                foreach (Button button in buttons10)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 11)
            {
                foreach (Button button in buttons11)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 12)
            {
                foreach (Button button in buttons12)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 13)
            {
                foreach (Button button in buttons13)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 14)
            {
                foreach (Button button in buttons14)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 15)
            {
                foreach (Button button in buttons15)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 16)
            {
                foreach (Button button in buttons16)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 17)
            {
                foreach (Button button in buttons17)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 18)
            {
                foreach (Button button in buttons18)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 19)
            {
                foreach (Button button in buttons19)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 20)
            {
                foreach (Button button in buttons20)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 21)
            {
                foreach (Button button in buttons21)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 22)
            {
                foreach (Button button in buttons22)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 23)
            {
                foreach (Button button in buttons23)
                {
                    button.BackColor = Color.Green;
                }
            }
            if (check == 24)
            {
                foreach (Button button in buttons24)
                {
                    button.BackColor = Color.Green;
                }
            }
        }

        private void kursiclick(object sender, EventArgs e)
        {
            Button butt = sender as Button;
            if (check == 1) 
            {
                foreach (Button button in buttons1)
                {
                    if(button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 2)
            {
                foreach (Button button in buttons2)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 3)
            {
                foreach (Button button in buttons3)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 4)
            {
                foreach (Button button in buttons4)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 5)
            {
                foreach (Button button in buttons5)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 6)
            {
                foreach (Button button in buttons6)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 7)
            {
                foreach (Button button in buttons7)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 8)
            {
                foreach (Button button in buttons8)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 9)
            {
                foreach (Button button in buttons9)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 10)
            {
                foreach (Button button in buttons10)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 11)
            {
                foreach (Button button in buttons11)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 12)
            {
                foreach (Button button in buttons12)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 13)
            {
                foreach (Button button in buttons13)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 14)
            {
                foreach (Button button in buttons14)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 15)
            {
                foreach (Button button in buttons15)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 16)
            {
                foreach (Button button in buttons16)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 17)
            {
                foreach (Button button in buttons17)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 18)
            {
                foreach (Button button in buttons18)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 19)
            {
                foreach (Button button in buttons19)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 20)
            {
                foreach (Button button in buttons20)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 21)
            {
                foreach (Button button in buttons21)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 22)
            {
                foreach (Button button in buttons22)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 23)
            {
                foreach (Button button in buttons23)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (check == 24)
            {
                foreach (Button button in buttons24)
                {
                    if (button.Tag == butt.Tag)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
