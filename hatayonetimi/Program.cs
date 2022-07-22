// Hata Yonetimi
//try
//{
//Console.WriteLine("Bir sayi giriniz");
//int sayi=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Girmis oldugunuz sayi sudur:"+ sayi);
//}
//catch(Exception ex){
//    Console.WriteLine("Hata"+ex.Message);
//}
//finally
//{
//    Console.Write("islem tamamlandi");
//}

try
{
    //int a=int.Parse(null);
    // int a=int.Parse("test");
    int a=int.Parse("569409809978");

}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Bos arguman  girdiniz.");
    Console.WriteLine(ex);
}
catch (FormatException ex)
{
    Console.WriteLine("Veri tipi uygun degil.");
    Console.WriteLine(ex);
}
catch (OverflowException ex)
{
    Console.WriteLine("Cok buyuk ya da cok buyuk bir deger girdiniz.");
    Console.WriteLine(ex);
}
   finally
   {
    Console.Write("islem tamamlandi");
   }