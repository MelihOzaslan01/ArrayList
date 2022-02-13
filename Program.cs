using System.Collections;

ArrayList list = new ArrayList();
 /* list.Add("Osman");
list.Add('A');
list.Add(2);
list.Add(false); */


// Liste İçeriğine Erişim
Console.WriteLine("******** Listeye Erişim *******");
//Console.WriteLine(list[2]);

/*foreach (var item in list)
{
    Console.WriteLine(item);
}
*/

// AddRange 
Console.WriteLine("***** Add Range ******");

 // string[] renkler = { "Mavi", "Kırmızı", "Kahverengi", "Yeşil", "Sarı" };
List<int> sayilar = new List<int>() { 1,2,6,7,334,14,75,43,655,234,13455,10978};

list.AddRange(sayilar);
 //list.AddRange(renkler);

foreach (var item in list)
{
    Console.WriteLine(item);
}


// Sort Sıralama 

Console.WriteLine("******** Sort *******");
list.Sort();

foreach (var item in list)
{
    Console.WriteLine(item);
}

// Binary Search 
Console.WriteLine("******** Binary Search *******");

Console.WriteLine(list.BinarySearch(75));

// Reverse
Console.WriteLine("********* Reverse *******");
list.Reverse();
foreach (var item in list)
{
    Console.WriteLine(item);
}

// Clear
Console.WriteLine("********* Clear *******");
list.Clear();
foreach (var item in list)
{
    Console.WriteLine(item);
}


