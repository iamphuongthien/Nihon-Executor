var selct2Sigle = {
    show: function($options) {
        $($options.tag).select2({
            placeholder: $options.placeholder,
            data: $options.selected,
            ajax: {
                url: $options.url,
                data: function (params) {
                    var query = {
                        Filter: params.term,
                        Table: $options.table,
                        Condition: $options.condition
                    }
                    return query;
                },
                processResults: function (data) {
                    return {
                        results: data.result
                    };
                },
            }
        })
        if ($options.selected != null) {
            $($options.tag).select2().val($options.selected[0].id).trigger("change");
        }
    },
    onSelect: function ($tag, callback) {
        $tag.on('select2:select', function (e) {
            callback(e);
        });
    },
    onDestroy: function ($tag) {
        if ($($tag).data('select2')) {
            $($tag).select2('destroy');
        }
    },
    shownormal: function ($options) {
        $($options.tag).select2({
            placeholder: $options.placeholder,
            tags: $options.addnew,
            data: $options.selected
        })

        if ($options.selected != null) {
            $($options.tag).select2().val($options.selected).trigger("change");
            $($options.tag).select2({ tags: true })
        }
    }
}