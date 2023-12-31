﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euclides
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int AEuclides(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return AEuclides(b, a % b);
            }
        }

        private void Btnsi_Click(object sender, EventArgs e)
        {
            int a, b,temp,i=0,res,es;
            a = int.Parse(Txtm.Text);
            b= int.Parse(Txtn.Text);
            int mcd = AEuclides(a, b);
            
             while(b!=0)
            {
                temp = b;
                res= a % b;
                es= a / b;
                DGWres.Rows.Add(i.ToString(), a.ToString() + " Dividido entre " + b.ToString() + " es " + es.ToString() + " y sobran " + res.ToString(), a.ToString() + "/" + b.ToString() + " = " + es.ToString() + " + 1/" + b.ToString() + "/" + res.ToString());
                b = a % b; 
                a = temp;
                i++;
            }

                MessageBox.Show($"El MCD de {a} y {b} es {mcd}", "Máximo Común Divisor");
            
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Txtm.Text = "";
            Txtn.Text = "";
            Txtm.Focus();
            DGWres.Rows.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
