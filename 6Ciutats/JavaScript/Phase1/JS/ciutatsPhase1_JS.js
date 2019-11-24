function menu() {

    var city1 = "";
    var city2 = "";
    var city3 = "";
    var city4 = "";
    var city5 = "";
    var city6 = "";

    city1 = document.getElementById("Ciutat1").value;
    city2 = document.getElementById("Ciutat2").value;
    city3 = document.getElementById("Ciutat3").value;
    city4 = document.getElementById("Ciutat4").value;
    city5 = document.getElementById("Ciutat5").value;
    city6 = document.getElementById("Ciutat6").value;

    message = "<br>Les ciutats introduïdes són: " + city1 + " # " + city2 + " # " + city3 + " # " + city4 + " # " + city5 + " # " + city6;

    document.getElementById("sortida").innerHTML = message;
}
