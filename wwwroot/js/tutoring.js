$(document).ready(function () {
    const hourlyRate = 30;

    function showError(show) {
        const error = $("#hoursError");
        if (show) {
            error.removeClass("d-none");
        } else {
            error.addClass("d-none");
        }
    }

    $("#calcButton").on("click", function () {
        const hoursValue = $("#hoursInput").val();
        const hours = parseFloat(hoursValue);

        if (Number.isNaN(hours) || hours <= 0) {
            showError(true);
            $("#totalOutput").val("");
            return;
        }

        showError(false);
        const total = hours * hourlyRate;
        $("#totalOutput").val(`$${total.toFixed(2)}`);
    });
});
