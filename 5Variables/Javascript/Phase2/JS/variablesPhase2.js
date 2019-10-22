
const annyTraspas = 1948;

const freq = 4;

var anny = 1970;

var nrLeap = 0;



for (i = annyTraspas; i <= anny; i = i + 4) {
    nrLeap += 1;
}

document.getElementById("phase2").innerHTML = "Els anys de traspas entre " + annyTraspas + " i " + anny + " son: " + nrLeap;


