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

    Draw: function () {
        var data = {
            labels: ["Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5"],
            datasets: [{
                label: "Doanh số bán hàng",
                data: [50, 80, 60, 90, 75],
                borderColor: 'rgba(75, 192, 192, 1)',
                borderWidth: 2,
                fill: false
            }]
        };
    
        // Cấu hình biểu đồ
        var options = {
            responsive: true,
            maintainAspectRatio: false,
            scales: {
                x: {
                    type: 'category',
                    labels: data.labels
                },
                y: {
                    beginAtZero: true
                }
            }
        };
    
        // Lấy tham chiếu đến canvas
        var ctx = document.getElementById('chartLine').getContext('2d');
    
        // Tạo biểu đồ đường
        var myLineChart = new Chart(ctx, {
            type: 'line',
            data: data,
            options: options
        });
    }
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