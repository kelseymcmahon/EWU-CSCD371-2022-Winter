function showMenu() {
    document.querySelector(".dropdown-items").classList.toggle("show");
}

//axios({
//    method: 'get',
//    url: 'https://v2.jokeapi.dev/joke/Programming'
//})
//    .then(function (response) {
//        console.log(response);
//        console.log(response.data.setup);

//        let jokeSetup = document.querySelector(".jokeSetup");
//        let jokePunchline = document.querySelector(".jokePunchline");
//        jokeSetup.innerHTML = "<p>" + response.data.setup + "</p>";
//        setTimeout(() => { jokePunchline.innerHTML = "<p>" + response.data.delivery + "</p>"; }, 4000);
//    })
    //.catch(function (error) {
    //    console.log(error);
    //    axios.get;
    //});

//function getNewJoke() {

//    axios.get();
//    console.log("worked");
//}

const sendGetRequest = async () => {
    try {
        const response = await axios.get('https://v2.jokeapi.dev/joke/Programming');
        console.log(response.data);
        console.log(response);
        console.log(response.data.setup);

        let jokeSetup = document.querySelector(".jokeSetup");
        let jokePunchline = document.querySelector(".jokePunchline");
        jokeSetup.innerHTML = "<p>" + response.data.setup + "</p>";
        setTimeout(() => { jokePunchline.innerHTML = "<p>" + response.data.delivery + "</p>"; }, 4000);
    }
    catch (err) {
        console.error(err);
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