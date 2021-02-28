(function () {
    $("#btn_add").click(function (e) {
        e.preventDefault();
        $.get("/Admin/Posts/Create", function (data) {
            $('#sharing_modal .modal-content').html(data);
            $('#sharing_modal').modal("show");
        });
    })
    $("body").on("click", "#btn_cancel", function (e) {
        e.preventDefault();
        $('#sharing_modal').modal('hide');
    })
    $("body").on("click", "#btn_remove", function (e) {
        e.preventDefault();
        $('#sharing_modal').modal('hide');
    })
    $("body").on("click", "#btn_save_create", function (e) {
        e.preventDefault();
        if ($("#frmCreatePosts").valid()) {
            $("#frmCreatePosts").submit();
        }
    })
    $("body").on("click", "#btn_save_edit", function (e) {
        e.preventDefault();
        if ($("#frmEditPosts").valid()) {
            $("#frmEditPosts").submit();
        }
    })
    $("body").on("click", ".btn-edit", function (e) {
        e.preventDefault();
        var id = $(this).data("id");
        $.get("/Admin/Posts/Edit/" + id, function (data) {
            $('#sharing_modal .modal-content').html(data);
            $('#sharing_modal').modal('show');
        });
    })

    $("body").on("click", ".btn-delete", function (e) {
        e.preventDefault();
        var id = $(this).data("id");
        Swal.fire({
            title: 'Bạn muốn xóa trường thông tin này?',
            showDenyButton: true,
            showCancelButton: true,
            confirmButtonText: `Đồng Ý`,
            cancelButtonText: `Đóng`,
        }).then((result) => {
            if (result.value) {
                $.get("/Admin/Posts/Delete/" + id, function (res) {
                    if (res.status == "success") {
                        toastr.success('Xóa thành công.')
                        location.reload();
                    } else {
                        toastr.error(res.message)
                    }
                });
            }
        })
    })
})