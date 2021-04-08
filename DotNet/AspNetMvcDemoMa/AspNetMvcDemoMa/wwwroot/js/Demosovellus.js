
// Avata paikallinen json-tiedosto ja tallentaa uudet inputit paikalliseen json-tiedostoon
// Marika Aaltokari 8.4.2021 
<script type="text/javascript" src="~/books.json"></script>
console.log("Skriptin suoritus alkaa");
const fs = require('fs');

$("#saving").click(function () {
    console.log("Nappia painettu");
    const etunimi = $("#authorNames").val();
    const sukunimi = $("#authorSurname").val();
    const nimi = $("#bookTitle").val();
    const suosikki = new Boolean($("#favorite").val());
    const päivämäärä = $("#savingDate").val();
    console.log(etunimi + sukunimi + nimi + suosikki + päivämäärä);

    //konstruktori
    Book kirja = new Book

    const kirja = {
        "id": "",
        "authorNames": etunimi,
        "authorSurname": sukunimi,
        "booktitle": nimi,
        "favorite": suosikki,
        "savingsDate": päivämäärä,
    }

    // convert JSON object to string
    const data = JSON.stringify(kirja);
    console.log("data:" + data);

    // write JSON string to a file
    fs.writeFile('books.json', data, (err) => {
        if (err) {
            throw err;
        }
        console.log("JSON data is saved.");
        alert("The read book is saved.");

    });
}