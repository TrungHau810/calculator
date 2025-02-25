using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculation_53_Hau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Phép cộng
        private void btn_Cong_53_Hau_Click(object sender, EventArgs e)
        {
            int a_53_Hau, b_53_Hau, ketqua_53_Hau;
            a_53_Hau = int.Parse(txt1_53_Hau.Text);
            b_53_Hau = int.Parse(txt2_53_Hau.Text);
            Calculation_53_Hau c = new Calculation_53_Hau(a_53_Hau, b_53_Hau);
            ketqua_53_Hau = c.Execute_53_Hau("+");
            txt_kq_53_Hau.Text = ketqua_53_Hau.ToString();
        }

        //Phép trừ
        private void btn_Tru_53_Hau_Click(object sender, EventArgs e)
        {
            int a_53_Hau, b_53_Hau, ketqua_53_Hau;
            a_53_Hau = int.Parse(txt1_53_Hau.Text);
            b_53_Hau = int.Parse(txt2_53_Hau.Text);
            Calculation_53_Hau c = new Calculation_53_Hau(a_53_Hau, b_53_Hau);
            ketqua_53_Hau = c.Execute_53_Hau("-");
            txt_kq_53_Hau.Text = ketqua_53_Hau.ToString();
        }

        //Phép nhân
        private void btn_Nhan_53_Hau_Click(object sender, EventArgs e)
        {
            int a_53_Hau, b_53_Hau, ketqua_53_Hau;
            a_53_Hau = int.Parse(txt1_53_Hau.Text);
            b_53_Hau = int.Parse(txt2_53_Hau.Text);
            Calculation_53_Hau c = new Calculation_53_Hau(a_53_Hau, b_53_Hau);
            ketqua_53_Hau = c.Execute_53_Hau("*");
            txt_kq_53_Hau.Text = ketqua_53_Hau.ToString();
        }

        //Phép chia
        private void btn_Chia_53_Hau_Click(object sender, EventArgs e)
        {
            int a_53_Hau, b_53_Hau, ketqua_53_Hau;
            a_53_Hau = int.Parse(txt1_53_Hau.Text);
            b_53_Hau = int.Parse(txt2_53_Hau.Text);
            Calculation_53_Hau c = new Calculation_53_Hau(a_53_Hau, b_53_Hau);
            ketqua_53_Hau = c.Execute_53_Hau("/");
            txt_kq_53_Hau.Text = ketqua_53_Hau.ToString();
        }
    }
}
