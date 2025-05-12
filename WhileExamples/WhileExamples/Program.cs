//Konosle ekranina 10 kere metin yazdirmak.

int sayac = 0;    
while (sayac < 10) // while dondugu sayacdan 10 kucuk oldugu surece calisir.
{
    Console.WriteLine("Kendime inaniyorum, ben bu yazilim isini hallederim.");
    sayac++;
}
//-----------------------------------------------------------------------------------------

// 1 ile 20 arasindaki sayilari konsol ekranina yazdirmak

int sayi = 1; 
while (sayi <= 20) // number degiskeni 1 den baslar 20 ye kadar artar.
{
    Console.WriteLine(sayi);
    sayi++;  // Dongu sonunda nuber degikkeninin degeri 1 artar.
}

//-----------------------------------------------------------------------------------------

//1 ile 20 arasindaki cift sayilari ekrana yazdirmak.

int number =1; 
while (number <=20)
{
    if (number % 2 == 0) // number degiskeni 2 ye bolunebiliyorsa cift sayidir.
    {
        Console.WriteLine(number);
    }
    number++; // number degiskeninin degeri 1 artar.
}
//-----------------------------------------------------------------------------------------

//50 ile 150 arasindaki sayilarin toplamini yazdirmak.

int sayi2 = 50;
int sum = 0;

while (sayi2 <= 150)
{
    sum += sayi2; 
    sayi2++;
}
Console.WriteLine($"Toplam sonucu :{sum}" );

//-----------------------------------------------------------------------------------------

// 1 ile 120 arasindaki tek ve cift sayilarin toplamalarini ayri ayri yazdirmak.

int sayi3 = 0;
int singleSum=0;    
int doubleSum = 0;

while (sayi3 <= 120)
{
    if(sayi3 % 2 ==0) // sayi3 degiskeni 2 ye bolunebiliyorsa cift sayidir.
    {
        doubleSum += sayi3;
    }
    else
    {
        singleSum += sayi3; // tek sayilarin toplami
    }
    sayi3++; // sayi3 degiskeninin degeri 1 artar.

}
Console.WriteLine($"Tek sayilarin Toplami : {singleSum}");
Console.WriteLine($"Cift sayilarin toplami : {doubleSum}");
