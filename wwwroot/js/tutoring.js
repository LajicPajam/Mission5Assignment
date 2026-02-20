$(document).ready(function () {
    // Flat hourly tutoring rate used for every quote.
    const hourlyRate = 30;

    function showError(show) {
        // Toggle validation message visibility without removing the element.
        const error = $("#hoursError");
        if (show) {
            error.removeClass("d-none");
        } else {
            error.addClass("d-none");
        }
    }

    $("#calcButton").on("click", function () {
        // Read hours as text first, then parse to a number for validation/calculation.
        const hoursValue = $("#hoursInput").val();
        const hours = parseFloat(hoursValue);

        // Hours must be a positive numeric value.
        if (Number.isNaN(hours) || hours <= 0) {
            showError(true);
            $("#totalOutput").val("");
            return;
        }

        showError(false);
        // Calculate and format currency output to two decimals.
        const total = hours * hourlyRate;
        $("#totalOutput").val(`$${total.toFixed(2)}`);
    });
});
