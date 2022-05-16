using System;
using System.Collections;
class Program{
public static void Main(string[] args){

a1:
try{
  while(true){
System.Console.WriteLine("Fibonacci dizisi içerisinden 2 index seçiniz.");
İlkkapı();
}

static void İlkkapı(){a2:
System.Console.WriteLine("Lütfen 1. indexi giriniz:");
int index1 =Convert.ToInt16(Console.ReadLine());
System.Console.WriteLine("Lütfen 2. indexi giriniz:");
int index2 =Convert.ToInt16(Console.ReadLine());
if(index1>index2){int n=index1; index1=index2; index2=n;}
else if(index1==index2){System.Console.WriteLine("Eşit sayı girdiniz, mantık hatası var. Tekrar deneyin.");goto a2;}
else{
Ortalama(index1, index2);}}

static void Ortalama(int index1, int index2){
int[] fibonacci = new int[9999999];
fibonacci[0]=1; fibonacci[1]=1;
for(int x=0;x<=128;x++){
fibonacci[x+2]=fibonacci[x]+fibonacci[x+1];}
int yedek = 0;
for(int y=index1;y<=index2;y++){
yedek = fibonacci[y] + yedek;}
float cevap=yedek/((index2-index1)+1);
System.Console.WriteLine("2 index arasında kalan bütün sayıların ortalaması: {0}",cevap);}}
catch{System.Console.WriteLine("Bir hata oluştu. Ana menüye gidiyoruz.");goto a1;
}
}
}
