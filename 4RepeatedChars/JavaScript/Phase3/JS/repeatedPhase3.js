


let nom = ['C', 'i', 'b', 'e', 'r', 'n', 'a', 'r', 'i', 'u', 'm'];
let salida = "";
let s;



for (i = 0; i < nom.length; i++) {

    if ((nom[i].toUpperCase().toString() == "A") || (nom[i].toUpperCase().toString() == "E") || (nom[i].toUpperCase().toString() == "I") || (nom[i].toUpperCase().toString() == "O") || (nom[i].toUpperCase().toString() == "U")) {
        s = "Vocal";
    }
    else {
        s = "Consonante";
    }
    if (!isNaN(nom[i])) {
        s = "Els noms de persones no tenen numeros."
    }

    salida += nom[i].toString() + "-" + s + "<br>";

}

document.getElementById("Phase3").innerHTML = salida;

let myDictionary = new Map();
let repeats = 0;

for (j = 0; j < nom.length; j++) {

    repeats = 1;
    for (j1 = j + 1; j1 < (nom.length); j1++) {
        if (nom[j] == nom[j1]) repeats++;
    }
    if (!(myDictionary.has(nom[j]))) {
        myDictionary.set(nom[j], repeats);
    }

}

// Print myDictionary

let salida2 = "";

var iterator1 = myDictionary[Symbol.iterator]();

for (let item of iterator1) {
    salida2 += item + "<br>";
}

document.getElementById("Phase3a").innerHTML = salida2;
