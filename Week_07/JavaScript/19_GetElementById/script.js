const baslik = document.getElementById("baslik");
console.log(baslik);

const hatalar = document.getElementsByClassName("hata");
//bu metodun dönüş tipi HTMLCollections'dır.
//HTMLCollections'ın içinde foreach ile dönülmez.
console.log(hatalar);

const paragraflar = document.getElementsByTagName("p");
console.log(paragraflar);