// const pDegeri = document.querySelector("p");
// console.log(pDegeri);
// console.log(pDegeri.innerText);
// console.log(pDegeri.textContent);
// pDegeri.textContent="Engin Niyazi";
// pDegeri.innerText="Barcelona";

// const baslik = document.querySelector("#header");
// baslik.textContent="JS Frameworks";

// const paragraflar = document.querySelectorAll("p");
// paragraflar.forEach( p => {
//     p.textContent += " eklenen ifade";
//     console.log(p.textContent);
// }
// )
const icerik = document.querySelector(".content");
const ogrenciler = ["Gülşah","Oğuzhan","Metehan"];
console.log(icerik.innerHTML);
ogrenciler.forEach(ogrenci=>{
    icerik.innerHTML += `<li>${ogrenci}</li>`;
})














