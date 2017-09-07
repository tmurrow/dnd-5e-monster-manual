$(document).ready(function () {
    // Initialize plugins
    
    // Select2 initialization
    $('.single-select').select2({
        minimumResultsForSearch: 5,
        closeOnSelect: true
    });

    $('.multi-select').select2({
        closeOnSelect: false,
        placeholder: 'Select one or more options...'
    });

    $('.tags').select2({
        tags: true,
        tokenSeparators: [',', '\n'],
        closeOnSelect: false,
        placeholder: 'Select one or more options or type a new entry...'
    });
    
    // DataTables initialization
    var monsterTable = $('#monster-table').DataTable({
        "dom": 'ft<"row"<"col-md-4"l><"col-md-4"i><"col-md-4"p>>'
    });

    $('.filter-input').on('keyup change', function () {
        var filter = $(this).data('filter');
        var col = monsterTable.column('[data-column="' + filter + '"]');
        if (col.search() !== this.value) {
            col.search(this.value).draw();
        }
    });

    $('.filter-col-visibility').click(function (e) {
        
        e.preventDefault();
        if ($(this).data('col-show') == 'default' && !$(this).hasClass('disabled'))
        {
            monsterTable.columns('.vg-ability').every(function () {
                this.visible(false);
            });
            monsterTable.columns.adjust().draw();
            monsterTable.columns('.vg-default').every(function () {
                this.visible(true);
            });
            monsterTable.columns.adjust().draw();
            $('[data-col-show="ability"]').removeClass('disabled');
            $(this).addClass('disabled');
        }

        if ($(this).data('col-show') == 'ability' && !$(this).hasClass('disabled')) {
            monsterTable.columns('.vg-default').every(function () {
                this.visible(false);
            });
            monsterTable.columns.adjust().draw();
            monsterTable.columns('.vg-ability').every(function () {
                this.visible(true);
            });
            monsterTable.columns.adjust().draw();
            $('[data-col-show="default"]').removeClass('disabled');
            $(this).addClass('disabled');
        }
    });

    //========================

    $('.search-input-update').keyup(function () {
        $('#search-monsters-form').submit();
    });
});