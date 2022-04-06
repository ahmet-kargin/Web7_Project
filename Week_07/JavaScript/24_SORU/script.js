let notlar=[];
for(i=0; i<10; i++){
    notlar[i]=Math.trunc(Math.random()*100);
}
console.log(notlar);

let icerik = document.querySelector("div");
let html=``;
notlar.forEach(not=>{
    let durum="basarili";
    if(not<50) durum="basarisiz";
    html+=`<p class=${durum}>${not}</p>`;
})
icerik.innerHTML= html;