const fs = require('fs');

let array = fs.readFileSync("Numerot.txt").toString().split("\n");
//console.log(array);

//Convert string to integers/numbers
let numbers = array.map((i) => Number(i));
//console.log(numbers);

let summa=0;
let i;


for (i in numbers) {
        if (numbers[i] != ""){ //lisätty opelta
            luku = parseInt(numbers[i])
            summa += luku;
        }
    } 

console.log("Summa on "+ summa);

