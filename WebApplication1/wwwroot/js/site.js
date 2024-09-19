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
                countdownElement.textContent = `{hours}:{minutes}:{}`;
            }
        } else {
            countdownElement.textContent = '';
        }
    });
}

setInterval(updateCountdowns, 1000);

updateCountdowns();