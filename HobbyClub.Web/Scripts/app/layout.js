(function () {

    var $menuItem = $('.navbar-collapse ul li');

    $('.navbar-collapse ul li a').on('click', function (el) {
        var currentUrl = window.location.href;
        $('.navbar-collapse ul li').hasClass('active').removeClass('active');
        $('.navbar-collapse ul li').find("'[href" + currentUrl + "]'").addClass('active');
    });

})();