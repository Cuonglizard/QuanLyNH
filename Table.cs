namespace QuanLy
{
    public class Table
    {
        public bool Status{get;set;}
        public int SoThuTu{get;set;}


    public Table(int _SoThuTu)
    {
        Status= false;

        SoThuTu=_SoThuTu;
    }


    public void Display()
    {
        Console.WriteLine("Ban Thu {0}",SoThuTu);
    }

    }
}