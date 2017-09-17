$(document).ready(function () {

    // DataTables variables

    var COLS = ["Name", "Size", "Type", "AC", "HP", "Str", "Dex", "Con", "Int", "Wis", "Cha", "Str Save", "Dex Save", "Con Save", "Int Save", "Wis Save", "Cha Save", "Passive Perception", "CR", "XP"];
    var HIDDENCOLUMNS = ["Str", "Dex", "Con", "Int", "Wis", "Cha", "Str Save", "Dex Save", "Con Save", "Int Save", "Wis Save", "Cha Save", "Passive Perception"];
    var hiddenColumnsIndexes = new Array();

    for (var i = 0; i < HIDDENCOLUMNS.length; i++)
    {
        hiddenColumnsIndexes.push(COLS.indexOf(HIDDENCOLUMNS[i]));
    }

    // DataTables initialization

    var monsterTable = $('#monster-table').DataTable({
        "paging": false,
        "info": false,
        //"dom": 'ft<"row"<"col-md-4"l><"col-md-4"i><"col-md-4"p>>',
        "columnDefs": [
            {
                "targets": hiddenColumnsIndexes,
                "visible": false,
                "searchable": false
            }
        ]
    });

    // DataTables events

    $('.filter-input').on('keyup change', function () {
        var filter = $(this).data('filter');
        var col = monsterTable.column('[data-column="' + filter + '"]');
        if (col.search() !== this.value) {
            col.search(this.value).draw();
        }
    });

    $('.filter-clear').click(function () {
        $('.filter-input').val("");
        $('.filter-input').change();
    });

    $('.filter-col-visibility').click(function (e) {

        e.preventDefault();
        if ($(this).data('col-show') == 'default' && !$(this).hasClass('active')) {
            monsterTable.columns('.vg-ability').every(function () {
                this.visible(false);
            });
            monsterTable.columns('.vg-default').every(function () {
                this.visible(true);
            });
            $('[data-col-show="ability"]').removeClass('active');
            $(this).addClass('active');
            $('.filter-default').removeClass('hidden');
            $('.filter-ability').addClass('hidden');
        }

        if ($(this).data('col-show') == 'ability' && !$(this).hasClass('active')) {
            monsterTable.columns('.vg-default').every(function () {
                this.visible(false);
            });
            monsterTable.columns('.vg-ability').every(function () {
                this.visible(true);
            });
            $('[data-col-show="default"]').removeClass('active');
            $(this).addClass('active');
            $('.filter-ability').removeClass('hidden');
            $('.filter-default').addClass('hidden');
        }

        $('#monster-table').removeAttr('style');

    });

    // Event listener to the two range filtering inputs to redraw on input
    $('#filter-min-ac, #filter-max-ac').keyup(function () {
        monsterTable.draw();
    });

    //========================

    $('.search-input-update').keyup(function () {
        $('#search-monsters-form').submit();
    });
});

$.fn.dataTable.ext.search.push(
    function (settings, data, dataIndex) {
        var min = parseInt($('#filter-min-ac').val(), 10);
        var max = parseInt($('#filter-max-ac').val(), 10);
        var age = parseFloat(data[3]) || 0; // use data for the age column

        if ((isNaN(min) && isNaN(max)) ||
             (isNaN(min) && age <= max) ||
             (min <= age && isNaN(max)) ||
             (min <= age && age <= max)) {
            return true;
        }
        return false;
    }
);