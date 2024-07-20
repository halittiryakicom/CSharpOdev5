//burada sorular doğru cevaplandıkça degeri artacak değişken tanımlandı.
int correctAnswer = 0;

//Soru-1
Console.WriteLine("What is the capital city of Turkey?");
Console.WriteLine("A) Ankara B) İstanbul");
string answer = Console.ReadLine().ToLower(); //burada kullanıcıdan cevap aldık ve büyük küçük harf duyarlılığını kaldırmak için toLower kullandık.

//cevabın kontrolü
if (answer == "a")
{
    Console.WriteLine("Congratulations! Correct answer.");
    correctAnswer++; //cevap doğru ise doğru sayısını tutan değişken artıyor.
}
else if (answer == "b")
    Console.WriteLine("Sorry, you wrong answer.");
else
    Console.WriteLine("Please, choose one of the answers a or b.");


//Soru-2
Console.WriteLine("Who is the USA president?");
Console.WriteLine("A) Donald Trump B) Joe Biden");
answer = Console.ReadLine().ToLower();
if (answer == "a")
    Console.WriteLine("Sorry, you wrong answer.");

else if (answer == "b")
{
    Console.WriteLine("Congratulations! Correct answer.");
    correctAnswer++;
}
else
    Console.WriteLine("Please, choose one of the answers a or b.");



//burada eğer kullanıcının yeterli puanı alıp almadığını kontrol ediyoruz.
if (correctAnswer >= 1)
{
    //eğer yeterli puan aldıysa sorumuzu soruyoruz
    //Soru-3
    Console.WriteLine("Where is the TAC MAHAL?");
    Console.WriteLine("A) India B) China");
    answer = Console.ReadLine().ToLower();

    if (answer == "a")
    {
        Console.WriteLine("Congratulations! Correct answer.");
        correctAnswer++;
    }
    else if (answer == "b")
        Console.WriteLine("Sorry, you wrong answer.");
    else
        Console.WriteLine("Please, choose one of the answers a or b.");

    //burada yarışmacımızın puanını kontrol ederek ödülü kazanıp kazanamadığını kontrol ediyoruz.d
    if (correctAnswer >= 2)
        Console.WriteLine("***** Congratulations, you won the 1 million TL prize. *****");
    else
        Console.WriteLine("Unfortunately, you did not win the prize because you did not get enough points.");
}
else
    Console.WriteLine("You didn't win the prize because you answered all the questions wrong.");