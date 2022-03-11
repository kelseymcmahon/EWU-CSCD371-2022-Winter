function showMenu() {
    document.querySelector(".dropdown-items").classList.toggle("show");
}

function getJoke() {

    let jokeSetup = document.querySelector(".jokeSetup");
    let jokePunchline = document.querySelector(".jokePunchline");

    jokeSetup.innerHTML = "";
    jokePunchline.innerHTML = "";

    axios.get('https://v2.jokeapi.dev/joke/Programming')
        .then(function (response) {

            console.log(response);

            if (response.data.type == "single") {
                jokeSetup.innerHTML = "<p>" + response.data.joke + "</p>";
            }
            else {
                jokeSetup.innerHTML = "<p>" + response.data.setup + "</p>";
                setTimeout(() => { jokePunchline.innerHTML = "<p>" + response.data.delivery + "</p>"; }, 4000);
            }
        })
        .catch(function (error) {

            jokeSetup.innerHTML = "<p>Error getting joke, try again in a few moments</p>";
            console.log('Error', error.message);
            console.log(error.config);
        });
}

getJoke();

function makeBlue() {
    document.querySelector("body").classList.toggle("make-blue");
    document.querySelector(".nav-bar").classList.toggle("make-blue");
    document.querySelector(".card-header").classList.toggle("make-blue");
}

function makeFancy() {
    document.querySelector("body").classList.toggle("change-font");
}

function johnny() {
    document.querySelector(".card").classList.toggle("johnny");
    document.querySelector(".jokeSetup").classList.toggle("joke-johnny");
    document.querySelector(".jokePunchline").classList.toggle("joke-johnny");
}
