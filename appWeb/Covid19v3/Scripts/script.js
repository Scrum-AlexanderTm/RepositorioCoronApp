$(document).ready(function () {


///provando git en asp net xd   
    $('#sidebarCollapse').on('click', function () {
        $('#sidebar').toggleClass('active');
        $(this).toggleClass('active');
        $('.footer').toggleClass('active');


    });



    $(function () {
        $("#a-btnUsuario").on("click", function (e) {
            e.preventDefault();
            var url = $(this).attr("href");
            $.get(url).done(function (result) {
                $("body").html(result);
                $('#sidebar').addClass('active');

            });

            history.pushState(null, "", url);

        });
    });
    $(function () {
        $("#a-btnHome").on("click", function (e) {


            e.preventDefault();
            $(".progress-bar").animate({
                width: "100%"
            }, 2500);
            var url = $(this).attr("href");
            $.get(url).done(function (result) {
                $("body").html(result);
                $('#sidebar').addClass('active');

            });
            history.pushState(null, "", url);
        });
    });
    $(function () {
        $("#a-btnTriaje").on("click", function (e) {
            e.preventDefault();
            var url = $(this).attr("href");
            $.get(url).done(function (result) {
                $("body").html(result);
                $('#sidebar').addClass('active');
            });
            history.pushState(null, "", url);
        });
    });
    $(function () {
        $("#a-btnMaps").on("click", function (e) {
            e.preventDefault();
            var url = $(this).attr("href");
            $.get(url).done(function (result) {
                $("body").html(result);
                $('#sidebar').addClass('active');
            });
            history.pushState(null, "", url);
        });
    });
});
