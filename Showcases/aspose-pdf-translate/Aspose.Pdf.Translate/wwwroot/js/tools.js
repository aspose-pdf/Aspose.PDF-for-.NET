/**
 * Checks if the given value is null or empty.
 * @param {*} value - The value to check.
 * @returns {boolean} Returns true if the value is null, undefined, or an empty string, otherwise false.
 */
function isNullOrEmpty(value) {
    return (value === null || value === undefined || (typeof value === 'string' && value === ''));
}

/**
 * Shows the loading waiter element by setting its display style to 'block'.
 */
function showLoadingWaiter() {
    var obj = document.getElementById("loading-waiter");
    if (!isNullOrEmpty(obj)) {
        obj.style.display = 'block';
    }
}

/**
 * Hides the loading waiter element by setting its display style to 'none'.
 */
function hideLoadingWaiter() {
    var obj = document.getElementById("loading-waiter");
    if (!isNullOrEmpty(obj)) {
        obj.style.display = 'none';
    }
}
