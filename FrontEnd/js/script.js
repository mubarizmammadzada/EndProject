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


    $(".layer").mouseover(function(){
      $(this).prev().children().last().animate({
          bottom:"0px",
          transition:"0.7s linear"
      });
      $(this).prev().children().first().animate({
        top:"0px",
        transition:"0.7s linear"
    });
    $(this).css({"opacity":"0.4","transition":"0.7s"})
        
    })
    $(".layer").mouseleave(function(){
        $(this).prev().children().last().animate({
            bottom:"-90px" ,
            transition:"0.7s linear"
        })
        $(this).prev().children().first().animate({
            top:"-25px",
            transition:"0.7s linear"
        })
        $(this).css({"opacity":"0","transition":"0.7s"})
    })
    $(".service-content").mouseover(function(){
        $(this).next().css({"opacity":"0.4"});
        $(this).children().last().animate({
            bottom:"0px",
            transition:"0.7s linear"
        })
        $(this).children().first().animate({
            top:"0px",
            transition:"0.7s linear"
        })
        
    })
    $(".service-content").mouseleave(function(){
        $(this).next().css({"opacity":"0.4"})
        $(this).children().last().animate({
            bottom:"-90px",
            transition:"0.7s linear"
        })
        $(this).children().first().animate({
            top:"-25px",
            transition:"0.7s linear"
        })
    })

    $(".searchIcon").click(function(){
        $(".searchForm").toggleClass("d-none");
    })

    $(".searchIconResponsive").click(function(){
        $(".searchFormResponsive").toggleClass("d-none");
    })


    $(".header-question").click(function(){
        // $(this).slideDown();
        $(this).next().children().first().slideToggle(function(){
            $(".body-text").css("display","block !important")
        });
        $(this).children().first().toggleClass("d-none")
        $(this).children().first().next().toggleClass("d-none")

    })
    $(".down").click(function(){
        $(".responsiveRow").toggleClass("d-none")
        // $(".responsiveRow").slideToggle()
    })
   

    $(".mainLiResponsiveD").click(function(){
        
            $(this).next().slideToggle();
        
       
    })
    $(".burger").click(function(){
        
            $(this).parent().parent().next().slideDown();
            $(this).addClass("d-none");
            $(this).next().removeClass("d-none")
  
    })
    $(".cancel").click(function(){
        if($(this).parent().parent().next().css("display","block")){
            $(this).parent().parent().next().slideUp();
            $(this).addClass("d-none");
            $(this).prev().removeClass("d-none");
        }
    })

    $(".service-img").mouseover(function(){
        $(this).css({"opacity":"0.6","transition":"0.7s"})
        
    })
    $(".service-img").mouseleave(function(){
        $(this).css({"opacity":"1","transition":"0.7s"})
        
    })

    let lists=$(".servicesNamesList li");
    let services=$(".serviceDetails");
    let serviceNames=$(".namme")
    for(let list of lists){
           $(list).click(function(){
            $(".selected").removeClass("selected");
            $(this).addClass("selected")
            let data_id=$(this).attr("data-id");
            console.log();
            for(let service of services){
                if(data_id==$(service).attr("data-id")){
                    $(service).removeClass("d-none")
                }else{
                    $(service).addClass("d-none")
                }
                // console.log("ok");
            }
            for(let serviceName of serviceNames){
                if(data_id==$(serviceName).attr("data-id")){
                    $(serviceName).removeClass("d-none")
                }else{
                    $(serviceName).addClass("d-none")
                }
            }
        })
    }
})

