using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp_exceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 cs = new Class1();
        int count = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (checkBox_kwadrat.Checked==true)
            {
                try
                {
                    cs.Bok = Convert.ToDouble(textBox_kw.Text);
                    textBox1_kw_ans.Text = Convert.ToString(cs.pole_kw());
                }
                catch (MyException ex)
                {
                    MessageBox.Show(ex.Message);
                    using (StreamWriter sw = new StreamWriter("D:\\Visual txt\\exceptions.txt",false))
                    {
                        sw.Write(count+" "+ex.Message);
                        count++;
                    }
                    textBox1_kw_ans.Clear();
                }
                catch(FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                    using (StreamWriter sw = new StreamWriter("D:\\Visual txt\\exceptions.txt",false))
                    {
                        sw.Write(count + " " + ex.Message);
                        count++;
                    }
                    textBox1_kw_ans.Clear();
                }   catch(ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
                    using (StreamWriter sw = new StreamWriter("D:\\Visual txt\\exceptions.txt", false))
                    {
                        sw.Write(count + " " + ex.Message);
                        count++;
                    }
                    textBox1_kw_ans.Clear();
                }

            }

            if (checkBox_obwod.Checked==true)
            {
                try
                {
                    cs.X = Convert.ToDouble(textBox_pr.Text);
                    cs.Y = Convert.ToDouble(textBox_pr2.Text);
                    textBox_ob_ans.Text = Convert.ToString(cs.obwod_pr());
                }
                catch (MyException ex)
                {
                    MessageBox.Show(ex.Message);
                    using (StreamWriter sw = new StreamWriter("D:\\Visual txt\\exceptions.txt", false))
                    {
                        sw.Write(count + " " + ex.Message);
                        count++;
                    }
                    textBox_ob_ans.Clear();
                }
                catch(FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                    using (StreamWriter sw = new StreamWriter("D:\\Visual txt\\exceptions.txt", false))
                    {
                        sw.Write(count + " " + ex.Message);
                        count++;
                    }
                    textBox_ob_ans.Clear();
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
                    using (StreamWriter sw = new StreamWriter("D:\\Visual txt\\exceptions.txt", false))
                    {
                        sw.Write(count + " " + ex.Message);
                        count++;
                    }
                    textBox1_kw_ans.Clear();
                }
            }


            int x=0, y=0;
            if (checkBox_pomnoz.Checked == true)
            {
                try
                {
                    x = Convert.ToInt32(textBox_multiply1.Text);
                    y = Convert.ToInt32(textBox_multiply2.Text);
                    textBox_mul_ans.Text=Convert.ToString(cs.pomnoz(x, y));
                }
                
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                    using (StreamWriter sw = new StreamWriter("D:\\Visual txt\\exceptions.txt", false))
                    {
                        sw.Write(count + " " + ex.Message);
                        count++;
                    }
                    textBox_mul_ans.Clear();
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
                    using (StreamWriter sw = new StreamWriter("D:\\Visual txt\\exceptions.txt", false))
                    {
                        sw.Write(count + " " + ex.Message);
                        count++;
                    }
                    textBox1_kw_ans.Clear();
                }
            }

            
            if (checkBox_divide.Checked == true)
            {
                try
                {
                    x = Convert.ToInt32(textBox_divide1.Text);
                    y = Convert.ToInt32(textBox_divide2.Text);
                    cs.Znam = y;
                    textBox_div_ans.Text = Convert.ToString(cs.podziel(x));
                }

                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                    using (StreamWriter sw = new StreamWriter("D:\\Visual txt\\exceptions.txt", false))
                    {
                        sw.Write(count + " " + ex.Message);
                        count++;
                    }
                    textBox_div_ans.Clear();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                    using (StreamWriter sw = new StreamWriter("D:\\Visual txt\\exceptions.txt", false))
                    {
                        sw.Write(count + " " + ex.Message);
                        count++;
                    }
                    textBox_div_ans.Clear();
                }
               
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_mul_ans.ReadOnly = true;
        }

        //private void MouseEnter(object sender, EventArgs e)
        //{
        //    Cursor.Position = new Point(100, 100);
        //}
    }
}
