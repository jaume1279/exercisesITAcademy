


let nom = ['C', 'i', 'b', 'e', 'r', '6', 'a', 'r', 'i', 'u', 'm'];
let salida = "";
let s;


for (i = 0; i < nom.length; i++) {

    if ((nom[i].toUpperCase().toString() == "A") || (nom[i].toUpperCase().toString() == "E") || (nom[i].toUpperCase().toString() == "I") || (nom[i].toUpperCase().toString() == "O") || (nom[i].toUpperCase().toString() == "U")) {
        s = "Vocal";
    }
    else {
        s = "Consonante";
    }
    if(!isNaN(nom[i])){
        s = "Els noms de persones no tenen numeros."
    }

    salida += nom[i].toString() + "-" + s + "<br>";
}
//alert(salida);
document.getElementById("Phase2").innerHTML = salida;


