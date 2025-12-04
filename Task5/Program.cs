namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Cashier cashier1 = new Cashier("Joe", "sale of a T-shirt", 5000);
            Cashier cashier2 = new Cashier("Bob", "Sales of a Spices", 4500);
            Cashier cashier3 = new Cashier("David", "Sales of a Woolen-Jacket", 10000);
            Cashier cashier4 = new Cashier("Anderson", "Sales of a Electric Kettle", 9500);
            Cashier cashier5 = new Cashier("Steves", "Sales of a Sport shoe", 15000);

            List<Cashier> CashierSales = [cashier1, cashier2, cashier3, cashier4, cashier5];

            var totalNumberOfCashiers = CashierSales.Count();

            var totalSalesOfTheDay = CashierSales.Sum(cashier => cashier.sale);

            var highestSales = CashierSales.Max(cashier => cashier.sale);

            var lowestSales = CashierSales.Min(cashier => cashier.sale);

            var averageSales = CashierSales.Average(cashier => cashier.sale);

            Console.WriteLine($"\nTotal Number of Cashier : {totalNumberOfCashiers}. \nTotal Sales of the Day : {totalSalesOfTheDay}. " +
                $"\nHighest Sales : {highestSales}. \nLowest Sales : {lowestSales}. \nAverage Sales : {averageSales}.");


            Applicants applicant1 = new Applicants("John", 19);
            Applicants applicant2 = new Applicants("Steve", 22);
            Applicants applicant3 = new Applicants("Mark", 17);
            Applicants applicant4 = new Applicants("Rachel", 24);
            Applicants applicant5 = new Applicants("Sophia", 16);
            Applicants applicant6 = new Applicants("Emily", 18);

            List<Applicants> ApplicantsList = [applicant1, applicant2, applicant3, applicant4, applicant5, applicant6];

            var isApplicantUnder18 = ApplicantsList.Any(applicant => applicant.age <= 18);

            var isEveryApplicantAbove16 = ApplicantsList.All(applicant => applicant.age > 16);

            Console.WriteLine($"\nAre there Any Applicant under 18 ? : {isApplicantUnder18}.");
            Console.WriteLine($"\nIs All the applicants are above 16 ? : {isEveryApplicantAbove16}.\n");


            Music music1 = new Music("Song of Storms", "11 minutes");
            Music music2 = new Music("Lost Woods", "3 minutes");
            Music music3 = new Music("Gerudo Valley", "4 minutes");
            Music music4 = new Music("Zelda's Lullaby", "6 minutes");
            Music music5 = new Music("Great Fairy's Fountain", "5 minutes");

            List<Music> MusicList = [music1, music2, music3, music4, music5];

            var firstMusic = MusicList.First();
            var lastMusic = MusicList.Last();

            var firstMusicAbove4MinDuration = MusicList.First(music =>
            {
                var durationParts = music.songDuration.Split(' ');

                if (durationParts.Length == 2 && int.TryParse(durationParts[0], out int minute))
                {
                    return minute > 4;
                }
                return false;
            });



            var firstSongLongerThan10Min = MusicList.FirstOrDefault(


                music =>
                {
                    var durationParts = music.songDuration.Split(' ');

                    if (durationParts.Length == 2 && int.TryParse(durationParts[0], out int minute))
                    {
                        if (minute > 10)
                        {
                            return true;
                        }
                    }

                    return false;
                }


             );

            Console.WriteLine($"\nFirst Music : {firstMusic.songName}, Duration : {firstMusic.songDuration}.");
            Console.WriteLine($"\nLast Music : {lastMusic.songName}, Duration : {lastMusic.songDuration}.");

            Console.WriteLine($"\nFirst music longer than 4 minutes: {firstMusicAbove4MinDuration}");
            Console.WriteLine($"\nFirst song longer than 10 minutes: {firstSongLongerThan10Min}");

        }

    }
}