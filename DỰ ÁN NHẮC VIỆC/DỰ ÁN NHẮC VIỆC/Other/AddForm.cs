using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ListForm
{
    public partial class AddForm : Form
    {
        int ChonChuNang; // 0: là tạo, 1 là lưu

        public AddForm(int chonChuNang)
        {
            InitializeComponent();
            ChonChuNang = chonChuNang;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ChonChuNang == 0)
                AddJobToSql();
            else
                UpdateJobToSql();

        }

        void AddJobToSql()
        {
            //try
            //{
            //    string connectionString = "server=.; database = Work Management; Integrated Security = true; ";
            //    using (SqlConnection conn = new SqlConnection(connectionString))
            //    {
            //        SqlCommand cmd = conn.CreateCommand();
            //        cmd.CommandText = "EXECUTE InsertFood @id OUTPUT, @NameJob, @Status, @Level, @DSCongViecCon";

            //        // Thêm tham số vào đối tượng Command
            //        cmd.Parameters.Add("@id", SqlDbType.Int);
            //        cmd.Parameters.Add("@name", SqlDbType.NVarChar, 3000);
            //        cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
            //        cmd.Parameters.Add("@foodCategoryId", SqlDbType.Int);
            //        cmd.Parameters.Add("@price", SqlDbType.Int);
            //        cmd.Parameters.Add("@notes", SqlDbType.VarChar, 3000);
            //        cmd.Parameters["@id"].Direction = ParameterDirection.Output;

            //        // Truyền giá trị vào thủ tục qua tham số
            //        cmd.Parameters["@name"].Value = txtTen.Text;
            //        cmd.Parameters["@unit"].Value = txtUnit.Text;
            //        cmd.Parameters["@foodCategoryId"].Value = cbbCatName.SelectedValue;
            //        cmd.Parameters["@price"].Value = nudPrice.Value;
            //        cmd.Parameters["@notes"].Value = txtNotes.Text;
            //        //mở kết nối
            //        conn.Open();
            //        int numRowAffected = cmd.ExecuteNonQuery();

            //        // Thông báo kết quả
            //        if (numRowAffected > 0)
            //        {
            //            string foodID = cmd.Parameters["@id"].Value.ToString();
            //            MessageBox.Show("Successfully adding new food, Food ID =" + foodID, "Message");
            //            this.ResetText();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Adding food failed");
            //        }
            //    }
            //}
            //// Bắt lỗi SQL và các lỗi khác
            //catch (SqlException exception)
            //{
            //    MessageBox.Show(exception.Message, "SQL Error");
            //}
            //catch (Exception exception)
            //{
            //    MessageBox.Show(exception.Message, "Error");
            //}
        }

        void UpdateJobToSql()
        {
            //    try
            //    {
            //        string connectionString = "server=PC822; database = RestaurantManagement; Integrated Security = true; ";
            //        SqlConnection conn = new SqlConnection(connectionString);

            //        SqlCommand cmd = conn.CreateCommand();
            //        cmd.CommandText = "EXECUTE UpdateFood @id, @name, @unit, @foodCategoryID, @price, @notes";

            //        // Thêm tham số vào đối tượng Command
            //        cmd.Parameters.Add("@id", SqlDbType.Int);
            //        cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
            //        cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
            //        cmd.Parameters.Add("@foodCategoryId", SqlDbType.Int);
            //        cmd.Parameters.Add("@price", SqlDbType.Int);
            //        cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

            //        // Truyền giá trị vào thủ tục qua tham số
            //        cmd.Parameters["@id"].Value = int.Parse(txtFoodID.Text);
            //        cmd.Parameters["@name"].Value = txtName.Text;
            //        cmd.Parameters["@unit"].Value = txtUnit.Text;
            //        cmd.Parameters["@foodCategoryId"].Value = cbbCatName.SelectedValue;
            //        cmd.Parameters["@price"].Value = nudPrice.Value;
            //        cmd.Parameters["@notes"].Value = txtNotes.Text;

            //        // mà kết nối
            //        conn.Open();

            //        int numRowAffected = cmd.ExecuteNonQuery();
            //        // Thông báo kết quả
            //        if (numRowAffected > 0)
            //        {
            //            MessageBox.Show("Successfully updating food", "Message");
            //            this.ResetText();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Updating food failed");
            //        }
            //        // đóng kết nối
            //        conn.Close();
            //        conn.Dispose();
            //    }
            //    // Bắt lỗi SQL và các lỗi khác
            //    catch (SqlException exception)
            //    {
            //        MessageBox.Show(exception.Message, "SQL, Error");
            //    }
            //    catch (Exception exception)
            //    {
            //        MessageBox.Show(exception.Message, "Error");
            //    }
        }

    }
}

