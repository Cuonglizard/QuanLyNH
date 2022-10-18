namespace QuanLy
{
    public class MonAn
    {
        public string Name {get;set;}
        public double Price {get;set;}
        

        // public MonAn(string _Name,double _Price)
        // {
        //     Name=_Name;
        //     Price=_Price;
        // }


        public void Input()
        {
            Console.WriteLine("Nhap Ten Mon An:");
            Name = Console.ReadLine();
            
            Console.WriteLine("Nhap gia mon An:");
            Price = Utility.ReadInt();
        }

        public void Display()
        {
            Console.WriteLine("Mon :{0} -------- Gia:{1}$",Name,Price);
        }
    }
}