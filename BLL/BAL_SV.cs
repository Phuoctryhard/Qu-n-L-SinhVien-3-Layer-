using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public  class BAL_SV
    {
        DALSV dal = new DALSV();

        public DataTable getInfo()
        {
            // tra ve bang trong Balsv
            return dal.getInfo();
        }
        public Boolean Delete(string a)
        {
            return dal.Delete(a);
        }

        public DataTable searchClass_tb(string tb, string items)
        {
            return dal.searchClass_tb(tb, items);
        }
        public DataTable sort_Cbb(string aaa)
        {
            return dal.sortName(aaa);
        }
        // nhung tham so kiet bit thi cho thanh int 

        public bool Them(int Msv, string name, string Class, DateTime date, float dtb, int gender, int pic, int HocBa, int Cmnd)
        {
            return dal.Them(Msv, name, Class, date, dtb, gender, pic, HocBa, Cmnd);
        }
        public bool Update(int Msv, string name, string Class, DateTime date, float dtb, int gender, int pic, int HocBa, int Cmnd)
        {
            return dal.Update( Msv,  name, Class, date,  dtb,  gender,  pic, HocBa,  Cmnd);
        }

    }
}
