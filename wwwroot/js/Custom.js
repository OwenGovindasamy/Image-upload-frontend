//form Submit
//$("ImageForm").submit(function (e) {
//    e.preventDefault();
//    var formData = new FormData($(this)[0]);
//    $.ajax({
//        url: 'http://localhost:44386/api/photos',
//        type: 'POST',
//        data: formData,
//        async: false,
//        cache: false,
//        contentType: false,
//        enctype: 'multipart/form-data',
//        processData: false,
//        success: function (response) {
//            alert(response + "done");
//        }
//    });
//    return false;
//});

$(document).ready(function (e) {
    $('#Delbtn').on('click', function (e) {
        var id = $(this).data("value");

        $.ajax({
            url: "https://localhost:44386/api/photos/" + id,
            type: "DELETE",
            data: {},
            success: function () {
                alert("Deleted");
                location.reload();
                return false;
            },
            error: function (e) {
                alert("failed");
            }
        });
    });

    $("#form").on('submit', (function (e) {
        e.preventDefault();
        $.ajax({
            url: "https://localhost:44386/api/photos",
            type: "POST",
            data: new FormData(this),
            contentType: false,
            cache: false,
            processData: false,
            beforeSend: function () {
                $("#err").fadeOut();
            },
            success: function (data) {
                location.reload();
                return false;
            },
            error: function (e) {
                alert("failed");
                console.log(data);
            }
        });
    }));
});