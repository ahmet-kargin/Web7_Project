const secilen = document.querySelector("#logo");
const slide = document.querySelectorAll(".slide");
let slideNo=0;
const slidesNumber = slide.length;
secilen.addEventListener("click",e=>{
    console.log(e.target);
})

/* Slider kodları */
function previous(){
    slideNo--;
    slideShow(slideNo);
}
function next(){
    slideNo++;
    slideShow(slideNo);
}

function slideShow(slideNumber){
    slideNo = slideNumber;
    if(slideNumber>=slidesNumber){
        slideNo=0;
    }
    if(slideNumber<0){
        slideNo=slidesNumber-1;
    }
    for(let i=0; i < 4; i++){
        slide[i].style.display="none";
    }
    slide[slideNo].style.display="block";
}

slideShow(slideNo);


/* Todo List Codes*/
// Sayfadaki elementlerin seçilmesi
const newTaskButton = document.querySelector("#newTaskButton");
const newTaskTextBox = document.querySelector("#newTaskTextBox");
const taskListBox = document.querySelector("#taskListBox");
let deleteTaskButtons = document.querySelectorAll(".fa-times");
const deleteAllButton = document.querySelector("#deleteAllButton");
 
console.log(newTaskButton);
// Butonlara dinleyici tanımlanması
newTaskButton.addEventListener("click", newTask);
deleteAllButton.addEventListener("click", deleteAll);
 
// Fonksiyonlar
function newTask() {
    if (newTaskTextBox.value == "")      
        alert("Lütfen boş bırakmayınız.");
    else {
        var li = document.createElement("li");
        li.innerText = newTaskTextBox.value
        var i = document.createElement("i");
        i.classList = "fas fa-times";
        li.appendChild(i);
        taskListBox.appendChild(li);
        newTaskTextBox.value = "";
        newTaskTextBox.focus();
        deleteTaskButtons = document.querySelectorAll(".fa-times");
        for (var i = 0; i < deleteTaskButtons.length; i++) {
            deleteTaskButtons[i].addEventListener("click", deleteTask);
        }
    }
}

function deleteTask() {
    this.parentElement.remove();
}
 
function deleteAll() {
    let answer = confirm("Hepsini Kalıcı Olarak Silmek İstediğinize Emin Misiniz?");
    if (answer == true) {
        let deletedAll = document.querySelectorAll("#taskListBox>li");
        for (let i = 0; i < deletedAll.length; i++) {
            deletedAll[i].remove();
        }
    }
}