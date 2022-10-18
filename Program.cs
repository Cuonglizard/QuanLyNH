using System;


namespace QuanLy
{
    class Program
    {
        static void Main(string[] args)
        {
            int choose;

            do
            {
                ShowMenu();
                choose = Utility.ReadInt();

                switch(choose)
                {
                    case 1:
                        DataCenter.GetInstance().InputMonAn();
                        break;
                    case 2:
                        DataCenter.GetInstance().InputTable();
                        break;
                    case 3:
                        DataCenter.GetInstance().SeachTableEmpty();
                        Console.ReadLine();
                        break;
                    case 4:
                         DataCenter.InputBooking();
                        break;
                    case 5:

                        DataCenter.GetInstance().Monandadat();
                        Console.ReadKey();
                        break;
                    case 6:
                        DataCenter.GetInstance().StaticProfit();
                        break;
                    case 7:
                        Console.WriteLine("Thoat!!!");
                        break;
                    default:
                        Console.WriteLine("Nhap sai!!!");
                        break;
                }
            } while (choose != 7);
        }

        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Nhap Mon An");
            Console.WriteLine("2. Nhap So Ban");
            Console.WriteLine("3. Tim Ban Trong");
            Console.WriteLine("4. Dat Ban Va Mon An");
            Console.WriteLine("5. Show mon da dat");
            Console.WriteLine("6. Thanh Toan!");
            Console.WriteLine("7. Thoat");
            Console.WriteLine("Chon: ");
        }
    }
}
