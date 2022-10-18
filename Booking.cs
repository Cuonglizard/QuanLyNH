namespace QuanLy
{
    public class Booking
    {

        public int? TableNo{get;set;}
        public double? Price{get;set;}
        public List<MonAn> MonAnDadat{get;set;}


        public Booking()
        {
            MonAnDadat= new List<MonAn>();
        }

        public void Input()
        {
            bool isFind = false;
            Table? currentTable= null;

            Console.WriteLine("Nhap Ban muon Dat");

            while(true)
            {
                TableNo=Utility.ReadInt();
                isFind=false;
                foreach(Table table in DataCenter.TableList)
                {
                    if(table.SoThuTu==TableNo && table.Status==false)
                    {
                        table.Status=true;
                        currentTable=table;
                        isFind=true;
                        break;
                    }
                }

                if(isFind)
                {
                    break;
                } else
                {
                    Console.WriteLine("Nhap Lai");
                }
            }
            isFind = false;
            Console.WriteLine("Danh sach mon an:");
            foreach(MonAn monan in DataCenter.MonAnList)
            {
                monan.Display(); 
            }
            Console.WriteLine("nhap mon an ban muon dat va nhap end de thoat!");
            Datmon();
        }

        public void Datmon()
        {
            while(true)
            {
                string name=Console.ReadLine();
                foreach(MonAn monan in DataCenter.MonAnList)
                {
                    if(monan.Name==name)
                    {
                        MonAnDadat.Add(monan);
                    }
                }
                if(name=="end")
                break;
            }
        }

        public double ThanhToan()
        {   
            double _Price=0;
            foreach(MonAn monan in MonAnDadat)
            {
                _Price=monan.Price+_Price;
            }
            return _Price;
        }

        public void ShowMonDaAn()
        {
            foreach(MonAn monan in MonAnDadat)
            {
                monan.Display();
            }
        }

    }
}