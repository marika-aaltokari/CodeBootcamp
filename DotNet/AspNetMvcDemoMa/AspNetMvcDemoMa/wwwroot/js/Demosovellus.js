
// Avata paikallinen json-tiedosto ja tallentaa uudet inputit paikalliseen json-tiedostoon
// Marika Aaltokari 8.4.2021 

//<script type="text/javascript" src="~/bookshelf.json" ></script>
'use strict';


console.log("Skriptin suoritus alkaa")
const fs = require('fs');

$("#saving").click(function () {
    console.log("Nappia painettu");
    /*const etunimi = $("#authorNames").val();
    const sukunimi = $("#authorSurname").val();
    const kirjanNimi = $("#bookTitle").val(); 
    var Boolean suosikki = ($("#favorite").val();
    const päivämäärä = $("#savingDate").val();
    console.log(etunimi + sukunimi + nimi + suosikki + päivämäärä);*/

    let book = {
        AuthorNames: $("#authorNames").val(),
        AuthorSurname: $("#authorSurname").val(),
        Booktitle: '$("#bookTitle").val()',
        Favorite: '$("#favorite").val()',
        SavingDate: '$("#savingDate").val()'
    };

    //conver JSON object to string
    let data = JSON.stringify(book, null, 2);
    console.log("data:" + data);

    //Write Json string  to file
    fs.writeFile('bookshelf.json', data, (err) => {
        if (err) throw err;
        console.log('Data written to file');
    });

    console.log('This is after the write call');
    
    console.log("JSON data is saved.");
    alert("The new read book is saved.");

    });
   