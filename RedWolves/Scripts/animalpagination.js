// JavaScript source code
$(document).ready(function () {

    //assign button a value, remove active, add active to clicked
    //1 callback
    $('.animalbutton').on('click', function () {
        var animaltoShow = $(this).attr('rel');
        $('#' + animaltoShow).button();
        $('.animalbutton').removeClass('active');
        $(this).addClass('active');

        //change active class on the content
        //2 callback plus function call
        $('.animal').removeClass('active');
        $(this).show(function () {
            $("#" + animaltoShow).addClass('active', isactive);
        })

        function isactive() {
            //check if active, toggle visibility
            if (!'.animal .active') {
                document.getElementByClass('.animal').style.visibility = 'hidden';
            }
            else {
                document.getElementByClass('.animal .active').style.visibility = 'visible';
            }
        }

    })
})
