
$('.menu-option').each(function () {
    console.log('Texto: ' + $(this).children(0).text() + " Url: " + window.location.pathname.split("/", 3)[2]);
    if ($(this).hasClass(window.location.pathname.split("/", 3)[2])) {
        $(this).addClass('active');
    }
})