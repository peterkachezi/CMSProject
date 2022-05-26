function StartMe() {
    section("PageContents", [
        "div|id=mainBanner|style=position:relative",
        "br",
        "table|id=sbLaptop|class=bgGreen w100",
        "br",
        "table|id=sbTopSellingProducts|class=bgGreen w100",
        "br",
        "table|id=sbNewProducts|class= w100"
    ]);


    section("mainBanner", [
        "img|src=product01.png|style=position:absolute; top:10px; left:20px; width:5rem; height:5rem",
        "button|class=bannerButton|style=position:absolute; top:10px; left:100px;|Home",
        "button|class=bannerButton|style=position:absolute; top:10px; left:170px;|Accessories|onclick=OpenAccessories()",
        "button|class=bannerButton|style=position:absolute; top:10px; left:280px;|Categories |onclick=OpenCategories()",
        "button|class=bannerButton|style=position:absolute; top:10px; left:400px;|Laptops |onclick=OpenLaptops()",
        "button|class=bannerButton|style=position:absolute; top:10px; left:500px;|Contact Us |onclick=OpenContactUs()",
        "label|id=mainBannerOpts"
    ]);

    section("mainBannerOpts", [
        "button|class=bannerButton|Your Cart",
        "button|class=bannerButtonRoundLite|Sign In",
        "label|style=padding:5px|",
        "button|class=bannerButtonRoundDark|Join Now"
    ]);

    section("sbLaptop", [
        "img|src=hotdeal.png|style=width:100%; height:20rem",

    ]);

    section("sbTopSellingProducts", [
        "td|id=sbTopSellingProductsTDRight|class=right wtText lrgText"
    ]);


    section("sbTopSellingProductsTDRight", [
        "div|Top Selling Products",
        "img|src=product01.png|style= height:20rem",
        "img|src=product02.png|style= height:20rem",
        "img|src=product03.png|style= height:20rem",
        "img|src=product05.png|style= height:20rem",

    ]);

    section("sbNewProducts", [
        "td|id=sbNewProductsDRight|class=right wtText lrgText"
    ]);


    section("sbNewProductsDRight", [
        "div|class=newProduct| New Products",
        "img|src=product08.png|style= height:20rem",
        "img|src=product09.png|style= height:20rem",
        "img|src=product07.png|style= height:20rem",
        "img|src=product05.png|style= height:20rem",

    ]);


    GetCategories();
    GetProducts();
}

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


function GetCategories() {

    const request = new XMLHttpRequest();

    request.open("GET", "https://cms.winkadfreshdropsbottledwater.co.ke/Categories/");

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

function OpenAccessories() {

    var url = "/Home/Accessories/";

    window.location.href = url;
}

function OpenCategories() {

    var url = "/Home/Categories/";

    window.location.href = url;
}

function OpenLaptops() {

    var url = "/Home/Laptops/";

    window.location.href = url;
}

function OpenContactUs() {

    var url = "/Home/ContactUs/";

    window.location.href = url;
}