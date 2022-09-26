using System;

namespace Crystals
{
    class Program
    {
        static void Main(string[] args)
        {
            int money;
            int booksCount;

            int bookPrice = 4;

            Console.WriteLine($"Гарри развернул второй листок бумаги, который не заметил вчера, и начал читать.");
            Console.WriteLine($"— И это все можно купить в Лондоне? — ахнул Гарри.");
            Console.WriteLine($"— Если знаешь, где искать, — ответил Хагрид.");
            Console.WriteLine($"— Но сначала надо твои денежки забрать.");
            Console.WriteLine();
            Console.Write($"Какую сумму взять в Гринготсе? ");
            money = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"с полной сумкой денег Вы отправились в книжный магазин");
            Console.WriteLine();

            Console.WriteLine($"«Курсическая книга заговоров и заклинаний» (первый курс). Миранда Гуссокл: {bookPrice} галеона");
            Console.WriteLine($"«История магии». Батильда Бэгшот: {bookPrice} галеона");
            Console.WriteLine($"«Теория магии». Адальберт Уоффлинг: {bookPrice} галеона");
            Console.WriteLine($"«Руководство по перевоплощению для начинающих». Эмерик Свитч: {bookPrice} галеона");
            Console.WriteLine($"«Тысяча магических трав и грибов». Филли-да Спора: {bookPrice} галеона");
            Console.WriteLine($"«Магические отвары и зелья». Жиг Мышьякофф: {bookPrice} галеона");
            Console.WriteLine($"«Фантастические звери: места обитания». Ньют Саламандер: {bookPrice} галеона");
            Console.WriteLine($"«Темные силы: пособие по самозащите». Квентин Тримбл: {bookPrice} галеона");
            Console.WriteLine($"");

            Console.Write($"Сколько книг желаете купить? ");
            booksCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            money -= booksCount * bookPrice;

            Console.WriteLine($"в Вашей сумке {booksCount} книг и {money} галеонов");
        }
    }
}
