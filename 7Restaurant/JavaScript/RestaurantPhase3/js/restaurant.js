
const NrRecipes=5;
var mealPrice = 0;
var menu = new Array(NrRecipes);
var priceDish = new Array(NrRecipes);
var order = new Array();

let pm500 = 500;
let pm200 = 200;
let pm100 = 100;
let pm50 = 50;
let pm20 = 20;
let pm10 = 10;
let pm5 = 5;

function menuStart() 
{
/*     let pm500 = 500;
    let pm200 = 200;
    let pm100 = 100;
    let pm50 = 50;
    let pm20 = 20;
    let pm10 = 10;
    let pm5 = 5; */

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

    //Output order by Alert

    let message = "";

    for (i = 0; i < order.length; i++) 
    {
        message += "Plato num: " + i + " es: " + order[i] + "##";
    }
    alert(message);

    phase3();
}

function phase3()
{
    var exit = false;
    var index=0;

    alert("Han escogido " + order.length + " platos y son:");

    for (i=0; i<order.length; i++)
    {
        exit = false;
        index = 0;
        do
        {
            if (order[i].toUpperCase() == menu[index].toUpperCase())
            {
                mealPrice += priceDish[index];
                exit = true;
            }
            index++;
        }
        while (!(exit) && (index != NrRecipes));

        if (!exit)
        {
            alert("El plato: " + order[i] +" no está en la carta de este restaurante.");
        }
        else
        {
            alert("Has pedido el plato: " + order[i] + " y la comida de momento cuesta: " + mealPrice);
        }
    }
    alert("El coste total de la comida es: " + mealPrice);

    payment();

}

function payment()
{
    var rest = mealPrice;

    alert("Puedes pagar con tarjeta de crédito o con cash. Si pagas en cash el desglose es:");

    var restp500 = checkBill(rest, pm500);
    var restp200 = checkBill(restp500, pm200);
    var restp100 = checkBill(restp200, pm100);
    var restp50 = checkBill(restp100, pm50);
    var restp20 = checkBill(restp50, pm20);
    var restp10 = checkBill(restp20, pm10);
    var restp5 = checkBill(restp10, pm5);

    if (restp5 == 0)
    {
        alert("Deseamos haya tenido una buena comida, hasta la próxima !!!");
    }
}

function checkBill(amount, bill)
{
    if ((Math.trunc(amount / bill)) > 0)
    {
        alert((Math.trunc(amount / bill)) + " billetes de " + bill);
        amount -= (Math.trunc(amount / bill) * bill);
    }
    return amount;
}
