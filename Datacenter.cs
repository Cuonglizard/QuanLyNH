using System.Collections.Generic;
namespace QuanLy
{
  public class DataCenter
    {

        public static List<Table> TableList{get;set;}

        public static List<MonAn> MonAnList{get;set;}

        public static List<Booking> BookingList{get;set;}
         private static DataCenter? _instance = null;

        public DataCenter()
        {
            TableList =new List<Table>();
            MonAnList =new List<MonAn>();
            BookingList=new List<Booking>();
        }

        public static DataCenter GetInstance()
        {
            if(_instance == null)
            {
                _instance = new DataCenter();
            }
            return _instance;
        }

        public void InputMonAn()
        {
           Console.WriteLine("==================================");
           Console.WriteLine("Nhap So mon an Can them:");
           int N=Utility.ReadInt();
           for(int i=0;i<N;i++)
            {
                MonAn monan = new MonAn();
                monan.Input();
                MonAnList.Add(monan);
            }
        }
        public void InputTable()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Nhap so Ban Cua Quan An:");
            int n=Utility.ReadInt();
            for(int i=0;i<n;i++)
            {
                Table table=new Table(i+1);
                TableList.Add(table);
            }
        }

        public static void InputBooking()
        {
            if(TableList.Count==0)
            {
                Console.WriteLine("==================================");
                Console.WriteLine("chua nhap danh sach Ban:");
                return;
            }
            else
            {
                Console.WriteLine("==================================");
                Booking booking = new Booking();
                booking.Input();
                BookingList.Add(booking);
            }
        }

        public void Monandadat()
        {   
            Console.WriteLine("==================================");
            Console.WriteLine("Nhap Ban Muon Show:");
            int n;
            n=Utility.ReadInt();
            foreach(Booking booking in BookingList)
            {
                if(booking.TableNo==n)
                {
                    booking.ShowMonDaAn();
                }
            }
        }


        public void StaticProfit()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Nhap Ban muon thanh toan Hoa don:");
            int numberTable;
            numberTable=Utility.ReadInt();
            double Bill;
            bool check=false;
            foreach(Booking book in BookingList)
            {
                if(numberTable==book.TableNo){
                 Console.WriteLine("Hoa Don cua Ban {0} la {1}",book.TableNo, book.ThanhToan());
                 check=true;
                }
                break;
            } 
            // reset status ve 0
            if(check==true)
            {
                Console.WriteLine("Da Thanh Toan chua ?");
                Console.WriteLine("1.Paid!_________2.unpaid");
                int i;
                i=Utility.ReadInt();
                if(i==1)
                {
                    foreach(Table table in TableList)
                    {
                        if(numberTable==table.SoThuTu)
                        {
                            table.Status=false;
                        }
                    }
                    foreach(Booking booking in BookingList)
                    {
                        if(booking.TableNo==numberTable)
                        {
                            BookingList.Remove(booking);
                        }
                    }
                }
                else{
                    Console.WriteLine("Chua Thanh Toan!");
                }
            }
            else
            {
                Console.WriteLine("Ban nay chua co nguoi dung!");
            }
        }

        public void SeachTableEmpty()
        {
            if(TableList.Count==0)
            {
                Console.WriteLine("==================================");
                Console.WriteLine("Chua nhap so luong ban!");
                return;
            }
            else
            {
                Console.WriteLine("==================================");
                foreach(Table table in TableList)
              {
                if(table.Status==false)
                {
                    Console.WriteLine("ban {0} ",table.SoThuTu);
                }
              }
            }
        }
    }
}