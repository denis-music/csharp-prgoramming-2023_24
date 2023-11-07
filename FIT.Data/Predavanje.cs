namespace FIT.Data
{
    public class Predavanje
    {
        int godina;
        public int Godina { get; set; }
        public string Tema { get; set; }

        public Predavanje(string tema, int godina)
        {
            Godina = godina;        
            Tema = tema;
        }
    }
}
