using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVien
    {
      
            public int Msv { get; set; }
            public string Name { get; set; }
            public string Class { get; set; }
            
            public DateTime Date { get; set; }
            public double dtb { get; set; }
            public Boolean gender { get; set; }
           public  bool Pic { get; set; }
           public  bool HocBa { get; set; }
            public bool Cmnd { get; set; }
            public SinhVien()
            {

            }
            public SinhVien(int Msv, string name, string Class, DateTime Date, double dtb, Boolean GenDer, bool Pic, bool HocBa, bool cmnd)
            {   
                this.Msv = Msv;
                this.Name = name;
                this.Class = Class;
                this.Date = Date;
                this.dtb = dtb;
                this.gender = GenDer;
                this.Pic = Pic;
                this.HocBa = HocBa;
                this.Cmnd = cmnd;
            }
        }
    }

