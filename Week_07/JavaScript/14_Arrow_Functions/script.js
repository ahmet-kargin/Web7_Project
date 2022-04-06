// function topla(sayi1,sayi2){
//     return sayi1 + sayi2;
// }

// const topla = (sayi1,sayi2) => sayi1 + sayi2;
// console.log(topla(60,55));

// const kareAlan = kenar => kenar **2;
// console.log(kareAlan(8));

// const mesajYaz = () => console.log("Merhaba");
// mesajYaz();

/*
Dışarıdan ürün fiyat bilgileri ve uygulanacak vergi oranını alan
ve bu bilgilere göre her ürünün vergili fiyatı ve toplam vergili
fiyatı hesaplayıp konsola yazan functionı hazırlayın.
Örnek:
1.Ürünün fiyatı: 10
2.Ürünün fiyatı: 20
3.ÜRünün fiyatı: 30
Vergi oranı: 0.2
Sonuç: 
1.Ürün: 12
2.Ürün: 24
3.Ürün: 36
Toplam: 72
*/

const fatura = (urunFiyatlari,vergiOrani) => {
    let toplam=0;
    for(let i=0; i < urunFiyatlari.length; i++){
        let vergiDahilUrunFiyati = urunFiyatlari[i]*(1+vergiOrani);
        console.log(`${i+1}.Ürün: ${vergiDahilUrunFiyati}`);
        toplam += vergiDahilUrunFiyati;
    }
    return toplam;
}

console.log(fatura([10,20,30,60,40,33,66,4346,555,44,332],0.2));