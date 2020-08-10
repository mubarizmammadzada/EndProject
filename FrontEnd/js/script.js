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


    $(".header-question").click(function(){
        // $(this).slideDown();
        $(this).next().children().first().slideToggle(function(){
            $(".body-text").css("display","block !important")
        });
        $(this).children().first().toggleClass("d-none")
        $(this).children().first().next().toggleClass("d-none")

    })
})
