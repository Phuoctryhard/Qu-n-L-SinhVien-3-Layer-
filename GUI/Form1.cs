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
using BLL;
using DTO;
namespace GUI
{
    public partial class Form1 : Form
    {
        protected string Strcon = @"Data Source=DESKTOP-M4UKRGH\SQLEXPRESS01;Initial Catalog=STUDENTMANAGEMENT;Integrated Security=True";
        protected SqlConnection sqlcon = null;
        public Form1()
        {
            InitializeComponent();

        }
        DataTable dt = new DataTable();
     

        public void Form1_Load(object sender, EventArgs e)
        {
            Display();
            DisplayItemsCbb();
            
        }
        BAL_SV bal = new BAL_SV();

        
        public void Display()
        {
           
            
            dt.Rows.Clear();
            dt.Columns.Clear();
            dt = bal.getInfo();
            dataGridView1.DataSource = dt;
            
        }

        int vt = -1;
        string name = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1)
            {
                MessageBox.Show("Chua chon row de xoa");
            }
            else
            {
                // lay ra hang dc kick
                name = dataGridView1.Rows[vt].Cells[1].Value.ToString();

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if( bal.Delete(name) == true)
            {
                MessageBox.Show("Xoa thanh cong");
                Display();
            }

        }
        private void DisplayItemsCbb()
        {
            // sử dụng 1 lớp list luu cac gia tri tai cell cua row
            /*List<string> distinctValues = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCell cell = row.Cells[1]; // Lấy cell đầu tiên của mỗi hàng
             string cellValue= cell.Value.ToString();
                if (cellValue != null)
                {
                    if (!distinctValues.Contains(cellValue)) // Kiểm tra giá trị đã tồn tại trong danh sách hay chưa
                    {
                        distinctValues.Add(cellValue); // Nếu chưa tồn tại thì thêm giá trị vào danh sách
                        cbbClass.Items.Add(cellValue); // hien thi items in cbb
                    }
                }
            }
            */

            List<object> values = new List<object>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    object value = row.Cells["Class"].Value;
                    if (value != null)
                    {
                        if (values.Contains(value) == false)
                        {
                            values.Add(value);
                            cbbClass.Items.Add(value);
                        }
                    }
                }
            }
        }

        string textclass = "";
        private void textClass_TextChanged(object sender, EventArgs e)
        {
            if (textClass.Text == "")
            {
                MessageBox.Show("Vui long nhap ");
                Display();
            }
            else
            {


                textclass = textClass.Text.Trim();


                SearchClass_TextBox();
            }

        }


        // search theo class va textbox;
        string cl = "";
        private void cbbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbClass.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                cl = cbbClass.SelectedItem.ToString().Trim();

            }

           
        }
        private void SearchClass_TextBox()
        {
            dt.Rows.Clear();
            dt.Columns.Clear();
            dt = bal.searchClass_tb(textclass, cl);
            

            dataGridView1.DataSource = dt;
        }

        // /////////////////////////////////////////sort name , diem 
        string cll = "";
        private void cbbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSearch.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                cll = cbbSearch.SelectedItem.ToString().Trim();

            }

        }
        private void sortName(string cll)
        {
            dt = bal.sort_Cbb(cll);


            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e) { 
             dt.Rows.Clear();
            dt.Columns.Clear();
            sortName(cll);
        }
        SinhVien a = new SinhVien();
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 a = new Form2(this);
            a.setChoice(1);
            a.Show();
            
            

            /*
            int ma;
            Boolean result = Int32.TryParse(text1.Text, out ma);

            string name11 = text2.Text.Trim();
            string class11 = text3.Text.Trim();
            DateTime dtime = dateTimePicker1.Value;
            float dtb;
            bool success = Single.TryParse(text5.Text, out dtb);
            Boolean gender = radioFemale.Checked;
            int gender1;
            if (gender==true)
            {
                gender1 = 1;
            }
            else
            {
                gender1 = 1;
            }

            Boolean pic = checkPic.Checked;
            int pic1;
            if (pic == false)
            {
                pic1 = 0;
            }
            else
            {
                pic1 = 1;
            }
            Boolean hocba = checkHocba.Checked; ;
            int hocba1;
            if (hocba == false)
            {
                hocba1 = 0;
            }
            else
            {
                hocba1 = 1;
            }
            Boolean cccd = checkCCCD.Checked; 
            int cccd1;
            if (cccd == false)
            {
                cccd1 = 0;
            }
            else
            {
                cccd1 = 1;
            }
             if (bal.Them(ma, name11, class11, dtime, dtb, gender1, pic1, hocba1, cccd1) == true)
            {
                MessageBox.Show("Thêm thành công ");
                Display();
            }       
          */
            // bay gio muon them theo kieu sinh vien 


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2(this);
            a.setChoice(2);
            a.Show();

        }
    }
}
