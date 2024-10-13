function updateCountdowns() {
    const clocks = document.querySelectorAll('.clock-js');
    const now = Math.floor(Date.now() / 1000);

    clocks.forEach(clock => {
        const timestamp = clock.getAttribute('data-timestamp');
        const countdownElement = clock.querySelector('.countdown');
        const timeLeft = timestamp - now;

        if (timeLeft > 0) {
            const days = Math.floor(timeLeft / (24 * 60 * 60));
            const hours = Math.floor((timeLeft % (24 * 60 * 60)) / (60 * 60));
            const minutes = Math.floor((timeLeft % (60 * 60)) / 60);
            const seconds = timeLeft % 60;

            if (days > 0) {
                countdownElement.textContent = `${days} days`;

            }
            else {
                countdownElement.textContent = `{hours}:{minutes}`;
            }
        } else {
            countdownElement.textContent = '';
        }
    });
}

$(document).ready(function () {
    $('#BrandId').on('change', function () {
        var brandId = $(this).val();
        $.ajax({
            type: 'GET',
            url: '/Account/GetModelsByBrand',
            data: { brandId: brandId },
            success: function (data) {
                $('#modelSelect').empty();
                $.each(data, function (index, item) {
                    $('#modelSelect').append('<option value="' + item.id + '">' + item.name + '</option>');
                });
            }
        });
    });
});

$(document).ready(function () {
    $('#VenichleId').on('change', function () {
        console.log('change');
        var vehicleId = $(this).val();
        $.ajax({
            type: 'GET',
            url: '/Account/GetVehicleDetails',
            data: { vehicleId: vehicleId },
            success: function (data) {
                $('#model').text(data.model);
                $('#brand').text(data.brand);
                $('#exteriorColor').text(data.exteriorColor);
                $('#year').text(data.year);
                $('#interiorColor').text(data.interiorColor);
                $('#odometr').text(data.odometr);
                $('#vin').text(data.vin);
                $('#fuelType').text(data.fuelType);
                $('#bodyStyle').text(data.bodyStyle);
                $('#transmission').text(data.transmission);
                $('#vehicleImage').attr('src', data.imageUrl);
            }
        });
    });
});


setInterval(updateCountdowns, 1000);

updateCountdowns();