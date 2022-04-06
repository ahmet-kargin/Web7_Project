const buton = document.querySelector("button");
// buton.addEventListener("click",()=>{alert("Butona tıkladın")});
// const li = document.querySelector("li");
// li.addEventListener("click",()=>{alert("Hobaaa, React'i seçtin")});

//ul içindeki tüm li'leri dolacaşacak ve her birine eventlistener ekleyecek
eventEkle();
function eventEkle()
{
    const liElemanlari = document.querySelectorAll("li");
    liElemanlari.forEach(li=>{
        li.addEventListener("click",e=>{
            e.target.remove();
        })
    })
};

const ul = document.querySelector("ul");
buton.addEventListener("click",()=>{
    let li = document.createElement("li");
    li.textContent="JavaScript";
    //ul.append(li);
    ul.prepend(li);
    eventEkle();
})
