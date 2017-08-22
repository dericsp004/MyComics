// site.js
(function () {
    var comicListWrapper = $("#comicListWrapper");
    var icon = $("#hideComicsButton i");
    $("#hideComicsButton").on("click", function () {
        comicListWrapper.toggleClass("hideComics");
        if (comicListWrapper.hasClass("hideComics")) {
            //$(this).text("Show")
            icon.removeClass("fa fa-angle-up");
            icon.addClass("fa fa-angle-down");
        }
        else {
            //$(this).text("Hide")
            icon.removeClass("fa fa-angle-down");
            icon.addClass("fa fa-angle-up");
        }
    });

    
})();