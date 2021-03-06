﻿$(document).ready(function () {
    // Initialize plugins
    
    // Select2 initialization
    $('.single-select').select2({
        minimumResultsForSearch: 5,
        closeOnSelect: true
    });

    $('.multi-select').select2({
        //closeOnSelect: false,
        placeholder: 'Select one or more options...'
    });

    $('.tags').select2({
        tags: true,
        tokenSeparators: [',', '\n', '\t'],
        closeOnSelect: false,
        placeholder: 'Select one or more options or type a new entry...'
    });

    // Tooltips
    $('[data-toggle="tooltip"]').tooltip({
        delay: { "show": 500 }
    });
});