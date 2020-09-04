$(document).ready(function () {
    $('.owl-carousel').owlCarousel({
        loop: true,
        // margin:10,
        nav: true,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 1
            },
            1000: {
                items: 1
            }
        }

    })
    $(".owl-dots").addClass("d-none")
    $(".owl-nav").addClass("d-none")


    $(".servicesHome").mouseover(function () {
        $(this).children().last().children().first().stop(true, true).animate({
            top: "20px"
        });
        $(this).children().last().children().last().stop(true, true).animate({
            top: "30px"
        });
    })

    $(".servicesHome").mouseleave(function () {
        $(this).children().last().children().first().stop(true, true).animate({
            top: "-20px"
        });
        $(this).children().last().children().last().stop(true, true).animate({
            top: "103px"
        });
    })



    $(".searchIcon").click(function () {
        $(".searchForm").toggleClass("d-none");
    })

    $(".searchIconResponsive").click(function () {
        $(".searchFormResponsive").toggleClass("d-none");
    })


    $(".header-question").click(function () {
        // $(this).slideDown();
        $(this).next().children().first().slideToggle(function () {
            $(".body-text").css("display", "block !important")
        });
        $(this).children().first().toggleClass("d-none")
        $(this).children().first().next().toggleClass("d-none")

    })
    $(".down").click(function () {
        $(".responsiveRow").toggleClass("d-none")
        // $(".responsiveRow").slideToggle()
    })


    $(".mainLiResponsiveD").click(function () {

        $(this).next().slideToggle();


    })

    // $(".responsiveUl").addClass("d-none")

    $(".burger").click(function () {

        $(this).parent().parent().next().slideDown();
        $(this).addClass("d-none");
        $(this).next().removeClass("d-none")
    })
    $(".cancel").click(function () {

        $(this).parent().parent().next().slideUp();
        $(this).addClass("d-none");
        $(this).prev().removeClass("d-none");

    })

    $(".service-img").mouseover(function () {
        $(this).css({ "opacity": "0.6", "transition": "0.7s" })

    })
    $(".service-img").mouseleave(function () {
        $(this).css({ "opacity": "1", "transition": "0.7s" })

    })

    let serviceLists = $(".servicesNamesList li");
    let services = $(".serviceDetails");
    let serviceNames = $(".namme")
    for (let list of serviceLists) {
        $(list).click(function () {
            $(".selected").removeClass("selected");
            $(this).addClass("selected")
            
            
        })
    }

    let galleryListName = $(".galleryNameList li")
    let galleryList = $(".gallery");


    for (let list of galleryListName) {
        $(list).click(function () {
            $(".selected").removeClass("selected");
            $(this).addClass("selected")
            let data_id = $(this).attr("data-id")
            for (let gallery of galleryList) {
                if (data_id == $(gallery).attr("data-id")) {
                    $(gallery).removeClass("d-none")
                } else {
                    $(gallery).addClass("d-none")
                }
                if ($(this).attr("data-id") == "all") {
                    $(gallery).removeClass("d-none")
                }
                console.log($(this).attr("data-id"));
            }

        })

    }
    $(".gallery").mouseover(function () {
        $(this).children().last().children().first().animate({
            top: "20px"

        });
        $(this).children().last().children().last().animate({
            top: "17px",
        })
    })
    $(".gallery").mouseleave(function () {
        $(this).children().last().children().first().animate({
            top: "-20px"

        });
        $(this).children().last().children().last().animate({
            top: "60px",
        })
    })

    $(".worker").mouseover(function () {
        $(this).children().last().children().stop(true, true).animate({
            top: "0px",
            transition: "0.3s ease"
        });
        $(this).children().first().children().stop(true, false).animate({
            opacity: "0.6",
            transition: "0.3s ease"
        })
        $(this).children().last().children().children().mouseover(function () {
            console.log($(this).children().last().children().children().children());
        })

    })
    $(".worker").mouseleave(function () {
        $(this).children().last().children().stop(true, true).animate({
            top: "66px",
            transition: "0.3s ease 0s"
        })
        $(this).children().first().children().stop(true, false).animate({
            opacity: "1",
            transition: "0.3s ease 0s"
        })
    })

    $(".ourteamdetailImg").mouseover(function () {
        $(this).children().last().children().stop(true, false).animate({
            top: "0px",
            transition: "0.3s ease 0s"
        })
    })
    $(".ourteamdetailImg").mouseleave(function () {
        $(this).children().last().children().stop(true, true).animate({
            top: "61px",
            transition: "0.3s ease 0s"
        })
    })
    let imagesShop = $(".downImgShopDetail")
    for (let img of imagesShop) {
        $(img).click(function () {
            $(this).parent().children().first().attr("src", $(this).children().attr("src"));
        })
    }
    let count = 0;
    $(".minus").click(function () {
        if (count > 0) {
            count -= 1;
        }

        if ($(this).parent().next().text() != "0") {
            $(this).parent().next().text(count);
        }

    })
    $(".plus").click(function () {
        count += 1;

        $(this).parent().prev().text(count);


    })

    if (localStorage.getItem("basket") == null) {
        localStorage.setItem("basket", JSON.stringify([]))
    }
    let addToCartAll = $(".addToCart");
    // function AddToCartDetail() {
    //     $(".addToCartDetail").click(function (e) {
    //         e.preventDefault();
    //         // if (localStorage.getItem("basket") == null) {
    //         //     localStorage.setItem("basket", JSON.stringify([]))
    //         // }
    //         // let basket = JSON.parse(localStorage.getItem("basket"))
    //         let name = $(this).parent().children().first().text()
    //         let data_idDetail=
    //         // localStorage.setItem("basket", JSON.stringify(basket))
    //         // CountBasket()

    //     })

    // }
    // AddToCartDetail()

    for (let addToCart of addToCartAll) {

        $(addToCart).click(function (e) {
            if (localStorage.getItem("basket") == null) {
                localStorage.setItem("basket", JSON.stringify([]))
            }
            e.preventDefault()
            let basket = JSON.parse(localStorage.getItem("basket"))

            let name = $(this).parent().children().first().next().children().first().text();
            let ImgSrc = $(this).parent().children().first().children().first().attr("src")
            let ShopData_id = $(this).parent().attr("data-id")
            let price = $(this).prev().text();
            let priceInt = $(this).prev().text().split("$")
            let exist = basket.find(p => p.Id == ShopData_id)
            if (exist == undefined) {
                basket.push({
                    Id: ShopData_id,
                    Name: name,
                    Image: ImgSrc,
                    Price: price,
                    PriceInt: priceInt[1].split(".")[0],
                    Count: 1,

                })
            }
            else {
                exist.Count += 1;
            }
            localStorage.setItem("basket", JSON.stringify(basket))
            CountBasket()

        })
    }

    function CountBasket() {
        let basket = JSON.parse(localStorage.getItem("basket"));
        $("#bbb").text(basket.length)

    }
    $(CountBasket())

    function CustomizeTableView() {
        let cart = JSON.parse(localStorage.getItem("basket"))
        if (cart.length == 0) {
            $(".emptyCart").removeClass("d-none")
            $(".returnShopBtn").removeClass("d-none")
            $(".cartDetailTable").addClass("d-none")
            $(".buttoncolumn").addClass("d-none")
        }
        if (cart.length != 0) {
            $(".emptyCart").addClass("d-none");
            $(".returnShopBtn").addClass("d-none")
            $(".cartDetailTable").removeClass("d-none")
            $(".buttoncolumn").removeClass("d-none")
        }

    }
    CustomizeTableView()

    function UpdateTable() {
        let products = JSON.parse(localStorage.getItem("basket"))
        document.getElementById("tb").innerHTML = ""
        for (let product of products) {
            let tdDeleteAll = document.createElement("td")
            let tdImg = document.createElement("td")
            let tdProName = document.createElement("td")
            let tdPrice = document.createElement("td")
            let tdCount = document.createElement("td")
            let tdTotal = document.createElement("td")
            let tdDecriese = document.createElement("td")
            let deleteAllIcon = document.createElement("i")
            let decreeseIcon = document.createElement("i");
            decreeseIcon.className = "fas fa-minus decreeseElementCount"
            tdDecriese.append(decreeseIcon)
            deleteAllIcon.className = "fas fa-times deleteAllCart"
            tdDeleteAll.append(deleteAllIcon);
            let img = document.createElement("img")
            img.setAttribute("src", product.Image);
            img.style.width = "25%"
            img.style.height = "auto"
            tdImg.append(img);
            let Id = document.createElement("td");
            Id.innerText = product.Id
            Id.className = "d-none"
            tdProName.innerText = product.Name;
            tdPrice.innerText = product.Price;
            tdCount.innerText = product.Count;
            tdTotal.innerText = product.Count * product.PriceInt + "$"
            let tr = document.createElement("tr");

            tr.append(Id, tdDeleteAll, tdImg, tdProName, tdPrice, tdCount, tdTotal, tdDecriese)


            document.getElementById("tb").append(tr)
            DecreeseProduct()
            $(".deleteAllCart").click(function () {
                CustomizeTableView()
                let cart = JSON.parse(localStorage.getItem("basket"))
                let proId = Number($(this).parent().prev().text())
                let thisPro = cart.find(p => p.Id == proId)
                for (let i = 0; i < cart.length; i++) {
                    if (cart[i].Id == thisPro.Id)
                        cart.splice(i, 1)
                }
                console.log();

                localStorage.setItem("basket", JSON.stringify(cart))
                UpdateTable()
                CountBasket()

            })

        }
    }
    UpdateTable()
    function DecreeseProduct() {
        $(".decreeseElementCount").click(function () {
            CustomizeTableView()
            let proCountTable = Number($(this).parent().prev().prev().text())
            let cart = JSON.parse(localStorage.getItem("basket"))
            let productId = Number($(this).parent().parent().children().first().text())
            let ThisProduct = cart.find(p => p.Id == productId)
            if (proCountTable > 0 && ThisProduct != null) {

                proCountTable -= 1;
                ThisProduct.Count = proCountTable


            }
            if (proCountTable < 1) {
                for (let i = 0; i < cart.length; i++) {
                    if (cart[i].Id == ThisProduct.Id) {
                        cart.splice(i, 1)
                    }
                }


            }
            localStorage.setItem("basket", JSON.stringify(cart))
            UpdateTable()
            CountBasket()
        })
    }








})
