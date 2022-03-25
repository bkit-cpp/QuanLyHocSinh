using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh
{
    class Program
    {
       public static List<HocSinh> dshocsinh = new List<HocSinh>();
         static void QLHOCSINH()
        {
            do
            {
                
                Console.WriteLine("\t\t\t\t\t\t=============================================\t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t\t*  1.Nhap Thong Tin Hoc Sinh Can Tra Cuu    *\t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t\t*  2.Hien Thi Thong Tin Hoc Sinh Can Tra Cuu*\t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t\t*  3.Tim Kiem Thong Tin Can Tra Cuu         *\t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t\t*  4.Sua thong Tin Hoc Sinh                 *\t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t\t*  5.Xoa Thong Tin Hoc Sinh                 *\t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t\t*  6.Thoat                                  *\t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t\t=============================================\t\t\t\t\t");
                Console.WriteLine("Vui long Nhap Lua Chon");
                int choice = int.Parse(Console.ReadLine());
                Nguoi ng = new Nguoi();
                HocSinh hs1 = new HocSinh();
                HocSinh hs2 = new HocSinh();
                HocSinh hs3 = new HocSinh();
                switch(choice)
                {
                    case 1:
                        hs1.dauvao();
                        hs1.TestDiem();
                        hs1.TestTuoi();
                        hs1.ThemHocSinh(hs1);
                        dshocsinh.Add(hs1);
                        hs2.dauvao();
                        hs2.ThemHocSinh(hs2);
                        dshocsinh.Add(hs2);
                        hs3.dauvao();
                        hs3.ThemHocSinh(hs3);
                        dshocsinh.Add(hs3);
                        break;
                    case 2:
                       foreach(HocSinh b in dshocsinh)
                        {
                            Console.WriteLine(b.Tostring());
                            dshocsinh.ToString();
                        }
                        
                        break;
                    case 3:
                        hs1.dauvao();
                        hs1.TestDiem();
                        hs1.TestTuoi();
                        hs1.ThemHocSinh(hs1);
                        dshocsinh.Add(hs1);
                        hs2.dauvao();
                        hs2.ThemHocSinh(hs2);
                        dshocsinh.Add(hs2);
                        hs3.dauvao();
                        hs3.ThemHocSinh(hs3);
                        dshocsinh.Add(hs3);
                        string mssv = Convert.ToString(Console.ReadLine());
                       HocSinh c= hs1.timkiemhs(mssv);
                        if(c!=null)
                        {
                            Console.WriteLine("Tim Thay Ket Qua");
                        }
                        else
                        {
                            Console.WriteLine("Khong tim Thay");
                        }
                        break;
                    case 4:
                        hs1.dauvao();
                        hs1.TestDiem();
                        hs1.TestTuoi();
                        hs1.ThemHocSinh(hs1);
                        dshocsinh.Add(hs1);
                        hs2.dauvao();
                        hs2.ThemHocSinh(hs2);
                        dshocsinh.Add(hs2);
                        hs3.dauvao();
                        hs3.ThemHocSinh(hs3);
                        dshocsinh.Add(hs3);
                        string Mssv= Convert.ToString(Console.ReadLine());
                        HocSinh d = hs1.timkiemhs(Mssv);
                        if(d==null)
                        {
                            d.Ten = Console.ReadLine();
                        }
                        
                        break;
                    case 5:
                        hs1.dauvao();
                        hs1.TestDiem();
                        hs1.TestTuoi();
                        dshocsinh.Add(hs1);
                        hs2.dauvao();
                        dshocsinh.Add(hs2);
                        hs3.dauvao();
                        dshocsinh.Add(hs3);

                        if (dshocsinh.Remove(hs1))
                        {
                            foreach(HocSinh b in dshocsinh)
                            {
                                Console.WriteLine(b.Tostring());
                                dshocsinh.ToString();
                            }
                        }
                        break;
                    case 6:
                        break;
                }

            } while (true);
        }
        static void Main(string[] args)
        {
            QLHOCSINH();
        }
    }
}
