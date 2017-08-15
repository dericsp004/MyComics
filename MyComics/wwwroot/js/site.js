// site.js
(function () {
    var comicListWrapper = $("#comicListWrapper");
    $("#hideComicsButton").on("click", function () {
        comicListWrapper.toggleClass("hide");
        if (comicListWrapper.hasClass("hide")) {
            $(this).text("Show Comics")
        }
    });

    
})();