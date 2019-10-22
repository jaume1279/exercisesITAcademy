
const annyTraspas = 1948;

const freq = 4;

var anny = 1970;

var nrLeap = 0;

var annysTraspFinsNaixement="";

for (i = annyTraspas; i <= anny; i = i + 4) {
    nrLeap += 1;
    annysTraspFinsNaixement += i +" @ ";
}

document.getElementById("phase3").innerHTML = "Els anys de traspas entre " + annyTraspas + " i " + anny + " son: " + nrLeap;

document.getElementById("phase3a").innerHTML = "I son: " + annysTraspFinsNaixement;


//var isLeap=False;

if(IsOrNot(anny)){
    alert("L'any" + anny + " SI es de traspas");
}
else{
    alert("L'any" + anny + " NO es de traspas");
}





function IsOrNot(anno){

    if(((anno%4==0) && !(anno%100==0)) || (anno%400==0)){
        return true;
    }
    else{
        return false;
    }
}



