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

    var message = "<br>Les ciutats introduïdes són: " + city1 + " # " + city2 + " # " + city3 + " # " + city4 + " # " + city5 + " # " + city6;

    document.getElementById("sortida").innerHTML = message;

    var arrayCiutats = [city1, city2, city3, city4, city5, city6];

    arrayCiutats.sort();

    document.getElementById("sortidaPhase2").innerHTML = "Ciutats dins del array i ordenades alfabèticament per nom:<br>" + arrayCiutats;;

    var arrayCiutatsModificades = arrayCiutats;

    var index = 0;

    for (index = 0; index < arrayCiutats.length; index++) {
        arrayCiutatsModificades[index] = arrayCiutats[index].replace("a", "4");
    }

    document.getElementById("sortidaPhase3").innerHTML = arrayCiutatsModificades;

    // Phase4

    var city1array = new Array(city1.length);
    var city2array = new Array(city2.length);
    var city3array = new Array(city3.length);
    var city4array = new Array(city4.length);
    var city5array = new Array(city5.length);
    var city6array = new Array(city6.length);

    city1array = city1.split("");
    city2array = city2.split("");
    city3array = city3.split("");
    city4array = city4.split("");
    city5array = city5.split("");
    city6array = city6.split("");

    var message1 = "";
    var message2 = "";
    var message3 = "";
    var message4 = "";
    var message5 = "";
    var message6 = "";

    for (i = 1; i <= city1array.length; i++)
        message1 += (city1array[city1array.length - i]);

    for (i = 1; i <= city2array.length; i++)
        message2 += (city2array[city2array.length - i]);

    for (i = 1; i <= city3array.length; i++)
        message3 += (city3array[city3array.length - i]);

    for (i = 1; i <= city4array.length; i++)
        message4 += (city4array[city4array.length - i]);

    for (i = 1; i <= city5array.length; i++)
        message5 += (city5array[city5array.length - i]);

    for (i = 1; i <= city6array.length; i++)
        message6 += (city6array[city6array.length - i]);


    document.getElementById("sortidaPhase3").innerHTML = message1 + "<br>" + message2 + "<br>" + message3 + "<br>" + message4 + "<br>" + message5 + "<br>" + message6;

}
