
const annyTraspas = 1948;

const freq = 4;

var anny = 1970;

var nrLeap = 0;

var annysTraspFinsNaixement = "";

var message="";

for (i = annyTraspas; i <= anny; i = i + 4) {
    nrLeap += 1;
    annysTraspFinsNaixement += i + " @ ";
}

//document.getElementById("phase4").innerHTML = "Els anys de traspas entre " + annyTraspas + " i " + anny + " son: " + nrLeap;

//document.getElementById("phase4a").innerHTML = "I son: " + annysTraspFinsNaixement;


//var isLeap=False;

if (IsOrNot(anny)) {
    message="L'any " + anny + " SI es de traspas";
}
else {
    message="L'any " + anny + " NO es de traspas";
}


function IsOrNot(anno) {

    if (((anno % 4 == 0) && !(anno % 100 == 0)) || (anno % 400 == 0)) {
        return true;
    }
    else {
        return false;
    }
}


var nom = "Jaume";
var cognom1 = "Sabate";
var cognom2 = "Fabregat";

var dia = 18;
var mes = 10;
var anny = 1970;

var nomComplert = nom + " " + cognom1 + " " + cognom2;
var dataNaixement = dia + "/" + mes + "/" + anny;

document.getElementById("phase4").innerHTML = "El meu nom es: "+ nomComplert;

document.getElementById("phase4a").innerHTML = "Vaig nèixer el: " + dataNaixement + "<br><br>" + message;



