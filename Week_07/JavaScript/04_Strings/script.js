let email="websabahgrubu@wissenakademie.com";
console.log(email);

let kursAd="Web Geliştirme";
console.log(kursAd);

let tumu = kursAd + "-" + email;
console.log(tumu);

console.log(email[3]);
console.log(email.length);

let siraNo=email.indexOf("@");//İstediğimiz karakterin ilk bulduğunun indexini bulur
console.log(siraNo);

let siraNo2=email.indexOf(" ");//Eğer bulamazsa, -1 döndürür.
console.log(siraNo2);

let sonSiraNo=email.lastIndexOf("i");//İstediğiniz karakterin son sıradakinin indexini bulur
console.log(sonSiraNo);

let kursAdBuyuk=kursAd.toUpperCase();
console.log(kursAdBuyuk);

let kursAdBuyukLocale=kursAd.toLocaleUpperCase();
console.log(kursAdBuyukLocale);

let kursAdKucuk=kursAd.toLowerCase();
console.log(kursAdKucuk);

let ulke="IRAK";

let ulkeKucuk=ulke.toLowerCase();
console.log(ulkeKucuk);

let ulkeKucukLocale=ulke.toLocaleLowerCase();
console.log(ulkeKucukLocale);

let metin="BİR GÜZEL GELİNCİK";

console.log(metin.slice(4,10));
console.log(metin.substring(9,4));
console.log(metin.substr(4,5));
console.log(metin.replace("İ","U"));//bulduğu ilk İ'yi U yapar.
//metin adındaki değişkenin içeriği tamamen küçük harfe dönerek, sonuna "geldi"
//sözcüğü eklensin.

