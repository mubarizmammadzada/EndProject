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


    $(".servicesHome").mouseover(function(){
        $(this).children().last().children().first().stop(true,true).animate({
            top:"20px"
        });
        $(this).children().last().children().last().stop(true,true).animate({
            top:"30px"
        });
    })

    $(".servicesHome").mouseleave(function(){
        $(this).children().last().children().first().stop(true,true).animate({
            top:"-20px"
        });
        $(this).children().last().children().last().stop(true,true).animate({
            top:"103px"
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
            let data_id = $(this).attr("data-id");
            for (let service of services) {
                if (data_id == $(service).attr("data-id")) {
                    $(service).removeClass("d-none")
                } else {
                    $(service).addClass("d-none")
                }
                // console.log("ok");
            }
            for (let serviceName of serviceNames) {
                if (data_id == $(serviceName).attr("data-id")) {
                    $(serviceName).removeClass("d-none")
                } else {
                    $(serviceName).addClass("d-none")
                }
            }
        })
    }
    let galleryListName = $(".galleryNameList li")
    let galleryList = $(".gallery");

    
    for (let list of galleryListName) {
        $(list).click(function () {
            $(".selected").removeClass("selected");
            $(this).addClass("selected")
            let data_id = $(this).attr("data-id")
            for (let gallery of galleryList){
                if (data_id == $(gallery).attr("data-id")) {
                    $(gallery).removeClass("d-none")
                } else {
                    $(gallery).addClass("d-none")
                }
                if($(this).attr("data-id")=="all"){
                    $(gallery).removeClass("d-none")
                }
                console.log($(this).attr("data-id"));
            }
            
        })

    }
    $(".gallery").mouseover(function(){
        $(this).children().last().children().first().animate({
            top:"20px"
            
        });
        $(this).children().last().children().last().animate({
            top:"17px",
        })
    })
    $(".gallery").mouseleave(function(){
        $(this).children().last().children().first().animate({
            top:"-20px"
            
        });
        $(this).children().last().children().last().animate({
            top:"60px",
        })
    })

    $(".worker").mouseover(function(){
        $(this).children().last().children().animate({
            top:"0px",
            transition:"0.3s ease"
        });
        $(this).children().first().children().animate({
            opacity:"0.6",
            transition:"0.3s ease"
        })
        $(this).children().last().children().children().mouseover(function(){
            console.log($(this).children().last().children().children().children());
        })
          
    })
    $(".worker").mouseleave(function(){
        $(this).children().last().children().stop(true,true).animate({
            top:"66px",
            transition:"0.3s ease 0s"
        })
        $(this).children().first().children().animate({
            opacity:"1",
            transition:"0.3s ease 0s"
        })
    })

    $(".ourteamdetailImg").mouseover(function(){
        $(this).children().last().children().stop(true,false).animate({
            top:"0px",
            transition:"0.3s ease 0s"
        })
    })
    $(".ourteamdetailImg").mouseleave(function(){
        $(this).children().last().children().stop(true,true).animate({
            top:"61px",
            transition:"0.3s ease 0s"
        })
    })


})

