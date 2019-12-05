using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MP.App_Code;

namespace MP
{
    public partial class CreateMP : UserControl
    {
        ClsModule clsModule = new ClsModule();
        public CreateMP()
        {
            InitializeComponent();
            init();
        }
        void init()
        {

            clsModule.loadControl(cmbBelief, "getBelief");
            clsModule.loadControl(cmbMp, "getMp_Type");
            clsModule.loadControl(cmbResidence, "getResidence");

        }
        public void clear()
        {
            txtFirstname.Clear();
            txtSecondname.Clear();
            cmbResidence.SelectedIndex = 0;
            cmbBelief.SelectedIndex = 0;
            cmbMp.SelectedIndex = 0;

        }


        private void BtnSave_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrWhiteSpace(txtFirstname.Text) || string.IsNullOrWhiteSpace(txtSecondname.Text) || cmbBelief.SelectedIndex ==0 || cmbMp.SelectedIndex == 0 || cmbResidence.SelectedIndex == 0)
            {
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    clsModule.CreateMp(txtFirstname.Text.ToUpper(), txtSecondname.Text.ToUpper(), int.Parse(cmbBelief.SelectedValue.ToString()), int.Parse(cmbResidence.SelectedValue.ToString()),
                        int.Parse(cmbMp.SelectedValue.ToString()));

                    if (clsModule.Status > 0)
                    {
                        MessageBox.Show("New Mp Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Invalid MP Combination", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.ToString());
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void CmbMp_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                    cmbBelief.SelectedValue = cmbMp.SelectedValue;
            cmbResidence.SelectedValue = cmbMp.SelectedValue;
             
            
        }
    }
}