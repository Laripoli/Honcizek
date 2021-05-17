
$('.menu-option').each(function () {
    if ($(this).hasClass(window.location.pathname.split("/", 3)[2])) {
        $(this).addClass('active');
    }
})