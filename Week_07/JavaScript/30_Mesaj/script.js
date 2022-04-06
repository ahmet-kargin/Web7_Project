const form = document.querySelector("form");

form.addEventListener("submit", (e)=>{
    e.preventDefault();
    // let state = true;
    const userName = form.userName.value;
    const userNamePattern = /^[a-z0-9A-ZöğüışçÖĞÜİŞÇ]{6,10}$/gm;
    if(userNamePattern.test(userName)){
        form.querySelector("#message").textContent="Başarıyla kullanıcı adını oluşturdunuz.";
        form.userName.setAttribute("class","success");
    }else{
        form.querySelector("#message").textContent="Kullanıcı adı a-z ve 0-9 arasındaki karakterler dışında karakterlerden oluşamaz.";
        form.userName.setAttribute("class","error");
    }













    // for(let i=0; i<userName.length;i++){
    //     if(userName.charCodeAt(i)<97 || userName.charCodeAt(i)>122){
    //         alert("Olmadı yar, su testisine yar!");
    //         state=false;
    //         break;
    //     }
    // }
    // if(state==true) alert("Tebrikler, geçerli kullanıcı adı.");
})