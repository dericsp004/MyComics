// site.js
(function () {
    var comicListWrapper = $("#comicListWrapper");
    $("#hideComicsButton").on("click", function () {
        comicListWrapper.toggleClass("hideComics");
        if (comicListWrapper.hasClass("hideComics")) {
            $(this).text("Show Comics")
        }
        else {
            $(this).text("Hide Comics")
        }
    });

    
})();