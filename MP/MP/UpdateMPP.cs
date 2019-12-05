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
    public partial class UpdateMPP : UserControl
    {
        ClsModule clsModule = new ClsModule();
        public UpdateMPP()
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
            this.gdvSearch.DataSource = null;
            this.gdvSearch.Rows.Clear();

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                try
                {

                    DataTable ds;

                    clsModule.SearchMp(gdvSearch, txtSearch.Text.ToLower()); ;

                    if (clsModule.Status==0)
                    {
                        clear();
                        MessageBox.Show("Oops! No Record Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                catch (Exception ex)
                {

                    throw new Exception(ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("The Search field is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gdvSearch.Refresh();
            }

        }
        public int ID { get; set; }
        private void GdvSearch_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(gdvSearch.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtFirstname.Text = gdvSearch.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSecondname.Text = gdvSearch.Rows[e.RowIndex].Cells[2].Value.ToString();
            
                cmbBelief.Text = gdvSearch.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbResidence.Text = gdvSearch.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbMp.Text = gdvSearch.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception)
            {

                return;
            }
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("No Mp Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFirstname.Text) || string.IsNullOrWhiteSpace(txtSecondname.Text) || cmbBelief.SelectedIndex == 0 || cmbResidence.SelectedIndex == 0)
            {
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                try
                {
                    clsModule.UpdateMP(ID,txtFirstname.Text, txtSecondname.Text, int.Parse(cmbBelief.SelectedValue.ToString()), int.Parse(cmbResidence.SelectedValue.ToString())  );

                    if (clsModule.Status > 0)
                    {
                        MessageBox.Show("Mp Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Oops! Something", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
                catch (Exception )
                {

                    MessageBox.Show("Invalid options Selected Belief or Residence ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ID!=0)
            {
                clsModule.DeleteMp(ID);
                if (clsModule.Status > 0)
                {
                    MessageBox.Show("MP Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    MessageBox.Show("There is no mp with this ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }

            }
        }
    }
}
