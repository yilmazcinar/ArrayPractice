int[] sayilar = new int[10];

for (int i = 0; i < sayilar.Length; i++) 
{
    sayilar[i] = i+1;
}

foreach (var item in sayilar)
{

    Console.WriteLine(item);
}

Console.WriteLine("\nDiziye eklemek istediğiniz yeni sayıyı giriniz.  \n");

int yeniSayi = Convert.ToInt32(Console.ReadLine());

Array.Resize(ref sayilar, sayilar.Length+1);

sayilar[sayilar.Length-1] = yeniSayi;

var siraliDizi = sayilar.OrderByDescending(x => x).ToArray();



Console.WriteLine("Dizinin büyükten küçüğe sıralanmış hali.");

foreach (var item in siraliDizi)
{
    Console.WriteLine(item);
}


