const newTaskButton = document.querySelector("#newTaskButton");
const newTaskTextBox = document.querySelector("#newTaskTextBox");
const taskList = document.querySelector("#taskList");
const ul = document.querySelector("#ul");
let html=``;

newTaskButton.addEventListener("click", newTask);

function newTask(){
    if(newTaskTextBox.value==""){
        alert("Açıklama kısmını boş bırakmayınız!");
    }else{
        html += `<li>${newTaskTextBox.value}<span>X</span></li>`;//span etiketi ekleyerek, kapatma için gerekli x işaretlerini koyduk
        ul.innerHTML=html;
        newTaskTextBox.value=""//yeni giriş için textboxı boşalttık
        newTaskTextBox.focus();//yeni giriş yapıldıktan sonra yeniden textboxa konumlandık
        let deleteTaskButtons=ul.querySelectorAll("span");//her li içine koyduğumuz span'ları seçtik
        //şimdi de o seçtiğimiz spanların içinde dönerek her + işaretine eventlistener ekliyoruz
        for(let i=0; i < deleteTaskButtons.length; i++){
            deleteTaskButtons[i].addEventListener("click",(e)=>{
                e.target.parentElement.remove();//+ işaretine yani spanımıza click yapılınca parent elementi olan li'yi sildiriyoruz
                //silme işlemi sayfanın o anki html hali üzerinde yapılıyor. biz ise yukarıda
                //yaptığımız üzere html adlı değişkenimizle sayfaya bastırıyoruz görevleri.
                //bu yüzden html değişkenimize, sayfanın o anki bir adet silinmiş halinin html'ini
                //aktarmamız gerek.
                html=ul.innerHTML;
            });
        }
    }
}