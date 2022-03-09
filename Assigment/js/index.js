function showMenu() {
    document.querySelector(".dropdown-items").classList.toggle("show");
}

const sendGetRequest = async () => {
    try {
        const response = await axios.get('https://v2.jokeapi.dev/joke/Programming')
            .catch(function (error) {
                if (error.response) {
                    // The request was made and the server responded with a status code not in 200s
                    console.log(error.response.data);
                    console.log(error.response.status);
                    console.log(error.response.headers);
                } else if (error.request) {
                    // The request was made but no response was received
                    console.log(error.request);
                } else {
                    let jokeSetup = document.querySelector(".jokeSetup");
                    jokeSetup.innerHTML = "<p>Error getting joke, fetching another joke...</p>";
                    console.log('Error', error.message);
                    sendGetRequest();
                }
                console.log(error.config);
            });

        console.log(response);

        let jokeSetup = document.querySelector(".jokeSetup");
        let jokePunchline = document.querySelector(".jokePunchline");

        if (response.data.type == "single") {
            jokeSetup.innerHTML = "<p>" + response.data.joke + "</p>";
        }
        else {
            jokeSetup.innerHTML = "<p>" + response.data.setup + "</p>";
            setTimeout(() => { jokePunchline.innerHTML = "<p>" + response.data.delivery + "</p>"; }, 4000);
        }
    }
    catch (error) {
        console.error(error);
        jokeSetup.innerHTML = "<p>Error getting joke, fetching another joke...</p>";
        sendGetRequest();
    }
};

sendGetRequest();

function getNewJoke() {
    let jokeSetup = document.querySelector(".jokeSetup");
    let jokePunchline = document.querySelector(".jokePunchline");
    jokeSetup.innerHTML = "";
    jokePunchline.innerHTML = "";
    sendGetRequest();
}

function makeBlue() {
    document.querySelector("body").classList.toggle("make-blue");
    document.querySelector(".nav-bar").classList.toggle("make-blue");
    document.querySelector(".card-header").classList.toggle("make-blue");
}

function makeFancy() {
    document.querySelector("body").classList.toggle("change-font");
}

function doNotRunThis() {
    document.querySelector(".popup").classList.toggle("visible");
}

function johnny() {
    document.querySelector(".card").classList.toggle("johnny");
    document.querySelector(".jokeSetup").classList.toggle("joke-johnny");
    document.querySelector(".jokePunchline").classList.toggle("joke-johnny");
}
