using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
  
    public partial class Form2 : Form
    {

        public delegate void CustomEventHandler(object sender, EventArgs e);
        public event CustomEventHandler Form1_Load;

        protected virtual void OnCustomEvent()
        {
            Form1_Load?.Invoke(this, EventArgs.Empty);
        }

        
        private Form1 form1;


        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
       
     







        BAL_SV bal = new BAL_SV();
        DataTable dt = new DataTable();
        Form1 aa = new Form1();
        // Lay su lua chon 
        int choice;
        public void setChoice(int b)
        {
            choice = b;
        }
 
       /// ///////////////////////////////////////////////////////  BUTTTON OKE 
 
        private void btnOki_Click(object sender, EventArgs e)
        {
            
            if (choice == 1)
            {
                int ma;
                bool kt = Int32.TryParse(this.Getmsv(), out ma);

                string class1 = this.getClass();
                string name1 = this.getName();
                DateTime dtime1 = this.getDate();
                float dtb1;
                Boolean kt1 = float.TryParse(this.getDtb(), out dtb1);
                int gender1;
                if (this.getGender() == "MALE")
                {
                    gender1 = 1;
                }
                else
                {
                    gender1 = 0;
                }
                int pic1;
                if (this.getPic() == true)
                {
                    pic1 = 1;
                }
                else
                {
                    pic1 = 0;
                }

                int hocba1;
                if (this.getHocBa() == true)
                {
                    hocba1 = 1;
                }
                else
                {
                    hocba1 = 0;
                }
                int cmnd1;
                if (this.getCmnd() == true)
                {
                    cmnd1 = 1;

                }
                else
                {
                    cmnd1 = 0;
                }
                

                if (bal.Them(ma, name1, class1, dtime1, dtb1, gender1, pic1, hocba1, cmnd1) == true)
                {
                   
                    aa.Display();
                    MessageBox.Show("Thuc hien Thêm thanh cong");                
                }
                
            }
            else if(choice == 2)
            {
                MessageBox.Show("Thuc hien Sửa");
                
                int ma1;
                bool kt = Int32.TryParse(this.Getmsv(), out ma1);

                string class11 = this.getClass();
                string name11 = this.getName();
                DateTime dtime11 = this.getDate();
                float dtb11;
                Boolean kt1 = float.TryParse(this.getDtb(), out dtb11);
                int gender11;
                if (this.getGender() == "MALE")
                {
                    gender11 = 1;
                }
                else
                {
                    gender11 = 0;
                }
                int pic11;
                if (this.getPic() == true)
                {
                    pic11 = 1;
                }
                else
                {
                    pic11 = 0;
                }

                int hocba11;
                if (this.getHocBa() == true)
                {
                    hocba11 = 1;
                }
                else
                {
                    hocba11 = 0;
                }
                int cmnd11;
                if (this.getCmnd() == true)
                {
                    cmnd11 = 1;

                }
                else
                {
                    cmnd11 = 0;
                }

                if (bal.Update(ma1, name11, class11, dtime11, dtb11, gender11, pic11, hocba11, cmnd11) == true)
                {

                    aa.Display();
                    MessageBox.Show("Thuc hien Xóa thanh cong");
                }
            }

        }

      
        // them thogn tin vao datatable 

        public string Getmsv()
        {
            return (textMsv.Text);
        }

        public string getName()
        {
            return textName.Text;
        }



        public string getClass()
        {
            return textClass.Text;
        }


        public DateTime getDate()
        {
            return dateTimePicker1.Value;

        }
        public string getDtb()
        {
            return (textDtb.Text);
        }

        string s = "";
        string a = "";
        public string getGender()
        {
            if (radioNam.Checked)
            {
                s = "Male";
                return s;
            }
            else
            {
                a = "Female";
                return a;
            }
        }

        public bool getPic()
        {
            if (checkPic.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean getHocBa()
        {
            if (checkHocBa.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool getCmnd()
        {
            if (checkCCCD.Checked)
            {
                return true;
            }
            else
            {
                return true;
            }
        }

        public void setMsv(string ma)
        {
            this.textMsv.Text = ma;

        }
        public void SetName(string name)
        {
            textName.Text = name;
        }

        public void setClass(string class1)
        {
            textClass.Text = class1;
        }

        public void setGender(Boolean gender)
        {
            if (gender == true)
            {
                radioNam.Checked = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban Co muon thoat ko ", "Oki", MessageBoxButtons.OK, MessageBoxIcon.Question);
            this.Close();

            form1.Form1_Load(sender, e);


        }


       
    }

}
