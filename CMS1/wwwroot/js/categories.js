function GetProducts() {

    const request = new XMLHttpRequest();

    request.open("GET", "https://cms.winkadfreshdropsbottledwater.co.ke/Products/");

    request.send();

    request.onload = () => {

        console.log(request);

        if (request.status === 200) {

            console.log(JSON.parse(request.response));

        } else {

            console.log(`error ${request.status} ${request.statusText}`);
        }
    };
}
