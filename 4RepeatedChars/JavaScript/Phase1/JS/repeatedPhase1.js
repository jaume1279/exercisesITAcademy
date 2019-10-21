


let nom = ['J', 'a', 'u', 'm', 'e'];
let salida = "";


for (i = 0; i < nom.length; i++) {

    salida += nom[i].toString() + "-";
}

document.getElementById("Phase1").innerHTML = salida;


