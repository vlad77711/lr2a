using System;
using ClassLibrary1;
namespace lab2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane[] arrLit;
            Console.Write("Введiть кiлькiсть Літаків: ");
            int cntLit = int.Parse(Console.ReadLine());
            arrLit = new Plane[cntLit];
            for (int i = 0; i < cntLit; i++)
            {
                Console.Write("Введiть назву літака: ");
                string sName_plane = Console.ReadLine();
                Console.Write("Введiть місто відправлення : ");
                string sCountry_departure = Console.ReadLine();
                Console.Write("Введiть місто прибуття: ");
                string sCountry_arrival = Console.ReadLine();
                Console.Write("Введiть номер літака : ");
                string sFlight_number = Console.ReadLine();
                Console.Write("Введіть кількість місць класу clasic  ");
                string spepolnumber_of_seats = Console.ReadLine();
                Console.Write("Введіть кількість місць класу lux: ");
                string slux_seats = Console.ReadLine();
                Console.Write("Чи обід безкоштовний? (y-так, n-нi): ");
                ConsoleKeyInfo keyeat = Console.ReadKey();
                Console.WriteLine();
                Plane OurPlane = new Plane();
                OurPlane.Name_plane = sName_plane;
                OurPlane.Country_departure = sCountry_departure;
                OurPlane.Country_arrival = sCountry_arrival;
                OurPlane.Flight_number = int.Parse(sFlight_number);
                OurPlane.pepolnumber_of_seats = int.Parse(spepolnumber_of_seats);
                OurPlane.lux_seats = int.Parse(slux_seats);
                OurPlane.eat = keyeat.Key == ConsoleKey.Y ? true : false;

                arrLit[i] = OurPlane;
            }
            foreach (Plane b in arrLit)
            {
                Console.WriteLine();
                Console.WriteLine(" ");
                Console.WriteLine("Данi про літак : ");
                Console.WriteLine("..................");
                Console.WriteLine("Назва літака : " + b.Name_plane);
                Console.WriteLine("Місто відправлення : " + b.Country_departure);
                Console.WriteLine("Місто прибуття : " + b.Country_arrival);
                Console.WriteLine("Номер літака : " + b.Flight_number.ToString());
                Console.WriteLine("кількість місць класу lux : " + b.pepolnumber_of_seats);
                Console.WriteLine("Rількість місць класу clasic : " + b.lux_seats.ToString());
                Console.WriteLine(b.eat ? "Обід безкоштовний " :
                "Обід платний");

                Console.WriteLine("Всього місць в літаку: " +
    b.seatss.ToString());
                Console.ReadKey();
            }}}}
