function menu() 
{
    let pm500 = 500;
    let pm200 = 200;
    let pm100 = 100;
    let pm50 = 50;
    let pm20 = 20;
    let pm10 = 10;
    let pm5 = 5;

    let mealPrice = 0;

    const NrRecipes = 5;

    let menu = new Array(NrRecipes);
    let priceDish = new Array(NrRecipes);

    // Phase 2

    let counter = 0;

    while (counter < NrRecipes) 
    {
        menu[counter] = document.getElementById("plato" + (counter + 1)).value;
        priceDish[counter] = parseInt(document.getElementById("precio" + (counter + 1)).value);
        counter++;
    }

    var message = "";
    counter = 0;

    while (counter < NrRecipes) 
    {
        message += "Plato: " + menu[counter] + "..... Precio: " + priceDish[counter] + "<br>";
        counter++;
    }

    let btnContinue = '<button id="boton" type="button" onclick="btnOption();">Continuar</button>';
    document.getElementById("phase2a").innerHTML = "Los platos del menú son:<br> " + message + btnContinue;
}


function btnOption() 
{
    alert("Introducimos los platos que ordena el cliente:");

    var order = new Array();
    let option = 1;
    let counter = 0;

    do 
    {
        order[counter] = prompt("Plato?:");
        counter++;
        do 
        {
            option = prompt("Mas platos? (1=Si; 0=Terminar)");
        }
        while (option > 2 || option < 0);
    }
    while (option == 1);

    //Output List by Alert

    let message = "";

    for (i = 0; i < order.length; i++) 
    {
        message += "Plato num: " + i + " es: " + order[i] + "##";
    }
    alert(message);
}
