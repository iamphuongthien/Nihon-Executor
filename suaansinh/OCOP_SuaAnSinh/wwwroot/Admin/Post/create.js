$(function () {
    $('#DateShow').datetimepicker({
        format: 'L'
    });
    selct2Sigle.shownormal({
        tag: "#SelectTag",
        placeholder: "Tags",
        addnew: true
    })
    selct2Sigle.onSelect($("#SelectTag"), function (opt) {
        var value = $("#SelectTag").val();
        $("#Tags").val(value.join(","));
    });
})