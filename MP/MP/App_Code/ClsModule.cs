using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP.App_Code
{
    public class ClsModule
    {
        ClsConnections con = new ClsConnections();
        public void loadControl(ComboBox comboBox, string proc)
        {
            try
            {

                SqlCommand cmd = new SqlCommand(proc, con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0, "<--Select-->" };
                dt.Rows.InsertAt(drw, 0);
                comboBox.ValueMember = "ID";
                comboBox.DisplayMember = "Name";
                comboBox.DataSource = dt;

                comboBox.SelectedIndex = 0;

            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }

        }

        public int Status { get; set; }
        public void CreateMp(string firstname, string secondname, int belief, int residence, int mptype)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("CreateMP", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Firstname", firstname);
                cmd.Parameters.AddWithValue("@secondname", secondname);
                cmd.Parameters.AddWithValue("@mptype", mptype);
                cmd.Parameters.AddWithValue("@belief", residence);
                cmd.Parameters.AddWithValue("@residence", belief);

                cmd.Parameters.Add("@ret", SqlDbType.Char, 500);
                cmd.Parameters["@ret"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                var a = (string)cmd.Parameters["@ret"].Value;
                Status = int.Parse(a);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }


        public void SearchMp(DataGridView dataGrid, string searchvalue)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("MPSearch", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@searchvalue", searchvalue);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                if (dt.Rows.Count>=0)
                {


                    Status = 1;
                    dataGrid.DataSource = dt;

                }
                else{

                    Status = 0;
                }


                //comboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }

        }

        public void UpdateMP(int id, string firstname, string secondname, int belief, int residence)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateMp", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Firstname", firstname);
                cmd.Parameters.AddWithValue("@secondname", secondname);
                cmd.Parameters.AddWithValue("@belief", residence);
                cmd.Parameters.AddWithValue("@residence", belief);

                cmd.Parameters.Add("@ret", SqlDbType.Char, 500);
                cmd.Parameters["@ret"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                var a = (string)cmd.Parameters["@ret"].Value;
                Status = int.Parse(a);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

        public void DeleteMp(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("deletemp", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                cmd.Parameters.Add("@ret", SqlDbType.Char, 500);
                cmd.Parameters["@ret"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                var a = (string)cmd.Parameters["@ret"].Value;
                Status = int.Parse(a);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

    }
}
