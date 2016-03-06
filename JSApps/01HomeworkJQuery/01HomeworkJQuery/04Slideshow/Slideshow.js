$(document).ready(
    function(){
        var slides = $("#slideshow > .slide");
        var currentSlide = slides.first();
        currentSlide.css('display', 'inline-block');

        $("#right").click(function(){
            changeRight();
        });

        $("#left").click(function(){
            changeLeft();
        });


        function changeLeft() {
            currentSlide.fadeOut(500);
            currentSlide = currentSlide.prev('.slide');
            if (currentSlide.length === 0) {
                currentSlide = slides.last();
            }
            currentSlide.delay(500).fadeIn(500);
        };

        function changeRight() {
            currentSlide.fadeOut(500);
            currentSlide = currentSlide.next('.slide');
            if (currentSlide.length === 0) {
                currentSlide = slides.first();
            }

            currentSlide.delay(500).fadeIn(500);
        };

        function change() {
            setInterval(changeRight,5000);
        }

        change();
    }
);


