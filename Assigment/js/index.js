function showMenu() {
    document.querySelector(".dropdown-items").classList.toggle("show");
}


axios({
    method: 'get',
    url: 'https://v2.jokeapi.dev/joke/Programming'
})
    .then(function (response) {
        console.log(response);
        console.log(response.data.setup);

        let jokeSetup = document.querySelector(".jokeSetup");
        let jokePunchline = document.querySelector(".jokePunchline");
        jokeSetup.innerHTML = "<p>" + response.data.setup + "</p>";
        setTimeout(() => { jokePunchline.innerHTML = "<p>" + response.data.delivery + "</p>"; }, 4000);
    })
    //.catch(function (error) {
    //    console.log(error);
    //    axios.get;
    //});

function getNewJoke() {

    axios.get();
    console.log("worked");
}