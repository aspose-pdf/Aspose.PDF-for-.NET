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

    let data = fileDrop.prepareFormData(1, o.MaximumUploadFiles);
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


var o = {
    "MaximumUploadFileSize": 31457280,
    "FileMaximumUploadSizeReachedMessage": "Files upload size must be equal or less than 31457280 bytes. To remove limitation of direct upload you can Enter Url from google drive, dropbox or from public web.",
    "AppURL": "https://products.aspose.app/pdf/translate",
    "AppName": "translate",
    "OriginalAppName": "Translate",
    "AppRoute": "/pdf/translate",
    "WebApiPath": "https://localhost:5002/pdf/webapi/",
    "UIBasePath": "",
    "FileSelectMessage": "Please select a file to upload",
    "MaximumUploadFiles": 10,
    "FileAmountMessage": "Please select less than ten files",
    "FileEmptyMessage": "Selected file is empty",
    "UseSorting": true,
    "FileWrongTypeMessage": "You are trying to upload document(s) of unsupported type:",
    "CurrentAppLang": "en",
    "AppRouteTemplate": "/pdf{0}/translate",
    "AllSupportedLang": [
        { "Id": "id", "Description": "Bahasa Indonesia", "ChangeToLanguage": "Indonézre váltani?", "UrlId": "/id" },
        { "Id": "ms", "Description": "Bahasa Melayu", "ChangeToLanguage": "Tukar ke melayu?", "UrlId": "/ms" },
        { "Id": "ca", "Description": "Català", "ChangeToLanguage": "Voleu canviar al català?", "UrlId": "/ca" },
        { "Id": "cs", "Description": "Čeština", "ChangeToLanguage": "Změnit na češtinu?", "UrlId": "/cs" },
        { "Id": "da", "Description": "Dansk", "ChangeToLanguage": "Skift til dahish?", "UrlId": "/da" },
        { "Id": "de", "Description": "Deutsch", "ChangeToLanguage": "Auf Deutsch wechseln?", "UrlId": "/de" },
        { "Id": "nl", "Description": "Dutch", "ChangeToLanguage": "Veranderen naar nederlands?", "UrlId": "/nl" },
        { "Id": "en", "Description": "English", "ChangeToLanguage": "Change to English?", "UrlId": "" },
        { "Id": "es", "Description": "Español", "ChangeToLanguage": "¿Cambiar al español?", "UrlId": "/es" },
        { "Id": "fr", "Description": "Français", "ChangeToLanguage": "Changer en français ?", "UrlId": "/fr" },
        { "Id": "it", "Description": "Italiano", "ChangeToLanguage": "Cambia in italiano?", "UrlId": "/it" },
        { "Id": "lt", "Description": "Lietuvis", "ChangeToLanguage": "Keisti į lietuvišką?", "UrlId": "/lt" },
        { "Id": "hu", "Description": "Magyar", "ChangeToLanguage": "Magyarra váltani?", "UrlId": "/hu" },
        { "Id": "fil", "Description": "Pilipino", "ChangeToLanguage": "Palitan ng filipino?", "UrlId": "/fil" },
        { "Id": "pl", "Description": "Polski", "ChangeToLanguage": "Zmienić na polski?", "UrlId": "/pl" },
        { "Id": "pt", "Description": "Português", "ChangeToLanguage": "Mudar para português?", "UrlId": "/pt" },
        { "Id": "ro", "Description": "Română", "ChangeToLanguage": "Treceți la română?", "UrlId": "/ro" },
        { "Id": "sv", "Description": "Svenska", "ChangeToLanguage": "Byt till svenska?", "UrlId": "/sv" },
        { "Id": "vi", "Description": "Tiếng Việt", "ChangeToLanguage": "Đổi sang tiếng Việt?", "UrlId": "/vi" },
        { "Id": "tr", "Description": "Türkçe", "ChangeToLanguage": "Türkçe değiştir?", "UrlId": "/tr" },
        { "Id": "el", "Description": "Ελληνικά", "ChangeToLanguage": "Αλλαγή σε ελληνικά;", "UrlId": "/el" },
        { "Id": "bg", "Description": "Български", "ChangeToLanguage": "Да се промени на български?", "UrlId": "/bg" },
        { "Id": "kk", "Description": "Қазақ", "ChangeToLanguage": "Қазақ тіліне ауысу керек пе?", "UrlId": "/kk" },
        { "Id": "ru", "Description": "Русский", "ChangeToLanguage": "Изменить на Русский?", "UrlId": "/ru" },
        { "Id": "uk", "Description": "Українська", "ChangeToLanguage": "Змінити на українську?", "UrlId": "/uk" },
        { "Id": "he", "Description": "עִברִית", "ChangeToLanguage": "לעבור לעברית?", "UrlId": "/he" },
        { "Id": "ar", "Description": "العربية", "ChangeToLanguage": "تغيير إلى العربية؟", "UrlId": "/ar" },
        { "Id": "fa", "Description": "فارسی", "ChangeToLanguage": "تغییر به فارسی؟", "UrlId": "/fa" },
        { "Id": "hi", "Description": "हिंदी", "ChangeToLanguage": "हिंदी में बदलें?", "UrlId": "/hi" },
        { "Id": "th", "Description": "ภาษาไทย", "ChangeToLanguage": "เปลี่ยนเป็นภาษาไทย?", "UrlId": "/th" },
        { "Id": "ko", "Description": "한국어", "ChangeToLanguage": "한국어로 변경 하시겠습니까?", "UrlId": "/ko" },
        { "Id": "zh-hant", "Description": "中國傳統的", "ChangeToLanguage": "換成中文？", "UrlId": "/zh-hant" },
        { "Id": "zh", "Description": "中文", "ChangeToLanguage": "换成中文？", "UrlId": "/zh" },
        { "Id": "ja", "Description": "日本語", "ChangeToLanguage": "日本語に変更しますか？", "UrlId": "/ja" }
    ],
    "FileProcessingErrorCodes": {
        "10001": "No search results",
        "10002": "Wrong regular expression"
    },
    "UploadOptions": ["PDF"],
    "AcceptAllFormats": false,
    "Multiple": true,
    "DropFilesPrompt": "Drop or upload your files*",
    "Accept": ".pdf"
};


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
    FileAmountMessage: 'Please select only one file',
    MaximumUploadFiles: 1,
    UseSorting: false
});