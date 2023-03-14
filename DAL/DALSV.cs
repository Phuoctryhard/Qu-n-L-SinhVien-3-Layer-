using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Data.SqlTypes;
using System.Security.Claims;

namespace DAL
{
    public class DALSV : Database
    {

        DataTable dt = new DataTable();
        SqlDataAdapter dter;
        public DataTable getInfo()
        {
            try
            {
                OpenConnction();

                SqlDataAdapter adapter = new SqlDataAdapter("select * from SinhVien", sqlcon);
                adapter.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }

        }
        public Boolean Delete(string a)
        {
            OpenConnction();

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "delete from SinhVien where Name ='" + a + "'";
            sqlcmd.Connection = sqlcon;
            int kq = sqlcmd.ExecuteNonQuery();
            if (kq > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable sortName(string n)
        {
            OpenConnction();


            SqlDataAdapter adapter = new SqlDataAdapter("select * from SinhVien ORDER BY " + n + " DESC", sqlcon);
            adapter.Fill(dt);

            return dt;

        }
        public DataTable searchClass_tb(string tb, string items)
        {
            OpenConnction();


            SqlDataAdapter adapter = new SqlDataAdapter("select * from SinhVien where Name LIKE N'%" + tb + "%' and Class = '" + items + "'", sqlcon);
            adapter.Fill(dt);

            return dt;
            closeConnection();

        }

        public bool Them(int Msv, string name, string Class, DateTime date, float dtb, int gender, int pic, int HocBa, int Cmnd)
        {

            OpenConnction();
            SqlCommand Sqlcmd = new SqlCommand();
            Sqlcmd.CommandType = CommandType.Text;
            //SqlDataAdapter adapter = new SqlDataAdapter("insert into SinhVien values("+a.Msv+",'"+ a.Name +"','"+ a.Class +"','"+a.date +"',"+ a.dtb+","+ a.gender+","+a.Pic+","+ a.HocBa +","+a.Cmnd",sqlcon);
            Sqlcmd.CommandText = "insert into SinhVien VALUES (" + Msv + ",N'" + name + "','" + Class + "','" +date + "'," + dtb + "," + gender + "," + pic + "," + HocBa + "," + Cmnd + ")";


            Sqlcmd.Connection = sqlcon;
            int kq = Sqlcmd.ExecuteNonQuery();
            if (kq > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /////////////////////////////////  Chuc nang  UPDATE sửa lại 

        public bool Update(int Msv, string name, string Class, DateTime date, float dtb, int gender, int pic, int HocBa, int Cmnd)
            {
           
                OpenConnction();
          

                SqlCommand Sqlcmd = new SqlCommand();
                Sqlcmd.CommandType = CommandType.Text;
                //SqlDataAdapter adapter = new SqlDataAdapter("insert into SinhVien values("+a.Msv+",'"+ a.Name +"','"+ a.Class +"','"+a.date +"',"+ a.dtb+","+ a.gender+","+a.Pic+","+ a.HocBa +","+a.Cmnd",sqlcon);
                Sqlcmd.CommandText = "Update SinhVien set Msv=" + Msv + ",Name =N'" + name + "',Class = '" + Class + "',Date = '" + date + "',Dtb = " + dtb + ",Gender = " + gender + ",Pic = " + pic + ",HocBa = " + HocBa + ",CCCD = " + Cmnd + " where Msv ="+ Msv;
            Sqlcmd.Connection = sqlcon;
            int kq = Sqlcmd.ExecuteNonQuery();
            if (kq > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }      
    }
}


