// let yas=15;
// if (yas>18) {
//     console.log("Ehliyet alabilir.")
// }else
// {
//     console.log("Ehliyet alamaz.")
// }

//const sifre="dsfsfsdsf!sadfasdfas";
// if (sifre.length>=12) {
//     console.log("Çok güçlü şifre!")
// }else if(sifre.length>=8){
//     console.log("Güçlü şifre!")
// }else{
//     console.log("Şifre geçersiz, lütfen yeni şifre belirleyin.")
// }

// if (sifre.length>=12 && sifre.includes("!")) {
//     console.log("Çok güçlü şifre");
// }else if(sifre.length>=8 && sifre.includes("!")){
//     console.log("Güçlü şifre");
// }else{
//     console.log("100 lira fazla ödeyerek yeni bir şifre almaya ne dersin?");
// }

// let ad="Gülşah";
// if (ad=="Gülşah" || ad=="Sevim") {
//     console.log("Giriş başarılı");
// } else {
//     console.log("Giriş başarısız");
// }

let ad="Gülşah2";
let durum=null;
var durum2=null;
if (ad=="Gülşah" || ad=="Sevim")
{
    durum=true;
} else
{
    durum=false;
}

if(!durum){
    console.log("Başarısız");
}