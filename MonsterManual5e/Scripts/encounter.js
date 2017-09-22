$(document).ready(function () {
    
    $('[data-target="#addToEncounterModal"]').click(function () {
        var id = $(this).data('id');
        $('#addToEncounterModal [name="id"]').val(id);
    });
    
    $('[data-target="#difficultyCalculatorModal"]').click(function () {
        var id = $(this).data("id");
        //$('#difficultyCalculatorModal ["name="id""]').val() = id;
    });
});