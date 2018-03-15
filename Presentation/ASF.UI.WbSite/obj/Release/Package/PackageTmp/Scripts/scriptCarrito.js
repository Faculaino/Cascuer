$(".btnSumar").click(function(e) {
        var id = $(this).attr("name");
        var value = parseInt($("span#" + id).text());
        value++;
        $("span#" + id).text(value);
        $("input." + id).val(value);
        $("#" + id + ".btnConfirmar").show();
        
    });

$(".btnRestar").click(function (e) {
        var id = $(this).attr("name");
        var value = parseInt($("span#" + id).text());
        value--;
        if (value <= 0)
        {value = 0}
        $("span#" + id).text(value);
        $("input." + id).val(value);
        $("#" + id + ".btnConfirmar").show();
    });





