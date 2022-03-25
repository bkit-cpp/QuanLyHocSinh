using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh
{
    public class HocSinh:Nguoi
    {
        private List<HocSinh> dshs = new List<HocSinh>();
        public string MSSV { get; set; }
        public float DiemToan { get; set; }
        public  float Diemvan { get; set; }
        public float Diemanh { get; set; }
        public HocSinh()
        {

        }
        public HocSinh(string Ten, int Tuoi,string diachi,string MSSV, float DiemToan,float DiemVan, float Diemanh):base( Ten, Tuoi,diachi)
        {

            this.MSSV = MSSV;
            this.DiemToan = DiemToan;
            this.Diemvan = Diemvan;
            this.Diemanh = Diemanh;
           
        }
        public void dauvao()
        {
            base.input();
            Console.WriteLine("Nhap vao MSSV:");
            MSSV = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap vao Diem Toan");
            DiemToan = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao Diem van");
            Diemvan = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao diem Anh");
            Diemanh = float.Parse(Console.ReadLine());
         }
        public bool TestDiem()
        {
            if (DiemToan< 0 
                || DiemToan>10
                ||Diemvan<0
                ||Diemvan>10
                ||Diemanh<0
                ||Diemanh>10)
                return false;
            return true;
        }
        public float Sum()
        {
            return Diemanh + DiemToan + Diemvan;
        }
      public string Tostring()
        {
            base.toString();
            return "Hien Thi Ket qua:" + MSSV + "Tong Diem:" + Sum();
        }
        public bool ThemHocSinh(HocSinh hs)
        {
            bool trungmssv = false;
            foreach(HocSinh a in dshs)
            
                if (a.MSSV == hs.MSSV)
                {
                    trungmssv = true;
                    break;
                }
                if(trungmssv==true)
                return false;
                dshs.Add(hs);
                return true;
            
        }
        public void Hienthidanhsachhs()
        {
            foreach(HocSinh a in dshs)
            {
                Console.WriteLine(a);
            }
        }
        public HocSinh timkiemhs(string mssv)
        {
            
           foreach(HocSinh b in dshs)
             if (b.MSSV == mssv)
               return b;
            return null;
                
            
        }
        public bool xoahs(string MSSV)
        {
            HocSinh c = timkiemhs(MSSV);
            if (c == null)
                return false;
            dshs.Remove(c);
            return true;
        }

    }
}
