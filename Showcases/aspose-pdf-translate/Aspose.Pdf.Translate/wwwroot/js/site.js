/**
 * Handles the change event for the 'from' language selection.
 * Updates the 'to' language options based on the selected 'from' language.
 * If 'from' language is not English ('en'), sets 'to' language to French ('fr').
 */
function fromChange() {
    var from = document.querySelector('select[name=from]').value;
    document.querySelector("#to option").style.display = 'block';
    document.querySelector("#to option[value='" + from + "']").style.display = 'none';

    if (from != 'en') {
        document.querySelector('select[name=to]').value = 'en';
    }
    else {
        document.querySelector('select[name=to]').value = 'fr';
    }
}

/**
 * Initiates a translation request.
 * Prepares the data for translation and sends a request to the server.
 */
function requestTranslate() {

    console.log(filedrop);
    let data = filedrop.prepareFormData(1, o.MaximumUploadFiles);
    if (data === null)
        return;

    var from = document.querySelector('select[name=from]').value;
    var to = document.querySelector('select[name=to]').value;
    var translateAll = true;

    var url1 = o.WebApiPath + 'translate?' + 'from=' + from + '&to=' + to + '&translateAll=' + translateAll;
    requestQueue(url1, data);
}

/**
 * Returns the language code corresponding to the given language name.
 * @param {string} language - The name of the language.
 * @returns {string} The language code.
 */
function getLangCode(language) {
    const languageDictionary = {
        "english": "en",
        "german": "de",
        "french": "fr",
        "italian": "it",
        "spanish": "es",
        "arabic": "ar",
        "russian": "ru",
        "chinese": "zh",
        "portuguese": "pt",
        "polish": "pl",
        "azerbaijani": "az",
        "latvian": "lv",
        "lithuanian": "lt"
    };

    const normalizedLanguage = language.toLowerCase();
    return languageDictionary[normalizedLanguage] || '';
}


/**
 * Extends object 'a' with properties from object 'b'.
 * @param {Object} a - The target object to extend.
 * @param {Object} b - The object from which to copy properties.
 * @returns {Object} The extended object.
 */
function extend(a, b) {
    for (var key in b)
        if (b.hasOwnProperty(key))
            a[key] = b[key];
    return a;
};

extend(o, {
    Method: requestTranslate,
    FileAmountMessage: 'Please select only 10 file',
    MaximumUploadFiles: 10,
    UseSorting: false
});

/**
* Adds event listeners for DOMContentLoaded and upload button click events.
* Initializes the functionality when the DOM content is loaded.
*/
document.addEventListener("DOMContentLoaded", () => {
    hideSuccess();
    document.querySelector('#uploadButton').addEventListener('click', o.Method);
});