$(function () {
    var divfizzbuzzList = $('#divFizzbuzz-list');

    for (var i = 0; i < 10; i++) {
        divfizzbuzzList.append($('<div class="col-sm-1"><ul id=fizzbuzz-list' + i + '></ul></div>'));
        for (var j = i*10 + 1; j <= i*10 + 10; j++) {
            var output = j;
            var color = '';

            if (j % 3 === 0) {
                output = 'fizz';
                color = 'fizz'
            }

            if (j % 5 === 0) {
                output = 'buzz';
                color = 'buzz'
            }

            if (j % 15 === 0) {
                output = 'fizz buzz';
                color = 'fizzbuzz'
            }
            var fizzbuzzList = $('#fizzbuzz-list'+i);
            fizzbuzzList.append($('<li class = ' + color + '>' + output + '</li>'));
        }

        setInterval(highlightText, 2000);
        
    }
    function highlightText() {
        $('.fizzbuzz').css('color', 'blue');
        setTimeout(function () {
            $('.fizzbuzz').css('color', 'blue');
        }, 999);
        setTimeout(function () {
            $('.fizzbuzz').css('color', 'green');
        }, 999);
    }
    


});