
var person = {
    name: "Kelsey",
    year: 1992,
    weapon: "katana",
    getName: () => { return this.name; },
    age: function() { return new Date().getFullYear() - this.year; }
}

console.log("Hello World: " + person.getName());
console.log("Kelsey is " + person.age() + " years old");

function showName() {
    console.log(person.getName());
}

document.getElementById("mybutton").innerHTML = "<p>This is the answer!</p>";

