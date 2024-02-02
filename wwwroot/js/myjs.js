window.a = {

    WriteCookie: function (name, value, days) {

        var expires;
        if (days) {
            var date = new Date();
            date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
            expires = "; expires=" + date.toGMTString();
        }
        else {
            expires = "";
        }
        document.cookie = name + "=" + value + expires + "; path=/";
    },

    ReadCookie: function () {
        var nameEQ = "_user" + "=";
        var ca = document.cookie.split(';');
        for (var i = 0; i < ca.length; i++) {

            var c = ca[i];

            while (c.charAt(0) == ' ') {
                c = c.substring(1, c.length);
            }

            if (c.indexOf(nameEQ) == 0) {
                return c.substring(nameEQ.length, c.length);
            }
        }
        return "";
    },

    Draw: function drawChart(process, date) {
          
    },

    WriteCycle: function(value){
        var expires;
        var days = 1;
        if (days) {
            var date = new Date();
            date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
            expires = "; expires=" + date.toGMTString();
        }
        else {
            expires = "";
        }
        document.cookie = "_cycleId" + "=" + value + expires + "; path=/";
    },

    ReadCycle: function(){
        var nameEQ = "_cycle" + "=";
        var ca = document.cookie.split(';');
        for (var i = 0; i < ca.length; i++) {

            var c = ca[i];

            while (c.charAt(0) == ' ') {
                c = c.substring(1, c.length);
            }

            if (c.indexOf(nameEQ) == 0) {
                return c.substring(nameEQ.length, c.length);
            }
        }
        return "";
    },

    RemoveCycle: function(){
        document.cookie = "_cycleId=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";
    },
}

window.notify = {
    success: function (message) {
        alert(message);
    },
    error: function (message) {
        alert(message);
    },
    warning: function (message) {
        alert(message);
    },
    info: function (message) {
        alert(message);
    }
}