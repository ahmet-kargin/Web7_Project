// const icerik = document.querySelector("p");

// icerik.classList.add("deneme");
// icerik.classList.add("baslik");
// icerik.classList.remove("deneme");
// console.log(icerik.classList);


const paragraflar = document.querySelectorAll("p");
paragraflar.forEach(p=>{
    if(p.textContent.includes("error")){
        p.classList.add("error");
    }
    if(p.textContent.includes("success")){
        p.classList.add("success");
    }
})