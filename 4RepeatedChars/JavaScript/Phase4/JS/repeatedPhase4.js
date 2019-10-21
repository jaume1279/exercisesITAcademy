


let nom = ['C', 'i', 'b', 'e', 'r', 'n', 'a', 'r', 'i', 'u', 'm'];
let salidaNom = "Nom: <br>";
let s;



for (i = 0; i < nom.length; i++) {

    salidaNom += nom[i].toString() + "-";

}

document.getElementById("Phase4").innerHTML = salidaNom;

// Phase 4

let cognom = ['B', 'a', 'r', 'c', 'e', 'l', 'o', 'n', 'a'];
let salidaCognom = "Cognom: <br>";

for (i = 0; i < cognom.length; i++) {

    salidaCognom += cognom[i].toString() + "-";
}

document.getElementById("Phase4a").innerHTML = salidaCognom;


// Fusion

let fullname = [];
let salidaFullname = "'";

fullname = nom;
fullname.push('_');

for (i = 0; i < cognom.length; i++) {
    fullname.push(cognom[i]);
}


// Salida de Fullname

for (i = 0; i < fullname.length; i++) {

    salidaFullname += fullname[i].toString() + "',";
}

document.getElementById("Phase4b").innerHTML = salidaFullname;

