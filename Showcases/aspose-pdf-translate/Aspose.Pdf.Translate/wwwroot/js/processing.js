/**
 * Displays the loading spinner.
 */
function showLoader() {
    const loading = document.getElementById('processing')
    loading.classList.remove('hidden');
}

/**
 * Hides the loading spinner.
 */
function hideLoader() {
    const loading = document.getElementById('processing')
    loading.classList.add('hidden');
}

/**
 * Displays the upload form.
 */
function showUploadForm() {
    const uploadBlock = document.getElementById('loader')
    uploadBlock.style.display = 'block'
}

/**
 * Hides the upload form.
 */
function hideUploadForm() {
    const uploadBlock = document.getElementById('loader')
    uploadBlock.style.display = 'none'
}

/**
 * Displays the success message.
 */
function showSuccess() {
    const success = document.getElementById('DownloadPlaceHolder')
    success.classList.remove('hidden');
}

/**
 * Hides the success message.
 */
function hideSuccess() {
    const success = document.getElementById('DownloadPlaceHolder')
    success.classList.add('hidden');
}

/**
 * Shows an alert message with the provided text.
 * Hides the loading spinner.
 * Scrolls to the alert message for better visibility.
 * @param {string} message - The message to be displayed in the alert.
 */
function showAlert(message) {
    hideLoader();
    const alertMessage = document.querySelector('#alertMessage');
    
    alertMessage.innerHTML = message;
    alertMessage.classList.remove("hidden");
    alertMessage.scrollIntoView({ behavior: 'smooth', block: 'center' });
}

/**
 * Hides the alert message.
 */
function hideAlert() {
    const alertMessage = document.querySelector('#alertMessage'); 
    if (alertMessage)
        alertMessage.classList.add("hidden");
}

/**
 * Disables the upload button.
 */
function disableButton() {
    const button = document.getElementById("uploadButton");
    button.disabled = true;
}

/**
 * Enables the upload button.
 */
function activeButton() {
    const button = document.getElementById("uploadButton");
    button.disabled = false;
}
