let yariCap=10;
const piSayisi=3.14;
console.log(piSayisi*yariCap**2);

console.log(15/6);

console.log(15%4);
console.log(piSayisi%2);

let sayi=145.5;
console.log(Math.trunc(sayi));//Ondalıklı kısmı söküp atar
console.log(Math.floor(sayi));//Tabana yuvarlar
console.log(Math.ceil(sayi));//Tavana yuvarlar
console.log(Math.round(sayi));//Matemetiksel kurallara uygun olarak yuvarlar

console.log("-------------------");
let i=10;
console.log(i++);//önce i'yi basar, sonra bir arttırır
//console.log(i);
console.log(++i);//önce bir arttırır, sonra i'yi basar

let sayi1 = 10;
let sayi2 = 50 + ++sayi1;
console.log(sayi2);
console.log(sayi1,sayi2);

