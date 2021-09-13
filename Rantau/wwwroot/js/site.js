// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

showPopupSendMessage = (url, title) => {
    $.ajax({
        type: 'GET',
        url: url,
        success: function (res) {
            $('#form-modal-message .modal-body').html(res);
            $('#form-modal-message .modal-title').html(title);
            $('#form-modal-message').modal('show');
            // to make popup draggable
            $('.modal-dialog').draggable({
                handle: ".modal-header"
            });
        }
    })
}

hidePopupSendMessage = () => {
    $('#form-modal-message').modal('hide');
}


function getSelectedTemplatPesan(Sle) {
    $.ajax({
        url: "/HistoriPesan/GetSelectedTemplatePesan",
        data: { "description": Sle.value },
        type: "Post",
        dataType: "text",
        success: function (data) {
            console.log(data);
            $("#isiPesan").val(data);

        },
        error: function (data) {
            alert(data);
        }
    });
}
