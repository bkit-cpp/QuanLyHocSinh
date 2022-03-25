using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh
{
    public class Nguoi
    {
        
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public string diachi { get; set; }
        public HocSinh ttcb { get; set; }
        public Nguoi()
        {

        }
        public Nguoi(string Ten, int Tuoi, string diachi)
        {
            this.Ten = Ten;
            this.Tuoi = Tuoi;
            this.diachi = diachi;
           
        }
        public void input()
        {
            Console.WriteLine("Nhap Ho va Ten:");
            Ten = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap Tuoi:");
            Tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Dia Chi:");
            diachi = Convert.ToString(Console.ReadLine());
        }
        public int TestTuoi()
        {
            if (2022 - Tuoi >= 2004)
                return Tuoi;
            return 0;
        }
        public string toString()
        {
            return "Hien Thi Ket Qua:" + " " 
                + "Ten:" + Ten 
                + "Tuoi:" + Tuoi + "Dia Chi:" + diachi;
        }
       
        
    }
}
