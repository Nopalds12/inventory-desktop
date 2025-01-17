﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class FormKaryawanGudang : Form
    {
        Helper helper = new Helper();
        public FormKaryawanGudang()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataBarangUC1.Visible = true;
            dataBarangUC1.BringToFront();
            dataBarangUC1.DataBarangUC_Load(this, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataBarangKeluarUC1.Visible = true;
            dataBarangKeluarUC1.BringToFront();
            dataBarangKeluarUC1.DataBarangKeluarUC_Load(this, null);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataBarangMasukUC1.Visible = true;
            dataBarangMasukUC1.BringToFront();
            dataBarangMasukUC1.DataBarangMasukUC_Load(this, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataBarangRusakUC1.Visible = true;
            dataBarangRusakUC1.BringToFront();
            dataBarangRusakUC1.DataBarangRusakUC_Load(this, null);
        }

        private void FormKaryawanGudang_Load(object sender, EventArgs e)
        {
            DataTable userLevelLabel = helper.GetOneData("select level_user from users where id_user='" + FormLogin.id_user + "'");
            if (userLevelLabel.Rows[0][0].ToString() == "Karyawan Gudang")
            {
                user.Text = "Gudang";
            }
            else
            {
                user.Text = userLevelLabel.Rows[0][0].ToString();
            }

            dataBarangUC1.Visible = true;
            dataBarangUC1.BringToFront();
            dataBarangUC1.DataBarangUC_Load(this, null);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda akan log-out?", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Hide();
                FormLogin fl = new FormLogin();
                fl.Show();
                helper.LogActivity("logout");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataLaporan1.Visible = true;
            dataLaporan1.BringToFront();
        }
    }
}
