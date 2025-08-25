namespace BtkAcademyApp.Models
{

    public static class Repository
    {

        private static List<Candidate> applications = new(); // bir liste olusturduk ve bu liste statıc yanı her repositiry nesene olsutgunda yenı bır lıstel olusmuyor var olanın ustune eklıyor stack gıbı
        public static IEnumerable<Candidate> Applications { get { return applications; } }
        //Ienumarable koleksıyonu ıle sadece okunabılır bır koleksıyon olusturduk

        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);

          }
    }



}